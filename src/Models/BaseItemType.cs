namespace PoEHUD.Models
{
    public class BaseItemType
    {
        public string[] Tags;
        public string[] MoreTagsFromPath;
        public string ClassName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int DropLevel { get; set; }
        public string BaseName { get; set; }
    }
}
