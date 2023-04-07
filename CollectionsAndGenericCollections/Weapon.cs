namespace CollectionsAndGenericsCollections
{
    internal class Weapon
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Weapon name: {Name}";
        }
    }
}