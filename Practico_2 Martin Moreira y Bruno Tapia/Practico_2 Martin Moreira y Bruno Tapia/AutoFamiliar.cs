using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class AutoFamiliar : Vehiculos
    {
        private int capacidadMaletero;
    



        public AutoFamiliar(int capacidadMaletero, int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro , string tipo) : base(Numero, Matricula, Marca, Color, CapacidadTanque, Estado, PrecioAlquiler, KmXLitro,  tipo)
        {
            this.capacidadMaletero = capacidadMaletero;
           
        }

        public int getCapacidadMaletero()
        {
            return (this.capacidadMaletero);
        }
        public void setCapacidadMaletero(int capacidadMaletero)
        {
            this.capacidadMaletero = capacidadMaletero;
        }

        
    }
}
