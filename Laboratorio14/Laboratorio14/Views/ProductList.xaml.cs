using Laboratorio14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Laboratorio14.ViewModels;


namespace Laboratorio14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ProductoService service = new ProductoService();
            lvProductos.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            ProductoService service = new ProductoService();
            lvProductos.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }


    }
}