using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    internal class Alquiler
    {
        private int numeroAlquiler;
        private int precioTotal;
        private string documento;
        private string telefono;
        private string nombre;
        private string apellido;
        private List<Vehiculos> colVehiculos;
        private Detalle objDetalle;
        public Alquiler(int numeroAlquiler, int precioTotal, string documento, string telefono, string nombre, string apellido, List<Vehiculos> colVehiculos, Detalle objDetalle)
        {
            this.numeroAlquiler = numeroAlquiler;
            this.precioTotal = precioTotal;
            this.documento = documento;
            this.telefono = telefono;
            this.nombre = nombre;
            this.apellido = apellido;
            this.objDetalle = objDetalle;
            this.colVehiculos = colVehiculos;

        }

        public Alquiler()
        {

        }

        public void agregarMasVheiculos( Vehiculos objVehiculo)
        {
            this.colVehiculos.Add(objVehiculo);
        }
     
        public int getNumeroAlquiler()
        {
            return (this.numeroAlquiler);
        }
        public void setNumeroAlquiler(int numeroAlquiler)
        {
            this.numeroAlquiler = numeroAlquiler;
        }
        public int getprecioTotal()
        {
            return (this.precioTotal);
        }
        public void setPrecioTotal(int precioTotal)
        {
            this.precioTotal = precioTotal;
        }
        public string getDocumento()
        {
            return (this.documento);
        }
        public void setDocumento(string documento)
        {
            this.documento = documento;
        }
        public string getTelefono()
        {
            return (this.telefono);
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public string getNombre()
        {
            return (this.nombre);
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return (this.apellido);
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public Detalle getDetalle() { return this.objDetalle; }
        public void setDetalle(Detalle objDetalle) { this.objDetalle = objDetalle; }

        public List<Vehiculos> getVehiculos() => this.colVehiculos;

        public void setVehiculos(List<Vehiculos> colVehiculos) => this.colVehiculos = colVehiculos;


        public void mostarAlquiler()
        {
            Console.WriteLine("NUMERO ALQUILER :"+this.numeroAlquiler);
            Console.WriteLine("Precio Total: "+this.precioTotal) ;
            Console.WriteLine("DOCUMENTO: "+this.documento) ;
            Console.WriteLine("Telefono"+this.telefono) ;
            Console.WriteLine("NOMBRE: "+this.nombre);
            Console.WriteLine("APELLIDO: "+this.apellido) ;
            this.objDetalle.mostarDetalle();
            
        }


    }
}
