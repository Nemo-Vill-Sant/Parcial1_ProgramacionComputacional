using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_ProgramacionComputacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = 0, operacion, BuscarId;
            String Código, BuscarCodigo, seguir = "si";
            String Nombre, BuscarNombre;
            String Facultad, BuscarFacultad;
            int Edad, Cantidad, BuscarEdad, indice = 0;
            string asignatura;
            double Nota1, notaFinal;
            double Nota2;

            Estudiantes[] arregloestudiantes = new Estudiantes[1];
            while (seguir == "si") 
            {
                Id += 1;
                Console.WriteLine("Ingrese los siguientes datos.");
                Console.Write("Ingrese el Código: ");
                Código = Console.ReadLine();
                Console.Write("Ingrese el Nombre: ");
                Nombre = Console.ReadLine();
                Console.Write("Ingrese la Edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la Facultad: ");
                Facultad = Console.ReadLine();
                Console.Write("Ingresa la Asignatura: ");
                asignatura = Console.ReadLine();
                Console.Write("Ingrese la nota del primer laboratorio: ");
                Nota1 = Double.Parse(Console.ReadLine());
                Nota1 = Nota1 * 0.5;
                Console.Write("Ingrese la nota del segundo laboratorio: ");
                Nota2 = Double.Parse(Console.ReadLine());
                Nota2 = Nota2 * 0.5;
                notaFinal = Nota1 + Nota2;
                arregloestudiantes[indice] = new Estudiantes(Id, Código, Nombre, Edad, Facultad, asignatura, notaFinal);

                Console.WriteLine("----------------------------------------------------------------------\n");
                Console.WriteLine("¿Desea agregar otro estudiante (si/no)?: ");
                seguir = Console.ReadLine();

                if (seguir == "si") 
                {
                    indice += 1;
                    Array.Resize(ref arregloestudiantes, arregloestudiantes.Length + 1);
                }
                else 
                {
                    seguir = "no";
                }
            }

            string buscar = "si";

            while (buscar == "si") 
            {
                int opcion;
                Console.WriteLine("1: Buscar por Codigo \n2: Buscar estudiantes reprobados \n3: Buscar estudiantes aprobados");
                Console.WriteLine("Ingrese su opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1) 
                {
                    Console.WriteLine("Ingrese el codigo del estudiante:");
                    string codigo = Console.ReadLine();
                    IEnumerable<Estudiantes> ConsultaCodigo = from estudiante in arregloestudiantes
                                                              where estudiante.Código == codigo
                                                              select estudiante;

                    int cantidaEncontrados = ConsultaCodigo.Count();
                    if (cantidaEncontrados != 0) 
                    {
                        Console.WriteLine("Resultado de la busqueda por código: ");
                        foreach (Estudiantes consulta in ConsultaCodigo)
                        {
                            Console.WriteLine(consulta.mostrar());
                        }
                    }
                    else 
                    {
                        Console.WriteLine("No se encontró ningún estudiante");
                    }
                }
                else if (opcion == 2) 
                {
                    Console.WriteLine("Estudiantes reprobados: ");
                    IEnumerable<Estudiantes> reprobados = from estudiante in arregloestudiantes
                                                          where estudiante.NotaFinal < 6
                                                          select estudiante;

                    int cantidaEncontrados = reprobados.Count();
                    if (cantidaEncontrados != 0)
                    {
                        foreach (Estudiantes consulta in reprobados)
                        {
                            Console.WriteLine(consulta.mostrar());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes reprobados");
                    }
                }
                else if (opcion == 3) 
                {
                    Console.WriteLine("Estudiantes aprobados: ");
                    IEnumerable<Estudiantes> aprobados = from estudiante in arregloestudiantes
                                                         where estudiante.NotaFinal >= 6
                                                         select estudiante;

                    int cantidaEncontrados = aprobados.Count();

                    if (cantidaEncontrados != 0) 
                    {
                        foreach (Estudiantes consulta in aprobados)
                        {
                            Console.WriteLine(consulta.mostrar());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes aprobados ");
                    }
                }
                Console.WriteLine("¿Desea realizar otra consulta (si/no)?: ");
                buscar = Console.ReadLine();
            }
        }
    }
}
