﻿using System;
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
using System.Threading;
using MishMashOfAllProject;
using System.Configuration;
using System.IO;


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
            /*navigate to a location, create a file
             * 
             */
            // Add logic here to use 
            //Async and AWAIT
            //LINQ and Lambda and XML
            // Delegates and Events
            //Exceptions (Try/Catch/Finally/Throw)
            //Generics
            // how to add new settings values during runtime 

            LearningSomeNewShitClass ls = new LearningSomeNewShitClass();
            ls.PlayingWithLLists();

        }

    }
}






