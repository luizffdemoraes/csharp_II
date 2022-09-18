using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

// Comando para comentar linha ctrl + k + c
// Comando para descomentar ctrl + k + u
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

// Ao fazer isso ambos ampontaram para o endereço em memoria da conta 2
conta1 = conta2;

// Verificação de tipo por referencia todo objedo criado e armazenado em um espaço em memoria e ao realizar a verificação são divergentes pois são alocados em endereços diferentes
Console.WriteLine(conta1 == conta2);

// Verificação de tipo por valor
double valor = 100;
Console.WriteLine(valor == conta1.saldo);


ContaCorrente conta3 = new ContaCorrente();

//console.writeline("titular: " + conta1.titular);
//console.writeline("conta: " + conta1.conta);
//console.writeline("número agencia: " + conta1.numero_agencia);
//console.writeline("número da agencia: " + conta1.nome_agencia);
//console.writeline("saldo: " + conta1.saldo);

Console.ReadKey();