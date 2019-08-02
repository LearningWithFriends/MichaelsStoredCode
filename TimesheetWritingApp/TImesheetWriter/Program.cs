using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CustomExcelControl;
using TImesheetWriter;
using System.IO;

namespace TimesheetWriter
{ //Looking to add templates so it remembers, being able to save and add favourites.
    // have a setup function that lets you set your directory choice or checks if you have a directory,if not it creates one
    // option to select a different date or today
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine(Directory.GetCurrentDirectory());
            //var dw = new DirectoryWriter();
            // dw.CheckDirCreateDir();
            // dw.MoveEmptyPREQ();
            // Console.ReadLine();
            //Excel excel = new Excel();
            //excel.OpenExcel(@"C:\Users\mjsh6\source\repos\MishMashOfAllProject\MishMashOfAllProject\TestingExcel\EmptyTimesheet", 1);
            //Console.WriteLine("Name?: ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Initials?: ");
            //var inits = Console.ReadLine();
            //var todayDay = Convert.ToString(DateTime.Today.Day);
            //var todayMonth = Convert.ToString(DateTime.Today.Month);
            //var todayYear = Convert.ToString(DateTime.Today.Year);
            //excel.WriteExcel(2, 2, name);
            //excel.WriteExcel(16, 2, inits);
            //excel.WriteExcel(2, 11, todayYear + "-" + todayMonth + "-" + todayDay);

            //Console.WriteLine("How many Job numbers? ");
            //int jobNum = Convert.ToInt16(Console.ReadLine());
            //bool offsite = false;
            //for (int i = 0; i < jobNum; i++)
            //{
            //    string response = "";
            //    Console.WriteLine("Job number for job " + (i + 1) + "?");
            //    string job = Console.ReadLine();
            //    Console.WriteLine("Hours for this job?");
            //    string hours = Console.ReadLine();
            //    Console.WriteLine("Where you offsite for this job?");
            //    response = Console.ReadLine();
            //    response.ToUpper();
            //    if ((response.Contains("Y")))
            //    {
            //        offsite = true;
            //    }
            //    else
            //    {
            //        offsite = false;
            //    }
            //    excel.WriteExcel((5 + i), 1, job);
            //    excel.WriteExcel((5 + i), 5, hours);
            //    if (offsite)
            //    {
            //        excel.WriteExcel((5 + i), 0, "X");
            //    }
            //}
            //excel.SaveAs(@"C:\Users\mjsh6\source\repos\MishMashOfAllProject\MishMashOfAllProject\TestingExcel\" + "TimeSheet" + todayYear + todayMonth + todayDay);
            //excel.Close();
        }
        public void favourites()
        {

        }

    }
}