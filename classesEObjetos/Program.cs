using System;

public class Cliente
{
    public string cpf;
    public string nome;
    public string endereco;
    public string telefone;
    public string rg;
}

public class Conta
{
    public int Numero { get; set; } // Propriedade de número da conta
    public Cliente Titular { get; set; } // Associando um Cliente à Conta
    public double Saldo { get; set; } // Propriedade de saldo

    public Conta()
    {
        Saldo = 1000;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Deposita(double valor)
    {
        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        Cliente carol = new Cliente
        {
            cpf = "12345678900",
            nome = "Carol",
            endereco = "Rua A, 123",
            telefone = "123456789",
            rg = "123456789"
        };

        Conta c = new Conta
        {
            Titular = carol
        };

        Console.WriteLine("Saldo inicial: " + c.Saldo);
        Console.WriteLine("Titular: " + c.Titular.nome);
    }
}
