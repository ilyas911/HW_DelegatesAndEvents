using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Interfaces
{
    public interface IUserInterface
    {
        void InitalizeChoiseCollectionType();
        int ChooseRandomOrTestCollection();
        void InitalizeChoiseCheckingFileFound();
        bool ChooseCheckingFileFound();
    }
}
