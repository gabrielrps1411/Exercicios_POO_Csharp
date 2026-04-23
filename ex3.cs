/* UML

-------------------------
|         Hora          |
-------------------------
| - hora: int          |
| - minuto: int        |
| - segundo: int       |
-------------------------
| + Hora(h,m,s)        |
| + Incrementar(min:int): Hora |
| + EhMaior(outra:Hora): bool |
| + ToString(): string |
-------------------------

*/

using System;

class Hora
{
	private int hora;
	private int minuto;
	private int segundo;

	public Hora(int hora, int minuto, int segundo)
	{
		if (hora < 0 || hora > 23 || minuto < 0 || minuto > 59 || segundo < 0 || segundo > 59)
		{
			Console.WriteLine("Horário inválido!");
			this.hora = 0;
			this.minuto = 0;
			this.segundo = 0;
		}
		else
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
		}
	}

	
	public Hora Incrementar(int minutos)
	{
		int totalMinutos = this.hora * 60 + this.minuto + minutos;

		int novaHora = (totalMinutos / 60) % 24;
		int novoMinuto = totalMinutos % 60;

		return new Hora(novaHora, novoMinuto, this.segundo);
	}

	
	public bool EhMaior(Hora outra)
	{
		int totalSegundos1 = this.hora * 3600 + this.minuto * 60 + this.segundo;
		int totalSegundos2 = outra.hora * 3600 + outra.minuto * 60 + outra.segundo;

		return totalSegundos1 > totalSegundos2;
	}

	public override string ToString()
	{
		return $"{hora:D2}:{minuto:D2}:{segundo:D2}";
	}
}

class Program
{
	static void Main()
	{
		Hora h1 = new Hora(10, 30, 0);
		Hora h2 = h1.Incrementar(50);

		Console.WriteLine("Hora original: " + h1);
		Console.WriteLine("Nova hora: " + h2);

		Hora h3 = new Hora(11, 15, 0);

		Console.WriteLine("h2 é maior que h3? " + h2.EhMaior(h3));
	}
}