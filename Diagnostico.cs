using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnosticow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Seleccion = 1;
            while (Seleccion != 0) 
            {
                Console.Clear();
                Console.WriteLine("Elija una de las opciones");
                Console.WriteLine("-1: While1.50  -2: WhilePar  -3: WhileSel  -4: For1.50  -5: ForPar  -6: ForSel  -7: DoWhileDia  -8: DoWhileMes  -9: DoWhilePoI  -0: Salir ");
                Seleccion = int.Parse(Console.ReadLine()); Console.Clear();
                switch (Seleccion) 
                {
                    case 1:
                        int num = 1;
                        while (num <= 50) 
                        {
                            Console.WriteLine(num); num++;
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        int pares = 1;
                        while (pares <= 50) 
                        {
                            if ((pares % 2) == 0) 
                            {
                                Console.WriteLine(pares);
                            }
                            pares++;
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        int inicio, fin;
                        Console.WriteLine("Ingrese desde donde: "); inicio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese hasta donde: "); fin = int.Parse(Console.ReadLine());
                        while (inicio <= fin) 
                        {
                            Console.WriteLine(inicio);
                            inicio++;
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        for (int i = 1; i <= 50; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        for (int i = 1; i <= 50; i++)
                        {
                            if ((i % 2 == 0)) 
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        int ini=0, fn=0;
                        Console.WriteLine("Ingrese desde donde: "); ini = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese hasta donde: "); fn = int.Parse(Console.ReadLine());
                        for (int i = ini; i <= fn; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        int Selec;
                        do
                        {
                            Console.WriteLine("Ingrese un numero del 1 al 7");
                            Selec = int.Parse(Console.ReadLine());
                            switch (Selec)
                            {
                                case 1:
                                    Console.WriteLine("Domingo");
                                    break;
                                case 2:
                                    Console.WriteLine("Lunes");
                                    break;
                                case 3:
                                    Console.WriteLine("Martes");
                                    break;
                                case 4:
                                    Console.WriteLine("Miercoles");
                                    break;
                                case 5:
                                    Console.WriteLine("Jueves");
                                    break;
                                case 6:
                                    Console.WriteLine("Viernes");
                                    break;
                                case 7:
                                    Console.WriteLine("Sabado");
                                    break;
                                default:
                                    Selec = 0;
                                    break;
                            }
                        } while (Selec != 0);
                        break;
                    case 8:
                        int Num;
                        do
                        {
                            Console.WriteLine("Ingrese un numero del 1 al 12");
                            Num = int.Parse(Console.ReadLine());
                            switch (Num)
                            {
                                case 1:
                                    Console.WriteLine("Enero");
                                    break;
                                case 2:
                                    Console.WriteLine("Febrero");
                                    break;
                                case 3:
                                    Console.WriteLine("Marzo");
                                    break;
                                case 4:
                                    Console.WriteLine("Abril");
                                    break;
                                case 5:
                                    Console.WriteLine("Mayo");
                                    break;
                                case 6:
                                    Console.WriteLine("Junio");
                                    break;
                                case 7:
                                    Console.WriteLine("Julio");
                                    break;
                                case 8:
                                    Console.WriteLine("Agosto");
                                    break;
                                case 9:
                                    Console.WriteLine("Septiembre");
                                    break;
                                case 10:
                                    Console.WriteLine("Octubre");
                                    break;
                                case 11:
                                    Console.WriteLine("Noviembre");
                                    break;
                                case 12:
                                    Console.WriteLine("Diciembre");
                                    break;
                                default:
                                    Console.WriteLine("Valor incorrecto");
                                    Num = 0;
                                    Console.ReadKey();
                                    break;
                            }
                        } while (Num != 0);
                        break;
                    case 9:
                        int Seguir;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese un valor entero");
                            int Valor = int.Parse(Console.ReadLine());
                            if (Valor % 2 == 0)
                            {
                                Console.WriteLine("Es PAR");
                            }
                            else 
                            {
                                Console.WriteLine("Es IMPAR");
                            }
                            Console.WriteLine("Presione 1 si desea seguir, otro numero si non");
                            Seguir = int.Parse(Console.ReadLine());
                        } while (Seguir == 1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
