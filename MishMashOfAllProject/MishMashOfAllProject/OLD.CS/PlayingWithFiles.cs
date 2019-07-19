using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MishMashOfAllProject
{
    class PlayingWithFiles
    {

        private static FolderBrowserDialog _filemanager = new FolderBrowserDialog();
        


        public static void FileCreation()
        {
            _filemanager.ShowDialog();
            
            Console.WriteLine(_filemanager.SelectedPath);
        }

    }
}
