using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class RandomGenerateCollection: Interfaces.ICollectionProvider<Classes.MySomeCollectionItem>
    {
        public int Size { get; set; }
        public int MaxValue { get; set; }
        private Random _random;

        public RandomGenerateCollection(int size, int maxValue)
        {
            Size = size;
            MaxValue = maxValue;
            _random = new Random();
        }

        public IEnumerable<MySomeCollectionItem> GetCollection()
        { 
            List<MySomeCollectionItem> mySomeCollection = new List<MySomeCollectionItem>();
            for (int i = 1; i <= Size; i++)
            {
                mySomeCollection.Add(new MySomeCollectionItem(i, _random.Next(1, MaxValue + 1)));
            }
            return mySomeCollection;
        }
    }
}
