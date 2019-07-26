using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.IO;
using System.Xml;



namespace DinnerPlanningApp
{
    class MealIngredientManager
    {
        private string _xmlPath = @"Z:\Git Repos\DinnerPlanningApp\DinnerPlanningApp\myXML.xml";
        private string _folderPath;
        private string _filePath;
        void FileSetting()
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.ShowDialog();
            string fileLocation = fld.SelectedPath;
            _folderPath = fileLocation;
            _filePath = _folderPath + @"\Meals.txt";
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();

            }

        }
        private string _variable = "Pizza";
        public void IngredientReader()
        {//System.Windows.Controls.TextBox title, System.Windows.Controls.TextBox ingredients
         // FileSetting();
         //Z:\Git Repos\DinnerPlanningApp\DinnerPlanningApp\myXML.xml
        
            XmlTextReader reader = new XmlTextReader(@"Z:\Git Repos\DinnerPlanningApp\DinnerPlanningApp\myXML.xml"); ;

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Element && reader.Name == _variable)
                {
                    Console.WriteLine(reader.Name);
                    Console.WriteLine(reader.ReadInnerXml());
                    Console.WriteLine(reader.Value);
                }
            }
        }
        public void IngredientSaver()
        {

        }

    }
}
