/* a) UML – Classe PartidaBasquete
--------------------------------------
|        PartidaBasquete             |
--------------------------------------
| - nomeEquipe1: string             |
| - nomeEquipe2: string             |
| - pontosEquipe1: int[] (5)        |
| - pontosEquipe2: int[] (5)        |
| - qtdPeriodos: int                |
--------------------------------------
| +LancarPlacar(periodo:int, p1:int, p2:int): void |
| +GetTotalEquipe1(): int         |
| +GetTotalEquipe2(): int         |
| +GetVencedor(): string         |
| +GetPlacar(): string           |
--------------------------------------
*/

//b) Método para lançar placar
public void LancarPlacar(int periodo, int pEquipe1, int pEquipe2)
{
    if (periodo < 0 || periodo >= 5)
    {
        Console.WriteLine("Período inválido!");
        return;
    }

    pontosEquipe1[periodo] = pEquipe1;
    pontosEquipe2[periodo] = pEquipe2;

    if (periodo >= qtdPeriodos)
    {
        qtdPeriodos = periodo + 1;
    }
}

//c) Método para gerar placar (com StringBuilder)
using System.Text;

public string GetPlacar()
{
    StringBuilder sb = new StringBuilder();

    sb.AppendLine("Q1 Q2 Q3 Q4 PR FINAL");

    int total1 = 0;
    int total2 = 0;

    
    sb.Append(nomeEquipe1 + " ");
    for (int i = 0; i < 5; i++)
    {
        if (i < qtdPeriodos)
        {
            sb.Append(pontosEquipe1[i] + " ");
            total1 += pontosEquipe1[i];
        }
        else
        {
            sb.Append("XX ");
        }
    }
    sb.AppendLine(total1.ToString());

    
    sb.Append(nomeEquipe2 + " ");
    for (int i = 0; i < 5; i++)
    {
        if (i < qtdPeriodos)
        {
            sb.Append(pontosEquipe2[i] + " ");
            total2 += pontosEquipe2[i];
        }
        else
        {
            sb.Append("XX ");
        }
    }
    sb.AppendLine(total2.ToString());

    return sb.ToString();
}