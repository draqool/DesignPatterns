namespace CompositePattern
{
    public class MusicFile : IFile
    {
        private string _name;

        public MusicFile(string name)
        {
            _name = name;
        }

        public void DisplayName()
        {
            System.Console.WriteLine($"File name: {_name}");
        }
    }
}