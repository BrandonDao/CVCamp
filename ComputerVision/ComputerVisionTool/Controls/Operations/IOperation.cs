namespace ComputerVisionTool.Controls.Operations
{
    public interface IOperation
    {
        public OperationInfo OpInfo { get; set; }

        public void UpdateAll();
    }
}