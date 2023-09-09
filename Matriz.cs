using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ_rebut
{
    internal class Matriz
    {
        public  int filas = 0, columnas = 0;
        public int[,] matriz;

        public void matriz_tamaño(int F, int C)
        {
            this.filas = F;
            this.columnas = C;
            matriz = new int[filas, columnas];
        }

        public  void llenar_matriz()
        {
            
            for (int i = 0; i < matriz.GetLength(0); i++)//filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++)//columnas
                {
                    matriz[i, j] = Aleatorio();//generamos un numero aleatorio y lo agregamos a la matriz
                }
            }
        }
        public int [,] GetMatriz()
        {

            
            return matriz;
        }
        public void mostrar_matriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
        static int Aleatorio()
        {
            Random Numero = new Random();

            return Numero.Next(1, 50);
        }
      public   int GetFilas()
        {
            return matriz.GetLength(0);
        }
       public int GetColumnas()
        {
            return matriz.GetLength(1);
        }

    }
}
