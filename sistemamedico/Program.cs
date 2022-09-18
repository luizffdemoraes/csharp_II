using sistemamedico;

Console.WriteLine("Boas Vindas ao seu sistema médico de atendimento");

Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "Luiz Moraes";
pessoa1.idade = 28;
pessoa1.peso = 80;
pessoa1.altura = 1.66;

Console.WriteLine("Nome " + pessoa1.nome);
Console.WriteLine("Idade " + pessoa1.idade);
Console.WriteLine("Peso " + pessoa1.peso);
Console.WriteLine("Altura " + pessoa1.altura);

Console.ReadKey();



