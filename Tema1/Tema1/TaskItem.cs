namespace Tema1
{
    public class TaskItem
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Priority { get; set; } = "";
        public string Status { get; set; } = "";

        public override string ToString()
        {
            return $"{Title} - {Priority} - {Status}";
        }
    }
}