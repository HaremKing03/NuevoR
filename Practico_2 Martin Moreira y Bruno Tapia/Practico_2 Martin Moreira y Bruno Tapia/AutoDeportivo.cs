using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class AutoDeportivo : Vehiculos
    {

        private int VelocidadMaxima;


        public AutoDeportivo(int VelocidadMaxima , int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro, string tipo) :base(Numero , Matricula , Marca ,Color, CapacidadTanque , Estado , PrecioAlquiler , KmXLitro , tipo) 
        {
            this.VelocidadMaxima = VelocidadMaxima;
            
        }
     
        public int getVelocidadMaxima()
        {
            return (this.VelocidadMaxima);
        }

        public void setVelocidadMaxima(int VelocidadMaxima)
        {
            this.VelocidadMaxima = VelocidadMaxima;
        }

       
    }
}
