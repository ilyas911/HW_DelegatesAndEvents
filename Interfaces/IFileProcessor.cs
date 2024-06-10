using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_DelegatesAndEvents.Classes;

namespace HW_DelegatesAndEvents.Interfaces
{
    public interface IFileProcessor
    {
        event EventHandler<FileArgs> FileFound;
        void ProcessFiles(string directory, IOutputInfo<MySomeCollectionItem> outputter);
    }
}
