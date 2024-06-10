using HW_DelegatesAndEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public static class Extensions
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            T maxItem = default(T);
            float max = float.MinValue;
            foreach (var item in collection)
            {
                float value = convertToNumber(item);
                if (value > max)
                {
                    max = value;
                    maxItem = item;
                }
            }
            return maxItem;
        }
    }
}
