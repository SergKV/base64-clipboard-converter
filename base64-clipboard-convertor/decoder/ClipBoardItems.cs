namespace decoder
{
    public class ClipBoardItems
    {
        public List<ClipBoardItem> List { get; set; }

        public ClipBoardItems()
        {
            List = new List<ClipBoardItem>();
        }
        public void Add(ClipBoardItem item)
        {
            item.ID = List.Count > 0 ? List.Max(x => x.ID) + 1 : 1;
            List.Add(item);
        }

        public void Remove(ClipBoardItem item)
        {
            List.Remove(item);
            List.ForEach((x) => { if (x.ID > item.ID) x.ID--; });
        }

        public ClipBoardItem Get(string text)
        {
            return List.First(item => item.Text == text || item.Base64 == text);
        }
    }
}
