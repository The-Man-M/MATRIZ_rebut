namespace MATRIZ_rebut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Matriz matriz_1 = new Matriz();
            Matriz matriz_2 = new Matriz();
            Matriz matriz_resultante = new Matriz();
            int filas1, columnas1;
            int filas2, columnas2;
            Operaciones Caulculadora = new Operaciones();


            do
            {

                




                //*Pedir al usuario el tamaño de la matriz 1 
                
                Console.WriteLine("Ingrese la cantidad de filas que llevara la matriz 1");
                filas1 = num_po();

                Console.WriteLine("\nIngrese la cantidad de columnas que llevara la matriz 1");
                columnas1 = num_po();

                matriz_1.matriz_tamaño(filas1, columnas1);
                matriz_1.llenar_matriz();

                //Pedir al usuario el tamaño de la matriz 2
                Console.WriteLine("\nIngrese la cantidad de filas que llevara la matriz 2");
                filas2 = num_po();

                Console.WriteLine("\nIngrese la cantidad de columnas que llevara la matriz 2");
                columnas2 = num_po();

                matriz_2.matriz_tamaño(filas2, columnas2);
                matriz_2.llenar_matriz();

               
                Console.Clear();
                do
                {
                    
                    if (matriz_igual_s_r_m(matriz_1.GetMatriz(), matriz_2.GetMatriz()))
                    {
                        matriz_resultante.matriz_tamaño(matriz_1.GetFilas(), matriz_2.GetColumnas());
                        Console.WriteLine("Menu\n1. Suma\n2. resta\n3. multiplicación\n4. Volver al inicio\n5. Salir");

                        menu = num_rango(1, 5);
                    }
                    else if (matriz_igual_m(matriz_1.GetMatriz(), matriz_2.GetMatriz()))
                    {
                     
                        matriz_resultante.matriz_tamaño(matriz_1.GetFilas(), matriz_1.GetColumnas());
                        Console.Write("Dadas las longitudes le la matriz. Usted puede\n");
                        Console.ForegroundColor = ConsoleColor.Red; // Establecer el color de primer plano (texto) a rojo.
                        Console.BackgroundColor = ConsoleColor.Yellow; // Establecer el color de fondo a amarillo.

                        Console.Write("1. Suma\n2. resta\n");
                        Console.ResetColor();
                        Console.WriteLine("3. multiplicación\n4. Volver al inicio\n5. Salir");

                        menu = num_rango(3, 5);
                    }
                    switch (menu)
                    {
                        case 1:


                            Caulculadora.Sumar_Matrices(matriz_1.GetMatriz(), matriz_2.GetMatriz(), matriz_resultante.GetMatriz());

                            break;
                        case 2:
                            Caulculadora.Restar_Matrices(matriz_1.GetMatriz(), matriz_2.GetMatriz(), matriz_resultante.GetMatriz());



                            break;
                        case 3:
                            Caulculadora.Multiplicar_Matrices(matriz_1.GetMatriz(), matriz_2.GetMatriz(), matriz_resultante.GetMatriz());

                            break;
                        default:
                            break;


                    }
                    if (menu != 4 && menu != 5)
                    {

                        Console.WriteLine("\nMATRIZ 1");
                        matriz_1.mostrar_matriz();
                        Console.WriteLine("\nMATRIZ 2");
                        matriz_2.mostrar_matriz();
                        Console.WriteLine("\nMATRIZ RESULTANTE");
                        matriz_resultante.mostrar_matriz();
                        Console.ReadKey();

                    }
                    Console.Clear();

                } while (menu != 4 && menu != 5);
                Console.Clear();
            } while (menu != 5);

            static bool matriz_igual_s_r_m(int[,] matriz1, int[,] matriz2)
            {
                if (matriz1.GetLength(0) == matriz2.GetLength(0))
                {
                    if (matriz1.GetLength(1) == matriz2.GetLength(1))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            static bool matriz_igual_m(int[,] matriz1, int[,] matriz2)
            {
                if (matriz1.GetLength(0) == matriz2.GetLength(1))
                {
                    if (matriz1.GetLength(1) == matriz2.GetLength(0))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }

            static int num_po()
            {
                int numero;

                do
                {
                    Console.Write("Ingresa un número positivo: ");

                } while (!int.TryParse(Console.ReadLine(), out numero) || !Numero_Po(numero));
                return numero;
                static bool Numero_Po(int numero)
                {
                    return numero > 0;
                }
            }
            static int num_rango(int num_min, int num_max)
            {

                int numero;

                do
                {

                    Console.Write($"\nIngresa un número entre {num_min} y {num_max}: ");

                } while (!int.TryParse(Console.ReadLine(), out numero) || !Numero_ran(numero, num_min, num_max));
                return numero;

                static bool Numero_ran(int numero, int num_min, int num_max)
                {
                    if (numero >= num_min)
                    {
                        if (numero <= num_max)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;

                }
            }


        }

    }

}