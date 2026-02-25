using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas
{
    internal class Venta
    {

        private Producto producto;
        private int cantidad;

        public Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public decimal TotalaPagar()
        {

            return producto.Precio * cantidad;
        }

        public bool Procesar()
        {

            producto.Cantidad += cantidad;
            return true;
        }

        
        //prueba
        public void ActualizarCantidad()
        {
            producto.Cantidad -= cantidad;
        }
        
    }
}
