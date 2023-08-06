﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Listas_de_Exercicios
{
    internal class Biblioteca
    {
        public double[] FuncaoVetorOrdenar(double[] numero)
        {
            double aux = 0.00;

            for (int i = 0; i < numero.Length; i++)
            {
                for (int j = 0; j < numero.Length; j++)
                {
                    if (numero[i] < numero[j])
                    {
                        aux = numero[i];
                        numero[i] = numero[j];
                        numero[j] = aux;
                    }
                }
            }
            return numero;
        }
        public double[] FuncaoVetorMultiplo(double[] vetor, double multiplo)
        {
            int contador = 0;
            double[] aux = new double[vetor.Length];
            for (int i = 0; i < vetor.Length; i++)
            {
                if ((vetor[i] % multiplo) == 0)
                {
                    aux[contador] = vetor[i];
                    contador++;
                }
            }

            return aux;
        }
        public double FuncaoVetorAutoSoma(double[] vetor)
        {
            double resposta = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                resposta += vetor[i];
            }

            return resposta;
        }

        public double[] FuncaoVetoresSoma(double[] vetor1, double[] vetor2)
        {
            //Não importa se os vetores tem tamanho diferente!
            int tamanho = 0;

            if (vetor1.Length > vetor2.Length)
            {
                tamanho = vetor1.Length;
            }
            else
            {
                tamanho = vetor2.Length;
            }
            double[] valor2 = new double[tamanho];
            double[] valor1 = new double[tamanho];
            double[] resultado = new double[tamanho];


            for (int i = 0; i < tamanho; i++)
            {

                if (i < vetor1.Length)
                {
                    valor1[i] = vetor1[i];
                }
                else
                {
                    valor1[i] = 0;
                }

                if (i < vetor2.Length)
                {
                    valor2[i] = vetor2[i];
                }
                else
                {
                    valor2[i] = 0;
                }
            }
            for (int i = 0; i < tamanho; i++)
            {
                resultado[i] = valor1[i] + valor2[i];
            }

            return resultado;
        }

        public double[,] FuncaoMatrizOrdenar(double[,] matriz)
        {
            //passa os valores da matriz para um vetor
            double[] vetor = new double[matriz.Length];
            int contador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    vetor[contador] = matriz[i, j];
                    contador++;
                }
            }

            //Ordena o vetor
            double[] aux = new double[vetor.Length];
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux[i] = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux[i];
                    }
                }
            }

            //passa os valores do vetor para matriz
            contador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = vetor[contador];
                    contador++;
                }
            }

            return matriz;
        }

        public double[,] FuncaoMatrizMultiplo(double[,] matriz, double multiplo)
        {
            double[,] aux = new double[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((matriz[i, j] % multiplo) == 0)
                    {
                        aux[i, j] = matriz[i, j];
                    }
                }
            }

            return aux;
        }

        public double FuncaoMediaVetor(double[] vetor)
        {
            return FuncaoVetorAutoSoma(vetor) / vetor.GetLength(0);
        }

        public double[,] FuncaoMatrizImparPar(double[,] matriz, int tipo)//tipo 1 é par e 2 é impar
        {
            double[,] aux = new double[matriz.GetLength(0), matriz.GetLength(1)];

            //par
            if (tipo == 1)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if ((matriz[i, j] % 2) == 0)
                        {
                            aux[i, j] = matriz[i, j];
                        }
                    }
                }
            }

            //impar
            if (tipo == 2)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if ((matriz[i, j] % 2) != 0)
                        {
                            aux[i, j] = matriz[i, j];
                        }
                    }
                }
            }

            return aux;
        }
    }
}