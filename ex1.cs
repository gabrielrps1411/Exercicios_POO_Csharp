using System;

class AnaliseNumeros
{
	private int[] numeros;

	public AnaliseNumeros(int tamanho)
	{
		numeros = new int[tamanho];
	}

	public void LerNumeros()
	{
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write($"Digite o {i + 1}º número: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
	}

	public int CalcularSoma()
	{
		int soma = 0;
		foreach (int num in numeros)
		{
			soma += num;
		}
		return soma;
	}

	public double CalcularMedia()
	{
		return (double)CalcularSoma() / numeros.Length;
	}

	public int ContarPares()
	{
		int count = 0;
		foreach (int num in numeros)
		{
			if (num % 2 == 0)
				count++;
		}
		return count;
	}

	public int ContarImpares()
	{
		int count = 0;
		foreach (int num in numeros)
		{
			if (num % 2 != 0)
				count++;
		}
		return count;
	}

	public int ContarMaioresQueMedia()
	{
		double media = CalcularMedia();
		int count = 0;

		foreach (int num in numeros)
		{
			if (num > media)
				count++;
		}
		return count;
	}

	public int ContarMenoresQueMetadeMedia()
	{
		double media = CalcularMedia();
		int count = 0;

		foreach (int num in numeros)
		{
			if (num < (media / 2))
				count++;
		}
		return count;
	}
}

class Program
{
	static void Main()
	{
		Console.Write("Digite a quantidade de números: ");
		int n = int.Parse(Console.ReadLine());

		AnaliseNumeros analise = new AnaliseNumeros(n);

		analise.LerNumeros();

		Console.WriteLine("\nRESULTADOS:");
		Console.WriteLine($"Soma: {analise.CalcularSoma()}");
		Console.WriteLine($"Média: {analise.CalcularMedia():F2}");
		Console.WriteLine($"Pares: {analise.ContarPares()}");
		Console.WriteLine($"Ímpares: {analise.ContarImpares()}");
		Console.WriteLine($"Maiores que a média: {analise.ContarMaioresQueMedia()}");
		Console.WriteLine($"Menores que metade da média: {analise.ContarMenoresQueMetadeMedia()}");
	}
}