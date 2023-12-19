using Emgu.CV;
using Emgu.CV.UI;
using System.Text.RegularExpressions;

namespace ComputerVision
{
    internal class BackingFunctions
    {
        public enum ImageBoxTags
        {
            Left = 0,
            Right = 1,
            Output = 2,
        };

        public enum OperationTypes
        {
            NOT,
            AND,
            OR,
            XOR
        }

        public const string BasePath = @"..\..\..\..\..\";
        const string DefaultLeftPath = BasePath + @"images\cat.png";
        const string DefaultRightPath = BasePath + @"images\star.png";

        public static Mat? LHSMat;
        public static Mat? RHSMat;
        public static Mat? OutputMat;

        static string? lhsMatName;
        static string? rhsMatName;

        static OperationTypes operationType;

        public static void LoadDefaultMats()
        {
            LHSMat = CvInvoke.Imread(DefaultLeftPath);
            lhsMatName = "cat";
            RHSMat = CvInvoke.Imread(DefaultRightPath);
            rhsMatName = "star";

            OutputMat = new Mat();
        }

        public static void HandleImageSelection(object imgBox, OpenFileDialog fileDialog, ImageBox lhs, ImageBox rhs, ImageBox output)
        {
            ImageBoxTags tag = (ImageBoxTags)((ImageBox)imgBox).Tag;

            Mat selectedMat = CvInvoke.Imread(fileDialog.FileName);
            string matName = Regex.Match(fileDialog.FileName, @"\\([a-zA-Z0-9-]*).png").Groups[1].Value;

            switch (tag)
            {
                case ImageBoxTags.Left: LHSMat = selectedMat; lhsMatName = matName; break;
                case ImageBoxTags.Right: RHSMat = selectedMat; rhsMatName = matName; break;

                default: throw new ArgumentException($"unexpected sender tag: {tag}!");
            }

            UpdateImageBoxes(lhs, rhs, output);
        }

        public static void HandleOperationSelection(int operationIndex, ImageBox lhs, ImageBox rhs, ImageBox output)
        {
            operationType = (OperationTypes)operationIndex;
            UpdateImageBoxes(lhs, rhs, output);
        }

        public static void HandleSaveImage(bool autoName)
        {
            if(autoName)
            {
                if(operationType == OperationTypes.NOT)
                {
                    CvInvoke.Imwrite(BasePath + @$"images\NOT{lhsMatName}.png", OutputMat);
                }
                else
                {
                    bool isSuccess = CvInvoke.Imwrite(BasePath + @$"images\{lhsMatName}{operationType}{rhsMatName}.png", OutputMat);
                }
            }
        }



        public static void UpdateImageBoxes(ImageBox lhs, ImageBox rhs, ImageBox output)
        {
            lhs.Image = LHSMat;
            rhs.Image = RHSMat;

            switch (operationType)
            {
                case OperationTypes.NOT: CvInvoke.BitwiseNot(LHSMat, OutputMat); rhs.Image = null; break;
                case OperationTypes.AND: CvInvoke.BitwiseAnd(LHSMat, RHSMat, OutputMat); break;
                case OperationTypes.OR: CvInvoke.BitwiseOr(LHSMat, RHSMat, OutputMat); break;
                case OperationTypes.XOR: CvInvoke.BitwiseXor(LHSMat, RHSMat, OutputMat); break;
            }

            output.Image = OutputMat;
        }
    }
}