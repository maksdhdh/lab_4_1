namespace lab_4_1
{
    public class Photo
    {
        public string Name { get; internal set; }

        public override string ToString()
        {
            return $"Photo Name: {Name}";
        }
    }
}
