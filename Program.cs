using System;
using System.Collections.Generic;
using System.IO;
using HW_DelegatesAndEvents.Classes;
using HW_DelegatesAndEvents.Interfaces;

namespace HW_DelegatesAndEvents
{
    class Program
    {
        static void Main()
        {
            IInputData inputter = new MyInputDataConsole();
            IOutputInfo<MySomeCollectionItem> outputter = new MyOutputInfoConsole();
            IUserInterface userInterface = new MyUserInterfaceConsole();
            ICollectionProvider<MySomeCollectionItem> collectionProvider;
            IEnumerable<MySomeCollectionItem> mySomeCollection;

            IFileProcessor fileProcessor = new FileProcessor();
            fileProcessor.FileFound += FileProcessor_FileFound;

            inputter.InitializeInputFolderPath();
            string folderPath = inputter.InputFolderPath();
            userInterface.InitalizeChoiseCollectionType();
            int choiseCollectionType = userInterface.ChooseRandomOrTestCollection();
            switch (choiseCollectionType)
            {
                case 1:
                    collectionProvider = new TestGenerateCollection();
                    mySomeCollection = collectionProvider.GetCollection();
                    break;
                case 2:
                    inputter.InitializeInputCollectionSize();
                    int size = inputter.CheckInputCollectionSize();
                    inputter.InitializeInputMaxValue();
                    int maxValue = inputter.CheckInputMaxValue();
                    collectionProvider = new RandomGenerateCollection(size, maxValue);
                    mySomeCollection = collectionProvider.GetCollection();
                    break;
                default: 
                    mySomeCollection = new List<MySomeCollectionItem>(); 
                    break;
            }
            outputter.OutputCollection(mySomeCollection);
            var maxNumber = mySomeCollection.GetMax(x => x.MyValue);
            outputter.OutputMaxItem(maxNumber);

            fileProcessor.ProcessFiles(folderPath, outputter);
            userInterface.InitalizeChoiseCheckingFileFound();
            bool choiseIsCheckAgain = userInterface.ChooseCheckingFileFound();
            while (choiseIsCheckAgain)
            {
                fileProcessor.ProcessFiles(folderPath, outputter);
                userInterface.InitalizeChoiseCheckingFileFound();
                choiseIsCheckAgain = userInterface.ChooseCheckingFileFound();
            }
        }

        private static void FileProcessor_FileFound(object sender, FileArgs e)
        {
            e.Outputter.OutputFoundFiles(e.FileName);
            // Добавляем возможность отмены дальнейшего поиска из обработчика
            if (e.FileName.Contains("stop.txt"))
            {
                e.Outputter.OutputSearchStopped();
                Environment.Exit(0);
            }
        }
    }
}
