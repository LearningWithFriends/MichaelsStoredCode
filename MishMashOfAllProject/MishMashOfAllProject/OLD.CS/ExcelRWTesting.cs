using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace MishMashOfAllProject
{
    /*  Name goes in 3,C
     *  Initials go in 17,C
     *  date goes in 3,L
     *  Job# goes in 6,B
     *  offsite goes in 6,A
     *  hours go in 6,F
     *  path for empty timesheet is C:\Users\mjsh6\source\repos\MishMashOfAllProject\MishMashOfAllProject\TestingExcel\EmptyTimesheet
     */

    public class Excel
    {
        /* creates a new excel application called excel
         * creates a null workbook called wb
         * creates a null worksheet called ws
         * creates an empty string called path
         */
        Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        string path = "";
       

        public void OpenExcel(string path, int sheet)
        {
            /* this will take inputs of path and sheet. Sets the classes path equal to the input path
             * sets wb equal to the work book located at path
             * and sets the worksheet equal to the opened workbooks worksheet with the sheet number equal to the input sheets
             */
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }
        public void CreateNewFile()
        {   /* creates a workbook with a template. I think that because on execution this.wb is null, it creates a new file
            */ 
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }
        public void CreateNewWorksheet()
        {   /* Adds a WorkSheet to whatever wb is open
            */
            wb.Worksheets.Add(After: ws);
        }
        public string ReadExcel(int row, int column)
        {
            /* Since excel starts at 1,1. i start with an increment to ensure we're in the correct spot
             * I read the row/column value and return it
             */
            row++;
            column++;
            return ws.Cells[row, column].value;
        }
        public void WriteExcel(int row, int column, string s)
        { /* sets the rows and columns, and takes value s and sets it to that row and column
            */
            row++;
            column++;
            ws.Cells[row, column].value = s;
        }
        public void Save()
        { /* Saves the document
            */
            wb.Save();
        }
        public void SaveAs(string title)
        {
            /* Saves the document in the new path as a new file
             */
            wb.SaveAs(title);
        }
        public void Close()
        {   /* Closes the opened document 
            */
            wb.Close();
          
        }
       
    }
}
