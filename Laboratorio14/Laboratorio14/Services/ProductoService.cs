using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;
using Laboratorio14.Models;
using Laboratorio14.DataContext;

namespace Laboratorio14.Services
{
    public class ProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService() => _context = App.GetContext();
                                 

        public bool Create(Producto item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Productos.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Producto> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Productos.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Producto> Get()
        {
            return _context.Productos.ToList();
        }


        public List<Producto> GetByText(string text)
        {
            return _context.Productos.Where(x => x.Name.Contains(text)).ToList();
        }



    }
}

