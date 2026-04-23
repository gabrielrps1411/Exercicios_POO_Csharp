/* UML
 * 
 * -------------------------------
|     ContaBancaria           |
-------------------------------
| - numero: string           |
| - cpf: string              |
| - saldo: double            |
| - limite: double           |
-------------------------------
| + ContaBancaria(...)       |
| + Depositar(valor:double):void |
| + Sacar(valor:double):bool |
-------------------------------
*/

public void Depositar(double valor)
{
    if (valor <= 0)
    {
        Console.WriteLine("Valor inválido!");
        return;
    }

    
    if (saldo < 0)
    {
        double taxa = Math.Abs(saldo) * 0.03;
        valor -= taxa;

        Console.WriteLine($"Taxa de R${taxa:F2} cobrada devido ao saldo negativo.");
    }

    saldo += valor;

    Console.WriteLine($"Depósito realizado. Novo saldo: R${saldo:F2}");
}