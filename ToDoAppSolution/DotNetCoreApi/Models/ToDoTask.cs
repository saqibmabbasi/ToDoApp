namespace DotNetCoreApi.Models
{
    public class ToDoTask
    {
        public int ID { get; set; }
        public string TITLE { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public DateTime START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public bool STATUS { get; set; } = true;
    }
}
