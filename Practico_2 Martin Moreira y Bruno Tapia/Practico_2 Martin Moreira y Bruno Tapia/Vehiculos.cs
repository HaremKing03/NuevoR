using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class Vehiculos
    {

        private int Numero;
        private string Matricula;
        private string Marca;
        private string Color;
        private float CapacidadTanque;
        private string Estado;
        private int PrecioAlquiler;
        private float KmXLitro;
        private string tipo;

        public Vehiculos(int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro, string tipo)
        {
            this.Numero = Numero;
            this.Matricula = Matricula;
            this.Marca = Marca;
            this.Color = Color;
            this.CapacidadTanque = CapacidadTanque;
            this.Estado = Estado;
            this.PrecioAlquiler = PrecioAlquiler;
            this.KmXLitro = KmXLitro;
            this.tipo = tipo;
        }
        public Vehiculos()
        {

        }
        public int getNumero()
        {
            return (this.Numero);
        }

        public string getMatricula()
        {
            return (this.Matricula);
        }

        public string getMarca()
        {
            return (this.Marca);

        }

        public string getColor()
        {
            return (this.Color);
        }

        public float getCapacidadTanque()
        {
            return (this.CapacidadTanque);
        }

        public string getEstado()
        {
            return (this.Estado);
        }

        public int getPrecioAquiler()
        {
            return (this.PrecioAlquiler);
        }


        public float getKmXLitro()
        {
            return (this.KmXLitro);
        }

        public void setNumero(int Numero)
        {
            this.Numero = Numero;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public void setMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }

        public void setColor(string Color)
        {
            this.Color = Color;
        }

        public void setCapacidadTanque(float CapacidadTanque)
        {
            this.CapacidadTanque = CapacidadTanque;

        }


        public void setEstado(string Estado)
        {
            this.Estado = Estado;

        }

        public void setPrecioAlquiler(int PrecioAlquiler)
        {
            this.PrecioAlquiler = PrecioAlquiler;

        }
        public void setkmXLitro(float KmXLitro)
        {
            this.KmXLitro = KmXLitro;
        }

        public string getTipo()
        {
            return (this.tipo);
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void mostrarVehiculos()
        {

            Console.WriteLine("Tipo: " + this.tipo);
            Console.WriteLine("IDENTIFICADOR: " + this.Numero);
            Console.WriteLine("MARCA: " + this.Marca);
            Console.WriteLine("MATRICULA: " + this.Matricula);
            Console.WriteLine("COLOR: " + this.Color);
            Console.WriteLine("CAPACIDAD DEL TANQUE: " + this.CapacidadTanque);
            Console.WriteLine("ESTADO: " + this.Estado);
            Console.WriteLine("PRECIO:" + this.PrecioAlquiler);
            Console.WriteLine("KILOMETROS POR LITRO: " + this.KmXLitro);
            Console.WriteLine("\n");



        }
    }
}
