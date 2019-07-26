using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MealMaker;


namespace DinnerPlanningApp
{
    /// <summary>
    /// Auto-Fill for the text box
    /// Auto POP for the shopping list
    /// figure out a good tab setup (Add a new meal tab)
    /// have monday to sunday with meal titles and total guests (this will multiply the shopping)
    /// add decorations for the screens and colors
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        bool mealCleared;
        bool ingCleared;
        public NewMealMaker mealMaker = new NewMealMaker();
        // this is the form load, no changes made
        public MainWindow()
        {
            InitializeComponent();

            mealCleared = false;
            ingCleared = false;

        }


        // this is all the misc stuff on the page, can be ignored.
        #region Setup


        private void MealName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IngrediantTBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {//On "New Meal" button click, pull information and create a meal. also checks that the user has changed the information in the boxes and that it isnt the default message

            if (MealName.Text == "Enter New Meal Title..." || IngrediantTBox.Text == "Enter Ingrediants then '/' then Department ex. (Flour/Grocery), Separate them with a comma ex.(Flour/Grocery, Bread/Bakery)")
            {
                System.Windows.MessageBox.Show("Please Enter Meal Name and Ingredients");
            }
            else
            {
                mealMaker.NewMealCreater(MealName, IngrediantTBox);

                MealName.Clear();
                IngrediantTBox.Clear();
            }

        }


        // this is the beginning of the new meal logic

        #endregion
        #region ButtonClearingLogic
        private void MealName_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if ((e.XButton1 == Mouse.MiddleButton) && !mealCleared)
            {

                MealName.Clear();
                mealCleared = true;
            }
        }

        private void IngrediantTBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if ((e.XButton1 == Mouse.MiddleButton) && !ingCleared)
            {

                IngrediantTBox.Clear();
                ingCleared = true;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MealIngredientManager ml = new MealIngredientManager();
            //ml.IngredientReader();
            ml.IngredientSaver();
        }

       

        #endregion

        //this needs to take the values from these two text boxes and store them in variables. then it needs to take the values of these variables and store them in some coherent way that will remain persistant.
    }
}
namespace MealMaker { 
    public class NewMealMaker : DinnerPlanningApp.IMeal
    {
        public void NewMealCreater(System.Windows.Controls.TextBox title, System.Windows.Controls.TextBox ingredients)
        {
            // this is for debugging
            Console.WriteLine(@"The meal name is {0}, and the ingredients are: {1}", title.Text, ingredients.Text);
        }
    }
}