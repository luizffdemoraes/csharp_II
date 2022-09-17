using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
Console.WriteLine("Número da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();