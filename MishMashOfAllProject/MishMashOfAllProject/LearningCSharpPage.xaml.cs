using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;


namespace MishMashOfAllProject
{
    /// <summary>
    /// Interaction logic for LearningCSharpPage.xaml
    /// </summary>
    public partial class LearningCSharpPage : Window
    {
        public LearningCSharpPage()
        {
            #region Don't Change This

            InitializeComponent();
            this.WindowState = WindowState.Minimized;
            #endregion
            // Add logic here to use 
            var b = new books();
            b.author = "harry dickens";



        }
        public struct books
        {
            public int edition;
            public string name;
            public string author;

        }

    }

    public class Stuffs : IMyInterfaceLearning, IWriter
    {
        public void TextWriter(string s)
        {
            Console.WriteLine(s);
        }
        public string TextReader(string s)
        {
            string m = Console.ReadLine();
            return m;
        }
        public void Stuff() { return; }
        public void CWWriter(string s)
        {
            Console.WriteLine(s);
        }


    }
}

