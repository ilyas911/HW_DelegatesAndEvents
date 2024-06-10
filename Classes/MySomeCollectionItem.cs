using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class MySomeCollectionItem
    {
        public int Id { get; set; }
        public int MyValue { get; set; }
        public MySomeCollectionItem() { }
        public MySomeCollectionItem(int id, int myValue)
        {
            Id = id;
            MyValue = myValue;
        }
        public override string ToString()
        {
            return MyValue.ToString();
        }
    }
}
