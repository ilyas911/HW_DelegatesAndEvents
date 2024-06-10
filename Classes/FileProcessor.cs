using HW_DelegatesAndEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class FileProcessor : IFileProcessor
    {
        public event EventHandler<FileArgs> FileFound;

        public void ProcessFiles(string directory, IOutputInfo<MySomeCollectionItem> outputter)
        {
            foreach (var file in Directory.EnumerateFiles(directory))
            {
                OnFileFound(new FileArgs(file, outputter));
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }
    }
}
