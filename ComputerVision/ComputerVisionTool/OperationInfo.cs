namespace ComputerVisionTool
{
    public class OperationInfo
    {
        public static int AvailableID { get; private set; } = 1;
        public int ID { get; private set; }

        public static OperationInfo BaseOperationInfo { get; } = new OperationInfo();

        public OperationInfo()
        {
            ID = AvailableID++;
        }
    }
}