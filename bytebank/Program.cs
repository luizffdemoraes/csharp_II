using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

// Comando para comentar linha ctrl + k + c
// Comando para descomentar ctrl + k + u
//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "André Silva";
//conta2.conta = "10123-X";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

//conta2.ExibirDadosDaConta();

//Console.WriteLine("Saldo da Amanda pré-saque: " + conta2.saldo);
//bool saque = conta2.Sacar(50);
//Console.WriteLine("Saque realizado? "+saque);

//Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);

////conta2.Depositar(60);
//Console.WriteLine("Saldo da Amanda pós-depósito: " + conta2.saldo);

// Ao fazer isso ambos ampontaram para o endereço em memoria da conta 2
//conta1 = conta2;

// Verificação de tipo por referencia todo objedo criado e armazenado em um espaço em memoria e ao realizar a verificação são divergentes pois são alocados em endereços diferentes
//Console.WriteLine(conta1 == conta2);

// Verificação de tipo por valor
//double valor = 100;
//Console.WriteLine(valor == conta1.saldo);

//ContaCorrente conta3 = new ContaCorrente();

//console.writeline("titular: " + conta1.titular);
//console.writeline("conta: " + conta1.conta);
//console.writeline("número agencia: " + conta1.numero_agencia);
//console.writeline("número da agencia: " + conta1.nome_agencia);
//console.writeline("saldo: " + conta1.saldo);

//Cliente cliente = new Cliente();

//cliente.nome = "Andre Silva";
//cliente.cpf = "10253541263";
//cliente.profissao = "Programador C#";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "Andre Silva";
//conta3.titular.cpf = "10253541263";
//conta3.titular.profissao = "Programador C#";
//conta3.conta = "2513252-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";

//Console.WriteLine(cliente.nome);
//if(conta3.titular==null)
//{
//    Console.WriteLine("O campo titular está nulo.");
//}

//Console.WriteLine(conta3.titular.nome);

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(235, "125358-X");
//conta4.Saldo =100;
//conta4.Titular = sarah;
//conta4.Numero_Agencia = -10;
//Console.WriteLine("Saldo: "+conta4.Titular.Nome);
//Console.WriteLine("Saldo: "+conta4.Saldo);
//Console.WriteLine(conta4.Numero_Agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(235, "125358-X");
ContaCorrente conta6 = new ContaCorrente(365, "957256-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();