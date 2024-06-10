using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_DelegatesAndEvents.Interfaces;

namespace HW_DelegatesAndEvents.Classes
{
    public class MyInputDataConsole: IInputData
    {
        public void InitializeInputCollectionSize()
        {
            Console.Write("Задайте количество элементов в коллекции - ");
        }
        public void InitializeInputMaxValue()
        {
            Console.Write("Задайте максимальное возможное значение для элемента в коллекции - ");
        }
        public int CheckInputCollectionSize()
        {
            return ChectInputToNaturalNumber();
        }
        public int CheckInputMaxValue()
        {
            return ChectInputToNaturalNumber();
        }
        public int ChectInputToNaturalNumber()
        {
            string input = Console.ReadLine();
            int number;
            bool isNaturalNumber = false;
            if (int.TryParse(input, out number))
            {
                if(number > 0)
                    isNaturalNumber = true;
            }
            while (!isNaturalNumber)
            {
                Console.Write("Неправильный ввод данный! Нужно ввести именно НАТУРАЛЬНОЕ ЧИСЛО! - ");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 0)
                        isNaturalNumber = true;
                }
            }
            return number;
        }
        public void InitializeInputFolderPath()
        {
            Console.WriteLine("Задайте путь папки для обработки:");
        }
        public string InputFolderPath()
        {
            return Console.ReadLine();
        }
    }
}
