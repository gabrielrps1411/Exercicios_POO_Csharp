/* UML da classe Turma
-------------------------------
|            Turma            |
-------------------------------
| - nomeCurso: string        |
| - codigoHorario: int       |
| - duracaoSemanas: int      |
| - alunos: Aluno[]          |
| - qtdAlunos: int           |
-------------------------------
| +LocalizarAluno(matricula:int): Aluno |
| +LancarNota(matricula:int, valor:double): void |
| +LancarFalta(matricula:int): void |
| +CalcularMediaTurma(): double |
| +PercentualAprovacao(): double |
| +EmitirRelatorio(): void  |
-------------------------------
*/


//b) Método para lançar nota
public void LancarNota(int matricula, double valor)
{
    Aluno aluno = LocalizarAluno(matricula);

    if (aluno != null)
    {
        aluno.LancarNota(valor);
    }
    else
    {
        Console.WriteLine("Aluno não encontrado!");
    }
}


//Método auxiliar
public Aluno LocalizarAluno(int matricula)
{
    for (int i = 0; i < qtdAlunos; i++)
    {
        if (alunos[i].GetMatricula() == matricula)
        {
            return alunos[i];
        }
    }
    return null;
}

//c) Percentual de aprovação da turma
public double PercentualAprovacao()
{
    int aprovados = 0;

    int totalAulas = duracaoSemanas; // 1 aula por semana

    for (int i = 0; i < qtdAlunos; i++)
    {
        if (alunos[i].Aprovado(totalAulas))
        {
            aprovados++;
        }
    }

    if (qtdAlunos == 0)
        return 0;

    return (double)aprovados / qtdAlunos * 100;
}