using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndroidMovies.Models;
using AndroidMovies.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidMovies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }
    }
}