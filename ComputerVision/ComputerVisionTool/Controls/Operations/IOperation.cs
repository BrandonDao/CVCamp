namespace ComputerVisionTool.Controls.Operations
{
    public interface IOperation
    {
        public OperationInfo OpInfo { get; }
        public CVToolsForm ContainerForm { get; set; }

        public void UpdateAll();
    }
}