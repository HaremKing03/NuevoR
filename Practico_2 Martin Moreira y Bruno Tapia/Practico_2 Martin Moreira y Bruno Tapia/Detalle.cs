using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class Detalle
    {

        private DateTime fechaRetiro;
        private int cantidadDeDias;
        private Vehiculos objVehiculos;


        public Detalle(DateTime fechaRetiro, int cantidadDeDias,Vehiculos objVehiculos)
        {
            this.fechaRetiro = fechaRetiro;
            this.cantidadDeDias = cantidadDeDias;
            this.objVehiculos = objVehiculos;
        }
        public Detalle()
        {

        }
        public DateTime getFechaRetiro()
        {
            return (this.fechaRetiro);
        }
        public void setnumero(DateTime fechaRetiro)
        {
            this.fechaRetiro = fechaRetiro;
        }
        public int getCantidadDeDias()
        {
            return (this.cantidadDeDias);
        }
        public void setDireccion(int cantidadDeDias)
        {
            this.cantidadDeDias = cantidadDeDias;
        }
        public Vehiculos getVehiculos() { return this.objVehiculos; }
        public void setVehiculos(Vehiculos objVehiculos) { this.objVehiculos = objVehiculos; }


        public void mostarDetalle()
        {
            Console.WriteLine("FECHA DE RETIRO: "+this.fechaRetiro);
            Console.WriteLine("CANTIDAD DE DIAS: "+this.cantidadDeDias);
        }
    }
}
