using System;
using System.IO;


namespace makeFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a filepath to create folders in.");
            string filePath = Console.ReadLine();
            Console.WriteLine("Please input a name for the folders to be made.");
            string fName = Console.ReadLine();
            Console.WriteLine("Please input an integer number of folders to be made.");
            int numberFolders;
            var parseSuccess = Int32.TryParse(Console.ReadLine(), out numberFolders);
            while (!parseSuccess)
            {
                Console.WriteLine("Please input an integer number of folders to be made.");
                parseSuccess = Int32.TryParse(Console.ReadLine(), out numberFolders);
            }
            while(numberFolders > 12 || numberFolders < 1)
            {
                Console.WriteLine("Please input an integer less than 12.");
                parseSuccess = Int32.TryParse(Console.ReadLine(),out numberFolders);
                while (!parseSuccess)
                {
                    Console.WriteLine("Please input an integer number of folders to be made.");
                    parseSuccess = Int32.TryParse(Console.ReadLine(), out numberFolders);
                }

            }

            void createFolders(string filePath, string fName, int numberFolders)
            {
                for(int i = 1; i<numberFolders+1; i++)
                {
                    Directory.CreateDirectory(Path.Combine(filePath, fName + i.ToString()));
                }

            }

            createFolders(filePath, fName, numberFolders);
            Console.WriteLine("Please check directory path for new directories.");
        }
    }
}
