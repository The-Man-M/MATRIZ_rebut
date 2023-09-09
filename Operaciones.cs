using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ_rebut
{
    internal class Operaciones
    {
        public int[,] Sumar_Matrices(int[,] matriz_1, int[,] matriz_2, int[,] matriz_3)
        {
            for (int i = 0; i < matriz_3.GetLength(0); i++)//filas
            {
                for (int j = 0; j < matriz_3.GetLength(1); j++)//columnas
                {
                    matriz_3[i, j] = matriz_1[i, j] + matriz_2[i, j];

                }
            }
            return matriz_3;
        }
        //Resta de matrices 
        public int[,] Restar_Matrices(int[,] matriz_1, int[,] matriz_2, int[,] matriz_3)
        {
            for (int i = 0; i < matriz_3.GetLength(0); i++)//filas
            {
                for (int j = 0; j < matriz_3.GetLength(1); j++)//columnas
                {
                    matriz_3[i, j] = matriz_1[i, j] - matriz_2[i, j];

                }
            }
            return matriz_3;
        }
        //Multiplicar de matrices
        public int[,] Multiplicar_Matrices(int[,] matriz_1, int[,] matriz_2, int[,] matriz_3)
        {
            int suma_de_columnas_y_filas = 0;
            for (int i = 0; i < matriz_1.GetLength(0); i++)//filas de la matriz 1
            {

                for (int j = 0; j < matriz_2.GetLength(1); j++)//columnas matriz 2
                {
                    suma_de_columnas_y_filas = 0;
                    for (int k = 0; k < matriz_1.GetLength(1); k++)//Columnas matriz 1
                    {
                        suma_de_columnas_y_filas += (matriz_1[i, k] * matriz_2[k, j]);
                    }
                    matriz_3[i, j] = suma_de_columnas_y_filas; //el resultado lo agregamos a la matriz resultante
                }
            }
            return matriz_3;
        }
    }
}
