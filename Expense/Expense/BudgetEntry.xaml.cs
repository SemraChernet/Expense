using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expense
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BudgetEntry : ContentPage

    {
        string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Expense.txt");
        public BudgetEntry()

        {
            InitializeComponent();
        }


        ////Go to Expense Entry page once budget is saved.
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {


        }

        //Make budget blank when user deletes budget
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {

           
        }

    } 
}