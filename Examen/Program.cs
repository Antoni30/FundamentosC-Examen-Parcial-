using Examen;
using System;

class Program
{
    static void Main()
    {
        int opc=-1;

        
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1.-Ejercicio 1");
                Console.WriteLine("2.-Ejercicio 2");
                Console.WriteLine("3.-Ejercicio 3");
                Console.WriteLine("4.-Ejercicio 4");
                Console.WriteLine("5.-Ejercicio 5");
                Console.WriteLine("0.-Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        //Ejerccio 1
                        int numA = 5;
                        int numB = 10;
                        int resultado = numA + numB;
                        Console.WriteLine("El resultado de la suma de " + numA + '+' + numB + " es " + resultado);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        //Ejerccio 2
                        int edad = 18;
                        if (edad >= 18)
                        {
                            Console.WriteLine("Es mayor de edad");
                        }
                        else
                        {
                            Console.WriteLine("Es menor de Edad");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        //ejercicio 3
                        Estudiante estudiante1 = new Estudiante("Antoni", 25, 20);
                        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
                        Console.WriteLine($"Edad: {estudiante1.Edad}");
                        Console.WriteLine($"Calificaciones: {estudiante1.Calificaciones}\n");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        //ejerccio 4
                        Estudiante estudiante2 = new Estudiante("Antoni", 25, 20);
                        estudiante2.mostrarInformacion();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        //ejerccio 5
                        EstudianteGraduado graduado1 = new EstudianteGraduado("Mirian", 28, 19, "Licenciada Comercio Exterior");
                        graduado1.mostrarInformacion();
                        Console.WriteLine($"Titulo: {graduado1.Titulo}\n");
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Vuelva Pronto");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opción no reconocida. Selecciona 1, 2 o 3.");
                        Console.ReadLine();
                        break;
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error de Datos ingresados");
                Console.ReadLine();
            }
           
        } while (opc != 0);
    }
}

