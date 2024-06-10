using HW_DelegatesAndEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; }
        public IOutputInfo<MySomeCollectionItem> Outputter { get; set; }

        public FileArgs(string fileName, IOutputInfo<MySomeCollectionItem> outputter)
        {
            FileName = fileName;
            Outputter = outputter;
        }
    }
}
