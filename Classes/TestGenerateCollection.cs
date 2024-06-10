using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class TestGenerateCollection : Interfaces.ICollectionProvider<Classes.MySomeCollectionItem>
    {
        public IEnumerable<MySomeCollectionItem> GetCollection()
        {
            List<MySomeCollectionItem> mySomeCollection = new List<MySomeCollectionItem>();
            mySomeCollection.Add(new MySomeCollectionItem(1, 43));
            mySomeCollection.Add(new MySomeCollectionItem(2, 7));
            mySomeCollection.Add(new MySomeCollectionItem(3, 18));
            mySomeCollection.Add(new MySomeCollectionItem(4, 321));
            mySomeCollection.Add(new MySomeCollectionItem(5, 564));
            mySomeCollection.Add(new MySomeCollectionItem(6, 121));
            mySomeCollection.Add(new MySomeCollectionItem(7, 48));
            return mySomeCollection;
        }
    }
}
