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

namespace MishMashOfAllProject
{
    /// <summary>
    /// Interaction logic for dlgFirstProjectPage.xaml
    /// </summary>
    public partial class dlgFirstProjectPage : Window
    {   
        public dlgFirstProjectPage()
        {
            InitializeComponent();
           //this makes the screen go maximized // this.WindowState = WindowState.Maximized;
            
        }

        private void CloseButtonClickEvent(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
    }
}
