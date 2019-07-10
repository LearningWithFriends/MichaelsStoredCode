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
using System.IO;

namespace MishMashOfAllProject
{
    #region MainWindow+PageNav


    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
            
        }

        private void GoToFirstProjectPage(object sender, RoutedEventArgs e)
        {
            dlgFirstProjectPage fpp = new dlgFirstProjectPage();
            fpp.ShowDialog();
        }
        private void GoToTestPage( object sender, RoutedEventArgs e)
        {
            LearningCSharpPage lcs = new LearningCSharpPage();
            lcs.Show();
            //the line below is in place so that the program acts like a CMD program
            this.WindowState = WindowState.Minimized;
        }
    }
    #endregion

    class moreStuff : IMyInterfaceLearning
    {
        public void TextWriter(string s)
        {
            var c = s.ToCharArray();
            foreach (var ch in c)
            {
                Console.WriteLine(ch);
            }
        }

        public string TextReader(string s)
        {
            return "string";
        }
    }
}
