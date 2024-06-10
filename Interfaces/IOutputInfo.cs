using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Interfaces
{
    public interface IOutputInfo<T>
    {
        void OutputMaxItem(T maxItem);
        void OutputFoundFiles(object foundFiles);
        void OutputCollection(IEnumerable<T> someCollection);
        void OutputSearchStopped();
    }
}
