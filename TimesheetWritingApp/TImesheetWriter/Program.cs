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
//IT WORKS !!!!!!!!!!!!!!!

namespace TimesheetWriter
{
    
    /// <TODO>
    /// option for multiple jobs, store these in favourites 
    ///add some logic that stores the empty timesheet in the folder selected and then uses it for the future. after which it removes the option to run the init start up unless a key sequence is used to restart it have it instead just look at current directory for the code
    /// for the multiple job number, add them to the string with a separator, split them before writing
    /// </TODO>


    class Program
    {
        [STAThread]
        static void Main()
        {
            Excel excel = new Excel();

            var us = new TImesheetWriter.Properties.Settings1();
            string path = us.FileLocation; // done
            string dateChoice;  //done
            string favChoice;   //done
            string jobNumber;   //done either us.previous job, or new job
            string firstTimeSetupName = us.Name; //done
            string name;
            string userInitials = ""; //done
            double hours; //done
            string day;
            string month = Convert.ToString(DateTime.Today.Month);
            string year = Convert.ToString(DateTime.Today.Year);
            bool offsite = us.Offsite;
            #region InitialGreeting
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("");
            Console.WriteLine("                 Welcome to the Proto Timesheet writer");
            Console.WriteLine("                     Created by Michael Spence-High   ");
            Console.WriteLine("                        Press Y to run start up                       ");
            Console.WriteLine("**********************************************************************");
            Thread.Sleep(1000);

            Console.WriteLine("\n would you like to run the First time start again? Y/N ");
            string settup = Console.ReadLine().ToUpper();
            if (settup == "Y")
            {
                us.FirstTimeSetupRequired = true;
                us.Save();
            }

            if (us.FirstTimeSetupRequired == true)
            {
                bool _setter = false;
                Console.WriteLine("Lets go through the first time setup, please enter your Name: ");
                us.Name = Console.ReadLine();
                Console.WriteLine("Please Select a File Location");
                Thread.Sleep(1000);
                var FBD = new System.Windows.Forms.FolderBrowserDialog();
                FBD.ShowDialog();
                us.FileLocation = FBD.SelectedPath;
                path = us.FileLocation;
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
                Console.WriteLine("Are you looking to create a timesheet for today, yesterday, or other?...");
                Console.WriteLine("Press Y for yesterday, T for today, O for other");
                string _todayYesterday = Console.ReadLine().ToLower();
                if (_todayYesterday != "")
                {
                    if (_todayYesterday == "y" || _todayYesterday == "t" || _todayYesterday == "o")
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
            if (dateChoice == "y")
            {
                day = Convert.ToString(DateTime.Today.AddDays(-1).Day);
            }
            else if (dateChoice == "t")
            {
                day = Convert.ToString(DateTime.Today.Day);
            }
            else
            {
                Console.WriteLine("this isnt implemented yet, using today");
                day = Convert.ToString(DateTime.Today.Day);
            }
            Console.Clear();
            Thread.Sleep(1000);

            #endregion
            //by this point, we have greeted the user, and gotten the choice of when they would like the timesheet to be created for (yesterday or today)
            #region IsFavourite?

            while (true)
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("is this timesheet the same as last time?: " + us.PreviousJobNumbers + "\noffsite?: " + us.Offsite);
                Console.WriteLine("\nPress Y for yes, N for no");
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
                        Console.WriteLine("Response was not 'Y' or 'N'." + us.PreviousJobNumbers);
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot be empty." + us.PreviousJobNumbers);
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
                    jobNumber = us.PreviousJobNumbers;

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
                        us.PreviousJobNumbers = jobNumber;
                        us.Save();
                        while (true)
                        {

                            Console.WriteLine("\n\n");
                            Console.WriteLine("Were you offsite? Y/N : ");

                            string _offsResp = Console.ReadLine().ToLower();
                            if (_offsResp == "y")
                            {
                                us.Offsite = true;
                                offsite = us.Offsite;
                                us.Save();
                                break;
                            }
                            else
                            {
                                us.Offsite = false;
                                offsite = us.Offsite;
                                us.Save();
                                break;
                            }
                        }
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
            #region Initial Generation

            name = us.Name;
            string[] nameSplit = name.Split(new char[] { ' ', '-' });

            foreach (var n in nameSplit)
            {
                userInitials += n[0];
            }
            userInitials.ToUpper();

            #endregion
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



            excel.OpenExcel(@"Z:\Git Repos\TimesheetWritingApp\TImesheetWriter\bin\Debug\EmptyTimesheet", 1);
            excel.WriteExcel(2, 2, name);
            excel.WriteExcel(16, 2, userInitials);
            excel.WriteExcel(2, 11, year + "-" + month + "-" + day);
            //eventually a for loop here for multiple jobs
            if (offsite)
            {
                excel.WriteExcel((5), 0, "X");
            }
            excel.WriteExcel((5), 1, jobNumber.ToUpper());
            excel.WriteExcel((5), 5, Convert.ToString(hours));
            excel.SaveAs(path + "\\" + userInitials + "TimeSheet" + year + month + day);
            excel.Close();
            Console.WriteLine("END");
            Console.ReadLine();

        }
    }
}