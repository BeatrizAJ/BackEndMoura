using Encapsulamento;

ContaBancaria contaBia = new ContaBancaria();

contaBia.Depositar(-100);
contaBia.Depositar(20);

contaBia.Sacar(-200);

Console.WriteLine($"Saldo atual: R${contaBia.GetSaldo()}");
