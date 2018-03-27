using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Directory : IFile
    {
        private string _name;
        private List<IFile> _includedFiles = new List<IFile>();

        public Directory(string name)
        {
            _name = name;
        }

        public void Add(IFile file)
        {
            _includedFiles.Add(file);
        }

        public void DisplayName()
        {
            System.Console.WriteLine($"Directory name: {_name}");

            _includedFiles.ForEach(f => f.DisplayName());
        }
    }
}
