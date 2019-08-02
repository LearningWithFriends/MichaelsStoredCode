using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TImesheetWriter
{
    class DirectoryWriter
    {
        bool directoryCreated = false;
        /* create directory, move empty PREQ, Store path.
         */
        public void CheckDirCreateDir()
        {
            if (!Directory.Exists(@"C:\Timesheets"))
            {

                Directory.CreateDirectory(@"C:\Timesheets");
                directoryCreated = true;
            }
            else
            {
                directoryCreated = false;
            }

        }
        private string path = "";
        public void MoveEmptyTimesheet()
        {
            this.path = Directory.GetCurrentDirectory();

            if (directoryCreated)
            {
                File.Copy(path + "\\EmptyTimesheet", @"C:\Timesheets\");
            }
        }
    }
}
