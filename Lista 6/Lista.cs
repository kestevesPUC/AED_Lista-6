using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6
{
	class Lista
	{
		int[] arr;
		int n;

		public Lista(int length)
		{
			try
			{
				arr = new int[length];
				n = 0;
			}
			catch (Exception e)
			{

			}
		}

		public void insereNoInicio(int value)
		{
			for (int i = n; i > 0; i--)
			{
				arr[i] = arr[i - 1];
			}

			arr[0] = value;
			n++;

		}

		public void insereNoFinal(int value)
		{

			if (n < 0)
			{
				throw new Exception("Sua lista está vazia!");
			}

			arr[n] = value;
			n++;
		}

		public void inserirPosicaoEspecifica(int value, int position)
		{
			for (int i = n; i > position; i--)
			{
				arr[i] = arr[i - 1];
			}

			arr[position] = value;
			n++;
		}

		public int removePrimeiraPosicao()
		{
			if (n < 0)
			{
				throw new Exception("Sua lista está vazia!");
			}

			int temp = arr[0];
			for (int i = 0; i < n; i++)
            {
				arr[i] = arr[i + 1];
            }
			
			n--;
			return temp;
		}

		public int removeUltimaPosicao()
		{
			if (n < 0)
			{
				throw new Exception("Sua lista está vazia!");
			}

			int temp = arr[n];

			n--;
			
			return temp;
		}

		public int removePosicaoEspecifica(int posicao)
		{
			if (n >= posicao)
			{
				throw new Exception("A posição informada não existe!");
			}

			int temp = arr[posicao];

			for(int i = posicao; i < n; i++)
            {
				arr[i] = arr[i + 1];
			}

			n--;

			return temp;
		}

		public int buscaPosicao(int value)
        {
			for(int i = 0; i < n; i++)
            {
				if (arr[i].Equals(value))
                {
					return i;
                }
            }

			throw new Exception($"O valor {value} não foi encontrado!");
		}

		public int contaEvidencia(int tempo)
        {
			int count = 0;
			foreach(int e in arr)
            {
				if (e.Equals(tempo))
					count++;
            }

			return count;
        }

		public void exibeListaToda()
        {
			foreach(int tempo in arr)
            {
                Console.Write($"{tempo}, ");
            }
        }

	}
}