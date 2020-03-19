using System;
using static System.Console;
using System.IO;

namespace PlantillaDiseño
{
    class Program
    {
        static void Cabecera()
        {
            Clear();
            SetWindowSize(91,30);

            for(int i=2;i<89;i++)
            {
                SetCursorPosition(i,1);
                Write("═");//alt + 205
                SetCursorPosition(i,5);
                Write("═");//alt + 205
                
            }
            for(int i=1;i<6;i++)
            {
                SetCursorPosition(0,i);
                Write("║");//alt + 186
                SetCursorPosition(90,i);
                Write("║");//alt + 186
            }
            for(int i=2;i<5;i++)
            {
                SetCursorPosition(1,i);
                Write("║");//alt + 186
                SetCursorPosition(89,i);
                Write("║");//alt + 186
            }
            for(int i=2;i<89;i++)
            {
                SetCursorPosition(i,0);
                Write("─");//alt + 196
                SetCursorPosition(i,6);
                Write("─");//alt +196
            }
            SetCursorPosition(0,0);
            Write("╔╗");//alt + 201
            SetCursorPosition(89,0);
            Write("╔╗");//alt + 187
            SetCursorPosition(0,6);
            Write("╚╝");//alt + 200
            SetCursorPosition(89,6);
            Write("╚╝");//alt + 188
            SetCursorPosition(1,1);
            Write("╠");//alt + 204
            SetCursorPosition(89,1);
            Write("╣");//alt + 185
            SetCursorPosition(1,5);
            Write("╠");//alt + 204
            SetCursorPosition(89,5);
            Write("╣");//alt + 185

            SetCursorPosition(3,2);
            DateTime FechaActual = DateTime.Now;
            Write($"Fecha: {FechaActual.ToString("dd/MM/yyyy")}");

            SetCursorPosition(74,2);
            DateTime HoraActual = DateTime.Now;
            Write($"Hora: {HoraActual.ToString("HH:mm:ss")}");
        }
        static void Nombrificador(string NombreProyecto, string Nombre)
        {
            var ColorDeTinta = Console.ForegroundColor;
            SetCursorPosition(3,3);
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine($"Nombre: {Nombre}");
            SetCursorPosition(3,4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Write($"Proyecto: {NombreProyecto}");
            Console.ForegroundColor = ColorDeTinta;
            SetCursorPosition(1,11);
        }
        static void MarcoGrande()
        {
          for(int i=2;i<89;i++)
            {
                SetCursorPosition(i,8);
                Write("═");//alt + 205
                SetCursorPosition(i,27);
                Write("═");//alt + 205
                
            }
            for(int i=8;i<28;i++)
            {
                SetCursorPosition(0,i);
                Write("║");//alt + 186
                SetCursorPosition(90,i);
                Write("║");//alt + 186
            }
            for(int i=9;i<27;i++)
            {
                SetCursorPosition(1,i);
                Write("║");//alt + 186
                SetCursorPosition(89,i);
                Write("║");//alt + 186
            }
            for(int i=2;i<89;i++)
            {
                SetCursorPosition(i,7);
                Write("─");//alt + 196
                SetCursorPosition(i,28);
                Write("─");//alt +196
            } 
            SetCursorPosition(0,7);
            Write("╔╗");//alt + 201
            SetCursorPosition(89,7);
            Write("╔╗");//alt + 187
            SetCursorPosition(0,28);
            Write("╚╝");//alt + 200
            SetCursorPosition(89,28);
            Write("╚╝");//alt + 188
            SetCursorPosition(1,8);
            Write("╠");//alt + 204
            SetCursorPosition(89,8);
            Write("╣");//alt + 185
            SetCursorPosition(1,27);
            Write("╠");//alt + 204
            SetCursorPosition(89,27);
            Write("╣");//alt + 185 
        }
        static void TiempoEmpleado(DateTime HoraInicial, DateTime HoraFinal){
            long TicksIniciales = HoraInicial.Ticks;
            long TicksFinales = HoraFinal.Ticks;
            SetCursorPosition(2,26);
            Write($"Ticks: {TicksFinales - TicksIniciales}");
            
        }
        static void HoraCentro()
        {
            DateTime hora = DateTime.Now;
            SetCursorPosition(35,17);
            Write($"Dia: {hora.ToString("dd:MM:yyyy")}");
            SetCursorPosition(36,18);
            Write($"Hora: {hora.ToString("HH:mm:ss")}");
            for(int i=0;i<5;i++)
            {
                int r = new Random().Next(1000,2000);
                Beep(r,100);
            }
        }
        public struct TipoPersona
        {
            public string Nombre;
            public char Inicial;
            public FechaNacimiento DiaNacimiento;
            public float Altura;
        }
        public struct FechaNacimiento
        {
            public int dia;
            public int mes;
            public int año;
        }
        public struct AlmacenDatos
        {
            public string Artista;
            public string Titulo;
            public double Duracion;
            public double TamanoFichero;

        }
        static void Formulario()
        {
            AlmacenDatos cancion;
            SetCursorPosition(3,10);
            Write("Introduce el artista:");
            cancion.Artista = ReadLine();
            SetCursorPosition(3,11);
            Write("Titulo: ");
            cancion.Titulo = ReadLine();
            SetCursorPosition(3,12);
            Write("Duración: ");
            cancion.Duracion = double.Parse(ReadLine());
            SetCursorPosition(3,13);
            Write("Tamaño: ");
            cancion.TamanoFichero=double.Parse(ReadLine());
            SetCursorPosition(3,15);
            Write("Artista {0} Titulo {1} Duración {2} Tamaño{3}",cancion.Artista,cancion.Titulo,cancion.Duracion,cancion.TamanoFichero);

        }
        static void ArrayPersona()
        {
            TipoPersona []Humano= new TipoPersona[100];
            for(int i=0;i<100;i++)
            {
                SetCursorPosition(3,10);
                Write("Introduce el nombre: ");
                Humano[i].Nombre= ReadLine();
                SetCursorPosition(3,10);
                Write("                          ");
                SetCursorPosition(3,10);
                Write("Día de la fecha de nacimiento: ");
                Humano[i].DiaNacimiento.dia=Int32.Parse(ReadLine());
                Write("Mes de la fecha de nacimiento: ");
                Humano[i].DiaNacimiento.mes=Int32.Parse(ReadLine());
                Write("Año de la fecha de nacimiento: ");
                Humano[i].DiaNacimiento.año=Int32.Parse(ReadLine());
                SetCursorPosition(3,10);
                WriteLine("                          ");
            }
        }
        static void ArrayCanciones()
        {
            AlmacenDatos []canciones= new AlmacenDatos[10];
            int i=0;
            int opcion=0;

        Retorno:
            do
            {
                LimpiarMarcoGrande();
                SetCursorPosition(3,9);
                WriteLine("1 - Añadir nueva cancion.");
                SetCursorPosition(3,10);
                WriteLine("2 - Mostrar el titulo de todas las canciones.");
                SetCursorPosition(3,11);
                WriteLine("3 - Buscar una canción que dure menos de:");
                SetCursorPosition(3,12);
                try
                {
                opcion = Int32.Parse(ReadLine());
                }catch(Exception)
                {
                    SetCursorPosition(20,20);
                    Write("Opcion no válida.");
                    System.Threading.Thread.Sleep(2000);
                }
            }while(opcion>4 && opcion <0);
            

            switch(opcion)
            {
                case 1:
                    LimpiarMarcoGrande();                   
                    SetCursorPosition(3,9);
                    Write("Introduce el artista: ");
                    canciones[i].Artista= ReadLine();
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Titulo: ");
                    canciones[i].Titulo=ReadLine();
                RDuracion:    
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Duración: ");
                    try
                    {
                        canciones[i].Duracion=double.Parse(ReadLine());
                    }catch(Exception)
                    {
                        SetCursorPosition(20,20);
                        Write("Vuelve a introducir un número.");
                        System.Threading.Thread.Sleep(2000);
                        goto RDuracion;
                    }
                RTamaño:
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Tamaño: ");
                    try
                    {
                        canciones[i].TamanoFichero=double.Parse(ReadLine());
                    }catch(Exception)
                    {
                        SetCursorPosition(20,20);
                        Write("Vuelve a introducir un número.");
                        System.Threading.Thread.Sleep(2000);
                        goto RTamaño;
                    }
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    i++;
                    break;
                case 2:
                    int y;
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    WriteLine("Lista: ");
                    double d= 0.0;
                    for(y=0;y<canciones.Length;y++){
                        SetCursorPosition(3,y+10);
                        if(canciones[y].Duracion > d)
                        {
                            Write("Título {0} Cancion {1} Duración {2} Tamaño {3}", canciones[y].Titulo.ToString(),y+1, canciones[y].Duracion, canciones[y].TamanoFichero);
                            
                        }
                    }
                    SetCursorPosition(3,26);
                    Write("Pulsa una tecla para continuar.");
                    ReadKey();
                    break;
                case 3:
                    int z;
                    int fila = 0;
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Duración máxima:");
                    double x= double.Parse(ReadLine());
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    WriteLine("Lista: ");
                    double g = 0.0;
                    for(z=0;z<canciones.Length;z++){
                        SetCursorPosition(3,fila+10);
                        if(canciones[z].Duracion <= x && canciones[z].Duracion > g)
                        {
                            Write("Título {0} Canción {1} Duración {2}", canciones[z].Titulo, z+1, canciones[z].Duracion);
                             fila++;
                        }
                    }
                    SetCursorPosition(3,26);
                    Write("Pulsa una tecla para continuar.");
                    ReadKey();
                    break;
                /* case 3:
                    //int f=0;
                    int j;
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Duracion máxima: ");
                    double dur = double.Parse(ReadLine());
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    for(j=0;j<canciones.Length;j++){
                        SetCursorPosition(3,j+9);
                        if(canciones[j].Duracion<=dur)
                        {
                            Write($"Título {j+1} {canciones[j].Titulo}" );
                            //f++;
                        }
                    }
                    //SetCursorPosition(3,j+9);
                    WriteLine("Pulsa una tecla para continuar.");
                    ReadKey();
                    break; */
                default:
                    LimpiarMarcoGrande();
                    SetCursorPosition(3,9);
                    Write("Introduce una de las 3 opciones.");
                    System.Threading.Thread.Sleep(3000);
                    goto Retorno;
                
            }
            goto Retorno;
            /* for(int i=0;i<100;i++)
            { */
                
            //}
        }
        static void LimpiarMarcoGrande()
        {
            for(int i=2;i<=88;i++)
            {
                for(int j=9;j<=26;j++)
                {
                    SetCursorPosition(i,j);
                    Write(" ");
                }
            }
            SetCursorPosition(3,9);
        }
        static void CrearFichero()
        {
            StreamWriter fichero;
            fichero = File.CreateText("Mi primer archivo.txt");
            fichero.WriteLine("Esto es una líne ");
            fichero.Write("Esto es otra sin saltar de línea. ");
            fichero.WriteLine("Y una última saltando después");
            fichero.WriteLine("Y una última saltando después");
            fichero.Close();
        }
        static void LeerFichero()
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("Mi primer archivo.txt");
            linea = fichero.ReadLine();
            WriteLine(linea);
            WriteLine(fichero.ReadLine());
            WriteLine(fichero.ReadLine());
            fichero.Close();
        }
        static void ContinuarEscribiendoArchivo()
        {
            StreamWriter fichero;
            fichero = File.CreateText("Archivo abierto 01.txt");
            fichero.WriteLine("Primera Línea ");
            fichero.Close();

            fichero = File.AppendText("Archivo abierto 01.txt");
            fichero.WriteLine("Segunda Línea");
            fichero.Close();
        }
        static void ExisteArchivo()
        {
            StreamReader fichero;
            string nombreFichero;
            while(true)
            {
                WriteLine("Introduce el nombre del fichero");
                nombreFichero = ReadLine();
                if(nombreFichero == "salida")
                {
                    break;
                }
                if(File.Exists(nombreFichero))
                {
                    fichero = File.OpenText(nombreFichero);
                    WriteLine("La primera línea es {0} ",fichero.ReadLine());
                    fichero.Close();
                }else
                {
                    WriteLine("No existe.");
                }
            }
        }
        static void ArchivoExcepciones()
        {
            StreamReader fichero;
            string nombreFichero;
            string linea;
            WriteLine("Introduce el nomde del fichero: ");
            nombreFichero = ReadLine();
            try
            {
                fichero = File.OpenText(nombreFichero);
                do
                {
                    linea = fichero.ReadLine();
                    if(linea != null) WriteLine(linea);

                }while (linea!=null);
                fichero.Close();
            }catch (Exception exp)
            {
                WriteLine("Ha habido un error {0} ", exp.Message);
                return;
            }
        }
        static void ContarPeliculas()
        {
            StreamReader fichero;
            string linea;
            int numPeliculas=0;
            //string ficheroDisney;
            //fichero = File.OpenText("disney.txt");
            try
            {
                fichero = File.OpenText("disney.txt");
                do
                {
                    linea = fichero.ReadLine();
                    if(linea != null) numPeliculas++;
                    

                }while (linea!=null);
                fichero.Close();
            }catch (Exception exp)
            {
                WriteLine("Ha habido un error {0} ", exp.Message);
                return;
            }
            WriteLine($"Numero total de peliculas = {numPeliculas}");

        }
        static void NombrarPeliculas()
        {
            StreamReader fichero;
            
            string linea;
            
            try
            {
                fichero = File.OpenText("disney.txt");
                do
                {
                    
                    linea = fichero.ReadLine();
                    if(linea != null) WriteLine(linea);

                }while (linea!=null);
                fichero.Close();
            }catch (Exception exp)
            {
                WriteLine("Ha habido un error {0} ", exp.Message);
                return;
            }
        }
        static void NombrarPeliculasSinPuntos()
        {
            StreamReader fichero;
                     
            string linea;
                        
            try
            {
                fichero = File.OpenText("disney.txt");
                do
                {                   
                    
                    linea = fichero.ReadLine();
                    linea = linea.Replace("."," ");
                    if(linea != null) WriteLine(linea);
                  
                }while (linea!=null);
                fichero.Close();
            }catch (Exception exp)
            {
                WriteLine("Ha habido un error {0} ", exp.Message);
                return;
            }
        }
        static void DividirPeliculasInicial()
        {
            StreamReader ficheroDisney = File.OpenText("disney.txt");
            StreamWriter fichero;
            string linea;
            string nombreArchivo = "Empiezan por ";
            char caracter;
            char caracter2='@';
            //int i=0;
            do
            {
               linea = ficheroDisney.ReadLine();
               try
               {
                caracter = linea[0];
                   
               }catch(Exception)
               {
                   WriteLine("Completado");
                   System.Threading.Thread.Sleep(2000);
                   break;
               }

               
               if(caracter!=caracter2)
               {
                   fichero = File.CreateText(nombreArchivo+caracter);
                   fichero.WriteLine(linea);
                   caracter2 = caracter;
                   fichero.Close();
                   //i++;
               }else
               {
                   fichero = File.AppendText(nombreArchivo+caracter);
                   fichero.WriteLine(linea);
                    fichero.Close();

                   //i++;
               }
            }while(linea!=null);
            ficheroDisney.Close();
            
        }
        static void MostrarPeliculasInicial(){
            char c='0';
            string nombreArchivo;
            string linea;
            StreamReader fichero;
        
            for(int i=0;i<43;i++){
                
                nombreArchivo = "Empiezan por ";
                nombreArchivo += $"{c}";
                WriteLine($"Películas del archivo: {nombreArchivo}");
                WriteLine("\n");
                try
                {
                    fichero = File.OpenText(nombreArchivo);

                    do
                    {
                        linea = fichero.ReadLine();
                        if(linea!= null)
                        {
                            WriteLine(linea);
                        }
                    }while(linea!=null);

                }catch(Exception)
                {
                    WriteLine("No existe el archivo{0}.",nombreArchivo);
                                                     
                }

                c++;
                
                System.Threading.Thread.Sleep(1000);
                Clear();
            }
            
            ReadKey();
        }
        public struct Pelicula
        {
            public string Nombre;
            public string tamaño;
            public DateTime Fecha;
            
        }
        static void PeliculasDisneyDos()
        {
            string linea;
            string nombre;
            string tamaño;
            string SFecha;
            DateTime Fecha;
            StreamReader archivo;
            char [] caracteres;
            Pelicula[] peliDisney = new Pelicula[178];
            int i=0;
            
            try
            {
                archivo = File.OpenText("disney2.txt");
            }catch(Exception)
            {
                WriteLine("Error.");
                return;
            }

            linea = archivo.ReadLine();
            
            do
            { 
                SFecha = linea.Substring(0,10);
                WriteLine(SFecha);
                tamaño = linea.Substring(12,5);
                WriteLine(tamaño);
                if(linea[22].ToString()!="")
                {
                    nombre = linea.Substring(22);
                }else
                {
                    nombre = linea.Substring(23);
                }
                WriteLine(nombre);
            }while(linea!=null);

        }
        static void Main(string[] args)
        {
            DateTime HoraInicial= DateTime.Now;         
            Cabecera();
            Nombrificador("Estructuras","José Gabriel");
            //MarcoGrande();
            //HoraCentro();
            //SetCursorPosition(3,14);
            //Write("La edad de {0} inicial {1} edad {2} altura {3} ",Humano.Nombre,Humano.Inicial, Humano.Edad,Humano.Altura );
            //Formulario();
            //ArrayCanciones();
            //CrearFichero();
            SetCursorPosition(0,9);
            //LeerFichero();
            //ContinuarEscribiendoArchivo();
            //ExisteArchivo();
            //ArchivoExcepciones();
            //ContarPeliculas();
            //NombrarPeliculas();
            //NombrarPeliculasSinPuntos();
            //DividirPeliculasInicial();
            //MostrarPeliculasInicial();
            PeliculasDisneyDos();
            DateTime HoraFinal = DateTime.Now;
            TiempoEmpleado(HoraInicial,HoraFinal);
            SetCursorPosition(0,28);
        }
    }
}
