namespace husky_demo.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int MyProperty { get; set; }

        public int ID1 { get; set; }
    }
}
