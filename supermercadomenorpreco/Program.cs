using supermercadomenorpreco;

Console.WriteLine("Boas Vindas ao seu supermercado, Menor Preço!");

Produto produto1 = new Produto();

produto1.nome = "Bolacha Tortinha";
produto1.fabricante = "Adria";
produto1.codigo_de_barras = 888555222;
produto1.valor_unitario = 1.50;
produto1.valor_de_compra = 2.00;
produto1.quantidade_em_estoque = 1000;

Console.WriteLine("Nome " + produto1.nome);
Console.WriteLine("Fabricante " + produto1.fabricante);
Console.WriteLine("Código de Barras " + produto1.codigo_de_barras);
Console.WriteLine("Valor unitário " + produto1.valor_unitario);
Console.WriteLine("Valor de Compra " + produto1.valor_de_compra);
Console.WriteLine("Quantidade em estoque " + produto1.quantidade_em_estoque);

Console.ReadKey();

