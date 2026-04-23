/* UML
 * 
 * -------------------------
|        Livro          |
-------------------------
| - titulo: string     |
| - autor: string      |
| - paginas: int       |
| - somaAvaliacoes:int |
| - qtdAvaliacoes:int  |
-------------------------
| + Livro(...)         |
| + Classificar():string |
| + Avaliar(nota:int):void |
| + Media():double     |
-------------------------
*/

using System;

class Livro
{
    private string titulo;
    private string autor;
    private int paginas;
    private int somaAvaliacoes;
    private int qtdAvaliacoes;

    public Livro(string titulo, string autor, int paginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.paginas = paginas;
        this.somaAvaliacoes = 0;
        this.qtdAvaliacoes = 0;
    }

    public string Classificar()
    {
        if (paginas <= 90)
            return "Curto";
        else if (paginas <= 200)
            return "Médio";
        else
            return "Longo";
    }

    public void Avaliar(int nota)
    {
        if (nota >= 0 && nota <= 5)
        {
            somaAvaliacoes += nota;
            qtdAvaliacoes++;
        }
        else
        {
            Console.WriteLine("Nota inválida!");
        }
    }

    public double Media()
    {
        if (qtdAvaliacoes == 0)
            return 0;

        return (double)somaAvaliacoes / qtdAvaliacoes;
    }
}

class Program
{
    static void Main()
    {
        Livro livro = new Livro("Clean Code", "Robert Martin", 250);

        livro.Avaliar(5);
        livro.Avaliar(4);
        livro.Avaliar(3);

        Console.WriteLine("Classificação: " + livro.Classificar());
        Console.WriteLine("Média de avaliações: " + livro.Media().ToString("F2"));
    }
}