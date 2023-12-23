using ComputerVisionTool.Controls.CustomControls;

namespace ComputerVisionTool
{
    public class NamedInput
    {
        public string Name { get; set; }
        public ImageOutput ImageOutput { get; set; }

        public NamedInput(string name, ImageOutput imageOutput)
        {
            Name = name;
            ImageOutput = imageOutput;
        }

        public override string ToString() => Name;
    }

    public static class NameManager
    {
        public static Dictionary<ImageOutput, NamedInput> NamedInputsByImage = new();
    }
}