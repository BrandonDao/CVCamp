namespace ComputerVisionTool
{
    public class OperationInfo
    {
        public static int AvailableID { get; private set; }
        public int ID { get; private set; }

        public OperationInfo()
        {
            ID = AvailableID++;
        }
    }
}