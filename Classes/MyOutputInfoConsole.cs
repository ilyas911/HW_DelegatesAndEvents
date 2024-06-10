using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_DelegatesAndEvents.Interfaces;

namespace HW_DelegatesAndEvents.Classes
{
    public class MyOutputInfoConsole: IOutputInfo<MySomeCollectionItem>
    {
        public void OutputMaxItem(MySomeCollectionItem maxItem)
        {
            Console.WriteLine("Член списка с максимальным значением: Id - " + maxItem.Id + ", MyValue - " + maxItem.MyValue);
        }
        public void OutputCollection(IEnumerable<MySomeCollectionItem> mySomeCollection)
        {
            Console.WriteLine("Иницализированный список:");
            foreach (var item in mySomeCollection) 
            {
                Console.WriteLine("Id - " + item.Id + ", MyValue - " + item.MyValue);
            }
        }
        public void OutputFoundFiles(object foundFiles)
        {
            Console.WriteLine("Найденные файлы: " + foundFiles.ToString());
        }
        public void OutputSearchStopped()
        { 
            Console.WriteLine("Поиск завершен!"); 
        }
    }
}
