using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_taller_clase
{
    class Articulo
    {

        //atributos de la clase  articulo.
        private double precio_unitario;
        private double descuento;
        private int cantidad;
        private string descripcion;
        private string id;

        public Articulo(string id, string descripcion,int cantidad, double precio)
        {
            this.id = id;
            this.descripcion = descripcion;

            if (cantidad >= 0)
            {
                this.cantidad = cantidad;
            }
            else
            {
                this.cantidad = 0;
            }

            this.precio_unitario = precio;
        }

        public double getTotalAjustado()
        {

            double total = precio_unitario * cantidad;
            double descuento_total = total * descuento;
            double total_ajustado = total - descuento;

            return total_ajustado;
                
         }

        public void setDescuento(double descuento) {

            if(descuento <= 1.00)
            {
                this.descuento = descuento;
            }
            else
            {
                this.descuento = 0.0;
            }
        }

        public double getDescuento(){
            return descuento;
        }

        public int getCantidad(){
            return cantidad;
        }

        public void setCantidad(int cantidad){
            if (cantidad >= 0){
                this.cantidad = cantidad;
            }
        }

        public string getIdProducto(){

            return id;
        }

        public string getDescripcion(){
            return descripcion;
        }

    }
}
