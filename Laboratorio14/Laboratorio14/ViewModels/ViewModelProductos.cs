using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using System.Collections.ObjectModel;

using Xamarin.Forms;
using Laboratorio14.Models;
using Laboratorio14.Services;

namespace Laboratorio14.ViewModels
{
    public  class ViewModelProductos : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Producto> productos;
        public List<Producto> Productos
        {
            get { return this.productos; }
            set { SetValue(ref this.productos, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelProductos()
        {

            SearchCommand = new Command(() =>
            {
                ProductoService service = new ProductoService();
                Productos = service.GetByText(Filter);
                if (Productos.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";
            });


        }

    }
}

