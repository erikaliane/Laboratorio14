using Laboratorio14.Models;
using Laboratorio14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductInsert : ContentPage
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ProductoService service = new ProductoService();
            List<Producto> people = new List<Producto>();

            for (int i = 0; i < 3; i++)
                people.Add(new Producto { Name = txtName.Text, Description = txtDescription.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(people);


        }

       
    }
}