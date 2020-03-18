using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
	class Matrices
	{
		public static int[,] SumaMatriz(int[,] matriz1, int[,] matriz2, RadioButton op)
		{
			int[,] resultado = new int[5, 5];
			for (int f = 0; f < resultado.GetLength(0); f++)
			{
				for (int c = 0; c < resultado.GetLength(1); c++)
				{
					resultado[f, c] = matriz1[f, c] + matriz2[f, c];
				}
			}
			return resultado;
		}
		public static int[,] MultiplicaMatriz(int[,] matriz1, int[,] matriz2, RadioButton op)
		{
			int[,] resultado = new int[5, 5];
			for (int f = 0; f < resultado.GetLength(0); f++)
			{
				for (int c = 0; c < resultado.GetLength(1); c++)
				{
					resultado[f, c] = matriz1[f, c] * matriz2[f, c];
				}
			}
			return resultado;
		}
	}
}
