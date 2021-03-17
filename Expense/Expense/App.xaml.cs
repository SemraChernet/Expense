using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expense
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BudgetEntry();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal class budgetFilename
        {
        }
    }
}
