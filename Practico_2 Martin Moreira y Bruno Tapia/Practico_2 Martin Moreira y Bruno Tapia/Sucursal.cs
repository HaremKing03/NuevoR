using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    internal class Sucursal
    {

        private int numero;
        private string direccion;
        private List<Vehiculos>colVehiculos;


        public Sucursal(int numero, string direccion)
        {
            this.numero = numero;
            this.direccion = direccion;
            this.colVehiculos = new List<Vehiculos>();   
        }
        public Sucursal()
        {

        }

        public void agregarvehiculoFamiliar(int capacidadMaletero, int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro) 
        {
            AutoFamiliar nuevoAutoFamiliar = new AutoFamiliar(capacidadMaletero, Numero, Matricula, Marca, Color, CapacidadTanque, Estado, PrecioAlquiler, KmXLitro,"Auto Familiar");
            colVehiculos.Add(nuevoAutoFamiliar);

        }
        public void agregarvehiculoUtilitario(int capacidadCarga, int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro)
        {
            AutoUtilitario nuevoAutoUtilitario = new AutoUtilitario(capacidadCarga,  Numero, Matricula, Marca,  Color,  CapacidadTanque, Estado,  PrecioAlquiler,KmXLitro,"Auto Utilitario");
            colVehiculos.Add(nuevoAutoUtilitario);
        }
        public void agregarvehiculoDeportivo(int VelocidadMaxima, int Numero, string Matricula, string Marca, string Color, float CapacidadTanque, string Estado, int PrecioAlquiler, float KmXLitro)
        {
           AutoDeportivo nuevoAutoDeportivo = new AutoDeportivo(VelocidadMaxima, Numero, Matricula, Marca, Color, CapacidadTanque, Estado, PrecioAlquiler, KmXLitro, "Auto Deportivo");
            colVehiculos.Add(nuevoAutoDeportivo);
        }
           

        public int getnumero()
        {
            return (this.numero);
        }
        public void setnumero(int numero)
        {
            this.numero = numero;
        }
        public string getDireccion()
        {
            return (this.direccion);
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public List<Vehiculos> getVehiculos() => this.colVehiculos;

        public void setVehiculos(List<Vehiculos> colVehiculos) =>this.colVehiculos = colVehiculos;  

      
        
     
    }
}
