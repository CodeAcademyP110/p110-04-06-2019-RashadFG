namespace _07._06._19
{
    public class Category
    {
        public int id { get; set; } = 1;
        public string Id { get; set; }
        public string Name { get; set; }
        public Category()
        {
            Id = id.ToString();
            id++;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
