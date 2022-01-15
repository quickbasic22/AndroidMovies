using AndroidMovies.Models;
using AndroidMovies.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidMovies
{
    public partial class App : Application
    {
        public App(IProductsRepository productsRepository)
        {
            InitializeComponent();

            MainPage = new ProductsPage()
            {
                BindingContext = new ProductsViewModel(productsRepository),
            };
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
    }
}
