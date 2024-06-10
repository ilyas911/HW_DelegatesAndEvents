using HW_DelegatesAndEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndEvents.Classes
{
    public class MyUserInterfaceConsole: IUserInterface
    {
        public void InitalizeChoiseCollectionType()
        {
            Console.WriteLine("Выберите тип генерации коллекции:");
            Console.WriteLine("1) Заготовленная коллекция");
            Console.WriteLine("2) Случайно генерируемая коллекция");
        }
        public void InitalizeChoiseCheckingFileFound()
        {
            Console.WriteLine("Хотите еще раз проверить найденные файлы? (y/n):");
        }
        public int ChooseRandomOrTestCollection()
        {
            string input = Console.ReadLine();
            int number;
            bool isExpectedValue = false;
            if (int.TryParse(input, out number))
            {
                if (number == 1 || number == 2)
                {
                    isExpectedValue = true;
                }
            }
            while (!isExpectedValue)
            {
                Console.Write("Неправильный ввод данный! Нужно ввести именно 1 или 2! - ");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number == 1 || number == 2)
                    {
                        isExpectedValue = true;
                    }
                }
            }
            return number;
        }
        public bool ChooseCheckingFileFound()
        {
            string input = Console.ReadLine();
            if (input == "y" || input == "yes" || input == "Y" || input == "Yes")
            {
                return true;
            }
            else return false;
        }
    }
}
