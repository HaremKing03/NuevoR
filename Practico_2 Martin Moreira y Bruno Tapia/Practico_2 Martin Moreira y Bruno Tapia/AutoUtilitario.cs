using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class AutoUtilitario : Vehiculos
    {
        private int capacidadCarga;
     




        public AutoUtilitario(int capacidadCarga, int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro, string tipo) : base(Numero, Matricula, Marca, Color, CapacidadTanque, Estado, PrecioAlquiler, KmXLitro , tipo)
        {
            this.capacidadCarga = capacidadCarga;
          

        }

        public int getCapacidadCarga()
        {
            return (this.capacidadCarga);
        }
        public void setCapacidadCarga(int capacidadCarga)
        {
            this.capacidadCarga = capacidadCarga;
        }
        
    }
}
