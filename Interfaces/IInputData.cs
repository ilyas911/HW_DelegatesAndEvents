using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Interfaces
{
    public interface IInputData
    {
        void InitializeInputFolderPath();
        void InitializeInputCollectionSize();
        void InitializeInputMaxValue();
        int CheckInputCollectionSize();
        int CheckInputMaxValue();
        string InputFolderPath();
    }
}
