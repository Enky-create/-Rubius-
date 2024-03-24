namespace Lesson9
{
    public enum ContentType
    {
        File,
        Directory
    }
    public class Content
    {
        public ContentType Type { get; set; }
        public string Name { get; set; }
        public DateTime LastModified { get; set; } = DateTime.Now;
        public Content(ContentType type, string name, DateTime created)
        {
            Type = type;
            Name = name;
            LastModified  = created;
        }
    }
}
