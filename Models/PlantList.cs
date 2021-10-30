namespace Pipseek.Models
{
    public static class Plants
    {
        public static Dictionary<string, string> List = new()
        {
            { "plant001.png", "This is a fake plant that has something to do with something"},
            { "plant002.png", "Of course this plant is even worse than the first one"},
        };

        public static KeyValuePair<string, string> GetRandom()
        {
            return List.OrderBy(x=>Guid.NewGuid()).First();
        }
    }
}
