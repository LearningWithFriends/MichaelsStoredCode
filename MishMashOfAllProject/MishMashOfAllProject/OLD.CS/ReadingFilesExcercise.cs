using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MishMashOfAllProject
{
    /*
     * This was stuff created to make a directory (Folder), and create 2 text files in it.
     * 
     * var path = @"C:\Users\mjsh6\source\repos\MishMashOfAllProject\TestingDirectory";
            Directory.CreateDirectory(path);
            File.Create(path + "\\ThisIsaTestFile.txt");
            File.Create(path + "\\SecondFileForCreation.txt");

        This is the logic that I used to call these two routines in a CMD window. These are the exercised from Udemy course C# Beginners Files and Directories.
     * 
     * 
     * 
      Console.WriteLine("There are " + ReadingFilesExcercise.FileWordCount(@"C:\Users\mjsh6\source\repos\MishMashOfAllProject\TestFiles\ReadingTextFileTesting.txt") + " words in this file");

       Console.WriteLine("The longest word is: " + ReadingFilesExcercise.FileLongestWord(@"C:\Users\mjsh6\source\repos\MishMashOfAllProject\TestFiles\ReadingTextFileTesting.txt"));
     * 
     */
    class ReadingFilesExcercise
    {
        public static int FileWordCount(string path)
        {
            int wordCount = 0;

            if (File.Exists(path))
            {
                var words = File.ReadAllText(path);
                var wordsArray = words.Split();
                wordCount = wordsArray.Count();

            }else
            {
                Console.WriteLine("This file does not exist");
            }
            

            return wordCount;
        }
        public static string FileLongestWord(string path)
        {
            var longestWord = "";

            if (File.Exists(path))
            {
                var words = File.ReadAllText(path);
                var wordsArray = words.Split();
                var i = 0;
                foreach (var word in wordsArray)
                {
                    if (wordsArray[i].Length > longestWord.Length)
                    {
                        longestWord = wordsArray[i];
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("This file does not exist");
            }

            return longestWord;
        }
        
    }
}
