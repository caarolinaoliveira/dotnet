// See https://aka.ms/new-console-template for more information


public class Conta{
    public int Numero { get; set; } // Propriedade de número da conta
    public Cliente Titular { get; set; } // Associando um Cliente à Conta
    public double Saldo { get; protected set; } // Propriedade de saldo

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

public class ContaCorrete:Conta {
    public double Limite { get; set; } // Propriedade de limite
    public double Taxa { get; set; } // Propriedade de taxa

    public void Saca(double valor)
    {
        if (valor <= Saldo + Limite)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

public class ContaPoupanca:Conta{

}