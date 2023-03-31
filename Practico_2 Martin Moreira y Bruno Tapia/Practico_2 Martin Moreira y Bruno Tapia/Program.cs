using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Martin_Moreira_y_Bruno_Tapia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculos> listaVehiculos = new List<Vehiculos>();
            List<Alquiler> listaAlquiler = new List<Alquiler>();
            Sucursal Nuevasucursal = new Sucursal(123, "Wilson Ferreira Aldunate");
            int opciones;
            int opciones2;
            int opciones3;
            int opciones4;
            do
            {
                Console.WriteLine("MALDONADO VEHICULOS");
                Console.WriteLine("********* *********");
                Console.WriteLine("");
                Console.WriteLine("1-Realizar Alquileres");
                Console.WriteLine("2-Agregar Vehiculo");
                Console.WriteLine("3-Ver Vehiculos");
                Console.WriteLine("\n");
                Console.WriteLine("Selecione una opcion");
                Console.WriteLine("********* *** ******");
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1-Agregar Alquiler");
                        Console.WriteLine("2-Ingresar otro Vehiculo a un Alquiler");
                        Console.WriteLine("3-Ver Todos Alquileres");
                        opciones4 = int.Parse(Console.ReadLine());
                        switch (opciones4)
                        {
                            case 1:
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Familiar" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                    if (listaVehiculos[i].getTipo() == "Auto Utilitario" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                    if (listaVehiculos[i].getTipo() == "Auto Deportivo" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                int precioTotal;
                                Console.WriteLine("INGRESE EL IDENTIFICADOR DEL VEHICULO");
                                int numeroVheiculo = int.Parse(Console.ReadLine());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (numeroVheiculo == listaVehiculos[i].getNumero())
                                    {
                                        Console.WriteLine("INGRESE IDENTIFICADOR ALQUILER");
                                        int numeroAlquiler = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Console.WriteLine("PRECIO TOTAL");
                                        precioTotal = listaVehiculos[i].getPrecioAquiler();
                                        Console.WriteLine("PRECIO TOTAL" + precioTotal);
                                        Console.Clear();
                                        Console.WriteLine("INGRESE DOCUMENTO");
                                        string documento = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("INGRESE TELEFONO");
                                        string telefono = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("INGRESE NOMBRE");
                                        string nombre = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("INGRESE APELLIDO");
                                        string apellido = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("INGRESE FECHA DE RETIRO");
                                        string fecha = Console.ReadLine();
                                        Console.Clear();
                                        DateTime fechaRetiro = Convert.ToDateTime(fecha);
                                        Console.WriteLine("INGRESE CANTIDAD DE DIAS");
                                        int CantDias = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Vehiculos nuevoVehiculos = new Vehiculos(listaVehiculos[i].getNumero(), listaVehiculos[i].getMatricula(), listaVehiculos[i].getMarca(), listaVehiculos[i].getColor(), listaVehiculos[i].getCapacidadTanque(), listaVehiculos[i].getEstado(), listaVehiculos[i].getPrecioAquiler(), listaVehiculos[i].getKmXLitro(), listaVehiculos[i].getTipo());
                                        Detalle nuevoDetalle = new Detalle(fechaRetiro, CantDias, nuevoVehiculos);
                                        List<Vehiculos> listaVehiculosAlquiler = new List<Vehiculos>();
                                        listaVehiculosAlquiler.Add(nuevoVehiculos);
                                        Alquiler NuevoAlquiler = new Alquiler(numeroAlquiler, precioTotal, documento, telefono, nombre, apellido, listaVehiculosAlquiler, nuevoDetalle);
                                        listaAlquiler.Add(NuevoAlquiler);
                                        listaVehiculos[i].setEstado("No Disponible");
                                        Nuevasucursal.setVehiculos(listaVehiculos);
                                        Console.Clear();
                                        Console.WriteLine("Agregado Correctamente");
                                        Console.WriteLine("");
                                        NuevoAlquiler.mostarAlquiler();

                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine("******************* Lista de Vehiculos Disponibles ******************");
                                Console.WriteLine("");
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Familiar" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                    if (listaVehiculos[i].getTipo() == "Auto Utilitario" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                    if (listaVehiculos[i].getTipo() == "Auto Deportivo" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("******************* Identificadores de Alquileres ******************");
                                Console.WriteLine("");
                                for (int i = 0; i < listaAlquiler.Count; i++)
                                {
                                    Console.WriteLine("Identificador Alquiler: " + listaAlquiler[i].getNumeroAlquiler());
                                }
                                Console.WriteLine("INGRESAR IDENTIFICADOR ALQUILER");
                                int numeroAlquiler2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("INGRESAR IDENTIFICADOR VEHICULO");
                                int numeroVehiculo2 = int.Parse(Console.ReadLine());
                                for (int i = 0; i < listaAlquiler.Count; i++)
                                {
                                    listaVehiculos = (Nuevasucursal.getVehiculos());
                                    for (int b = 0; b < listaVehiculos.Count; b++)
                                    {
                                        if (numeroAlquiler2 == listaAlquiler[i].getNumeroAlquiler())
                                        {

                                            if (numeroVehiculo2 == listaVehiculos[b].getNumero())
                                            {
                                                int total;
                                                Vehiculos nuevoVehiculos = new Vehiculos(listaVehiculos[b].getNumero(), listaVehiculos[b].getMatricula(), listaVehiculos[b].getMarca(), listaVehiculos[b].getColor(), listaVehiculos[b].getCapacidadTanque(), listaVehiculos[b].getEstado(), listaVehiculos[b].getPrecioAquiler(), listaVehiculos[b].getKmXLitro(), listaVehiculos[b].getTipo());
                                                total = (listaAlquiler[i].getprecioTotal() + listaVehiculos[b].getPrecioAquiler());
                                                listaVehiculos[b].setEstado("No Disponible");
                                                listaAlquiler[i].setPrecioTotal(total);
                                                listaAlquiler[i].agregarMasVheiculos(nuevoVehiculos);
                                                Console.Clear();
                                                Console.WriteLine("Agregado Correctamente");
                                                Console.WriteLine("");
                                                listaAlquiler[i].mostarAlquiler();
                                                Console.WriteLine("");
                                                listaVehiculos[b].mostrarVehiculos();


                                            }
                                        }

                                    }

                                }
                                break;

                            case 3:
                                for (int i = 0; i < listaAlquiler.Count; i++)
                                {
                                    for (int B = 0; B < listaAlquiler.Count; B++) 
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Alquiler "+"IDENTIFICADOR: "+ listaAlquiler[i].getNumeroAlquiler());
                                        Console.WriteLine("");
                                        listaAlquiler[i].mostarAlquiler();
                                        Console.WriteLine("");
                                        Console.WriteLine("Vehiculo " + "IDENTIFICADOR: " + listaVehiculos[B].getNumero());
                                        Console.WriteLine("");
                                        listaVehiculos[B].mostrarVehiculos();
                                    }
                                }
                                    break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1-Agregar Auto Familiar");
                        Console.WriteLine("2-Agregar Auto Utilitario");
                        Console.WriteLine("3-Agregar Auto Deportivo");
                        Console.WriteLine("4-Modificar Vehiculo");
                        Console.WriteLine("5-Salir");
                        Console.WriteLine("\n");
                        Console.WriteLine("Selecione una opcion");
                        Console.WriteLine("********* *** ******");
                        opciones2 = int.Parse(Console.ReadLine());

                        switch (opciones2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese la Capacidad del Maletero");
                                int capacidadMaletero = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese el identificador del vehiculo");
                                int Numero = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese Matricula del vehiculo");
                                string Matricula = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese Marca del vehiculo");
                                string Marca = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese el Color del Vehiculo");
                                string Color = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese Capacidad del Tanque");
                                float CapacidadTanque = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese el estado del vehiculo - Disponible/No Disponible");
                                string Estado = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese Precio");
                                int PrecioAlquiler = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese los Kilometros por Litro del Vehiculo");
                                float KmXLitro = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Nuevasucursal.agregarvehiculoFamiliar(capacidadMaletero, Numero, Matricula, Marca, Color, CapacidadTanque, Estado, PrecioAlquiler, KmXLitro);
                                Console.WriteLine("\n");
                                Console.WriteLine("AGREGADO CORRECTAMENTE");
                                Console.WriteLine("******** *************");

                                Console.WriteLine("IDENTIFICADOR: " + Numero);
                                Console.WriteLine("MARCA: " + Marca);
                                Console.WriteLine("MATRICULA: " + Matricula);
                                Console.WriteLine("COLOR: " + Color);
                                Console.WriteLine("CAPACIDAD DEL TANQUE: " + CapacidadTanque);
                                Console.WriteLine("ESTADO: " + Estado);
                                Console.WriteLine("PRECIO:" + PrecioAlquiler);
                                Console.WriteLine("KILOMETROS POR LITRO: " + KmXLitro);
                                Console.WriteLine("CAPACIDAD MALETERO: " + capacidadMaletero);
                                Console.WriteLine("\n");


                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese la Capacidad del carga del vehiculo");
                                int capacidadCarga = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese identificador del vehiculo");
                                int Numero2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese la Matricula del vehiculo");
                                string Matricula2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese la marca del vehiculo");
                                string Marca2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese el color del vehiculo");
                                string Color2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese la Capacidad del tanque del vehiculo");
                                float CapacidadTanque2 = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese el estado del vehiculo - Disponible/No Disponible");
                                string Estado2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese Precio");
                                int PrecioAlquiler2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese los kilometros por litro del vehiculo");
                                float KmXLitro2 = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Nuevasucursal.agregarvehiculoUtilitario(capacidadCarga, Numero2, Matricula2, Marca2, Color2, CapacidadTanque2, Estado2, PrecioAlquiler2, KmXLitro2);
                                Console.WriteLine("\n");
                                Console.WriteLine("AGREGADO CORRECTAMENTE");
                                Console.WriteLine("******** *************");
                                Console.WriteLine("IDENTIFICADOR: " + Numero2);
                                Console.WriteLine("MARCA: " + Marca2);
                                Console.WriteLine("MATRICULA: " + Matricula2);
                                Console.WriteLine("COLOR: " + Color2);
                                Console.WriteLine("CAPACIDAD DEL TANQUE: " + CapacidadTanque2);
                                Console.WriteLine("ESTADO: " + Estado2);
                                Console.WriteLine("PRECIO:" + PrecioAlquiler2);
                                Console.WriteLine("KILOMETROS POR LITRO: " + KmXLitro2);
                                Console.WriteLine("CAPACIDAD CARGA: " + capacidadCarga);
                                Console.WriteLine("\n");


                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingrese la Velocidad Maxima del vehiculo");
                                int VelocidadMaxima = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese identificador del vehiculo");
                                int NumeroD = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese la Matricula del vehiculo");
                                string MatriculaD = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese la marca del vehiculo");
                                string MarcaD = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese el color del vehiculo");
                                string ColorD = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese la Capacidad del tanque del vehiculo");
                                float CapacidadTanqueD = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese el estado del vehiculo - Disponible/No Disponible");
                                string EstadoD = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Ingrese el precio");
                                int PrecioAlquilerD = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Ingrese los kilometros por litro del vehiculo");
                                float KmXLitroD = float.Parse(Console.ReadLine());
                                Console.Clear();

                                Nuevasucursal.agregarvehiculoDeportivo(VelocidadMaxima, NumeroD, MatriculaD, MarcaD, ColorD, CapacidadTanqueD, EstadoD, PrecioAlquilerD, KmXLitroD);
                                Console.WriteLine("\n");
                                Console.WriteLine("AGREGADO CORRECTAMENTE");
                                Console.WriteLine("******** *************");
                                Console.WriteLine("IDENTIFICADOR: " + NumeroD);
                                Console.WriteLine("MARCA: " + MarcaD);
                                Console.WriteLine("MATRICULA: " + MatriculaD);
                                Console.WriteLine("COLOR: " + ColorD);
                                Console.WriteLine("CAPACIDAD DEL TANQUE: " + CapacidadTanqueD);
                                Console.WriteLine("ESTADO: " + EstadoD);
                                Console.WriteLine("PRECIO:" + PrecioAlquilerD);
                                Console.WriteLine("KILOMETROS POR LITRO: " + KmXLitroD);
                                Console.WriteLine("VELOCIDAD MAXIMA: " + VelocidadMaxima + " KM");
                                Console.WriteLine("\n");

                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese identificador del vehiculo");
                                int Numero3 = int.Parse(Console.ReadLine());
                                string matricula4;
                                string color4;
                                string Marca4;
                                float capacidadTanq;
                                int precioV;
                                float KMxLITRO;
                                string Estado4;
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int b = 0; b < listaVehiculos.Count; b++)
                                {
                                    if (Numero3 == listaVehiculos[b].getNumero() && listaVehiculos[b].getTipo() == "Auto Familiar")
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(listaVehiculos[b].getTipo());
                                        Console.WriteLine("");
                                        listaVehiculos[b].mostrarVehiculos();
                                        Console.WriteLine("");

                                        Console.WriteLine("Ingrese la Matricula del vehiculo");
                                        matricula4 = Console.ReadLine();
                                        Console.WriteLine("Ingrese la marca del vehiculo");
                                        Marca4 = Console.ReadLine();
                                        Console.WriteLine("Ingrese el color del vehiculo");
                                        color4 = Console.ReadLine();
                                        Console.WriteLine("Ingrese la Capacidad del tanque del vehiculo");
                                        capacidadTanq = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el estado del vehiculo - Disponible/No Disponible");
                                        Estado4 = Console.ReadLine();
                                        Console.WriteLine("Ingrese el precio");
                                        precioV = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los kilometros por litro del vehiculo");
                                        KMxLITRO = float.Parse(Console.ReadLine());

                                        listaVehiculos[b].setMatricula(matricula4);
                                        listaVehiculos[b].setMarca(Marca4);
                                        listaVehiculos[b].setColor(color4);
                                        listaVehiculos[b].setEstado(Estado4);
                                        listaVehiculos[b].setPrecioAlquiler(precioV);
                                        listaVehiculos[b].setkmXLitro(KMxLITRO);
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Vehiculo Modificado Correctamente");
                                        Console.WriteLine("");
                                        listaVehiculos[b].mostrarVehiculos(); ;
                                        Console.WriteLine("");


                                    }
                                }
                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("1-Ver Vehiculos Disponibles");
                        Console.WriteLine("2-Ver Vehiculos No Disponibles");
                        Console.WriteLine("");
                        Console.WriteLine("3-Ver Autos Familiares Disponibles");
                        Console.WriteLine("4-Ver Autos Familiares No Disponibles");
                        Console.WriteLine("");
                        Console.WriteLine("5-Ver Autos Utilitarios Disponibles");
                        Console.WriteLine("6-Ver Autos Utilitarios No Disponibles");
                        Console.WriteLine("");
                        Console.WriteLine("7-Ver Autos Deportivos Disponibles");
                        Console.WriteLine("8-Ver Autos Deportivos No Disponibles");
                        Console.WriteLine("***********************************+");
                        Console.WriteLine("9-Salir");
                        Console.WriteLine("Selecione una opcion");
                        Console.WriteLine("********* *** ******");
                        opciones3 = int.Parse(Console.ReadLine());
                        switch (opciones3)
                        {
                            case 1:

                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getEstado() == "Disponible")
                                    {

                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;

                            case 2:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getEstado() == "No Disponible")
                                    {

                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;

                            case 3:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Familiar" && listaVehiculos[i].getEstado() == "Disponible")
                                    {

                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;


                            case 4:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Familiar" && listaVehiculos[i].getEstado() == "No Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;

                            case 5:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Utilitario" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;


                            case 6:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Utilitario" && listaVehiculos[i].getEstado() == "No Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;

                            case 7:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Deportivo" && listaVehiculos[i].getEstado() == "Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;


                            case 8:
                                Console.Clear();
                                listaVehiculos = (Nuevasucursal.getVehiculos());
                                for (int i = 0; i < listaVehiculos.Count; i++)
                                {
                                    if (listaVehiculos[i].getTipo() == "Auto Deportivo" && listaVehiculos[i].getEstado() == "No Disponible")
                                    {
                                        listaVehiculos[i].mostrarVehiculos();
                                    }
                                }
                                break;

                        }

                        break;

                }

            } while (opciones != 0);


        }
    }
}














