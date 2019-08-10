using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CustomExcelControl;
using TImesheetWriter;
using System.IO;
using System.Threading;

namespace TimesheetWriter
{ //Looking to add templates so it remembers, being able to save and add favourites.
    // have a setup function that lets you set your directory choice or checks if you have a directory,if not it creates one
    // option to select a different date or today
    class Program
    {
        [STAThread]
        static void Main()
        {
            var us = new TImesheetWriter.Properties.Settings1();
            us.Reload();
            string path = us.FileLocation; // done
            string dateChoice;  //done
            string favChoice;   //done
            string jobNumber;   //done either us.previous job, or new job
            string firstTimeSetupName = us.Name; //done
            string name; //done
            string userIntials = ""; //done
            double hours; //done


            #region InitialGreeting
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("");
            Console.WriteLine("                 Welcome to the Proto Timesheet writer");
            Console.WriteLine("                     Created by Michael Spence-High   ");
            Console.WriteLine("");
            Console.WriteLine("**********************************************************************");
            Thread.Sleep(3000);

            if (us.FirstTimeSetupRequired)
            {
                bool _setter = false;
                Console.WriteLine("Lets go through the first time setup, please enter your Name: ");
                firstTimeSetupName = Console.ReadLine();
                Console.WriteLine("Please Select a File Location");
                Thread.Sleep(1000);
                var FBD = new System.Windows.Forms.FolderBrowserDialog();
                FBD.ShowDialog();
                us.FileLocation = FBD.SelectedPath;
                us.FirstTimeSetupRequired = _setter;
                us.Save();
            }

            Console.WriteLine("\n                     Press Enter to Continue....");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            #endregion
            //by this point we have greeted the user, first time run sets Name and Path
            #region CaseStatementForTodayYesterday

            while (true)
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("Are you looking to create a timesheet for today or yesterday?...");
                Console.WriteLine("Press Y for yesterday, T for today");
                string _todayYesterday = Console.ReadLine().ToLower();
                if (_todayYesterday != "")
                {
                    if (_todayYesterday == "y" || _todayYesterday == "t")
                    {
                        dateChoice = _todayYesterday;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Response was not 'Y' or 'T'.");
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot be empty.");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Thread.Sleep(1000);

            #endregion
            //by this point, we have greeted the user, and gotten the choice of when they would like the timesheet to be created for (yesterday or today)
            #region IsFavourite?

            while (true)
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("is this timesheet the same as last time?: " + us.PreviousJobNumber);
                Console.WriteLine("Press Y for yes, N for no");
                string _favResponse = Console.ReadLine().ToLower();
                if (_favResponse != "")
                {
                    if (_favResponse == "y" || _favResponse == "n")
                    {
                        favChoice = _favResponse;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Response was not 'Y' or 'N'." + us.PreviousJobNumber);
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot be empty." + us.PreviousJobNumber);
                    Thread.Sleep(2000);
                }
            }

            Console.Clear();
            Thread.Sleep(1000);
            #endregion
            //by this point we have greated, decided which day this sheet will be made for, and know whether to use yesterday or todays timesheet
            #region Job number, Name, Initials, hours

            //JobNumber loop
            while (true)
            {
                if (favChoice == "y")
                {
                    jobNumber = us.PreviousJobNumber;

                    break;
                }
                else
                {

                    Console.WriteLine("\n\n");
                    Console.WriteLine("What is the Job Number? : ");

                    string _jobNumber = Console.ReadLine().ToLower();
                    if (_jobNumber != "")
                    {
                        jobNumber = _jobNumber;
                        us.PreviousJobNumber = jobNumber;
                        us.Save();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot be empty.");
                        Thread.Sleep(2000);
                    }
                }
            }
            //Name and initials loop

            name = firstTimeSetupName;
            userIntials = "MSH";
            //string[] initArray = name.Split();
            //foreach (string item in initArray)
            //{
            //    userIntials += item[0].ToString();
            //}

            //hours worked loop
            while (true)
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("Total hours worked for this job?");

                string _hours = Console.ReadLine();
                if (_hours != "")
                {

                    hours = Convert.ToDouble(_hours);
                    break;

                }
                else
                {
                    Console.WriteLine("Cannot be empty.");
                    Thread.Sleep(2000);
                }
            }

            Console.Clear();
            Thread.Sleep(1000);
            #endregion
            //this will have everthing needed to write the timesheets.

            Console.WriteLine(dateChoice);
            Console.WriteLine(jobNumber);
            Console.WriteLine(name);
            Console.WriteLine(userIntials);
            Console.WriteLine(hours);
            Console.WriteLine(path);
            Console.ReadLine();





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
    }
}