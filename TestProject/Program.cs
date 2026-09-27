// Console.WriteLine("Olá, C#!");


// Simula lançamento de dados de 6 faces
/*Random dado = new Random();
int jogada = dado.Next(1, 7);
Console.WriteLine(jogada);*/


//Overloads do método Next() da classe Random
/*Random dado = new Random();
int jogada1 = dado.Next();
int jogada2 = dado.Next(101);
int jogada3 = dado.Next(50, 101);

Console.WriteLine($"First jogada: {jogada1}");
Console.WriteLine($"Second jogada: {jogada2}");
Console.WriteLine($"Third jogada: {jogada3}");*/


//Uso do método Math.Max() para encontrar o maior valor entre dois números
/*int primeiroValor = 500;
int segundoValor = 600;
int maiorValor = Math.Max(primeiroValor, segundoValor);

Console.WriteLine(maiorValor);*/


// Matriz / Array
/*string[] idsPedidosFraudulentos = new string[3];

idsPedidosFraudulentos[0] = "A123";
idsPedidosFraudulentos[1] = "B456";
idsPedidosFraudulentos[2] = "C789";*/


// Introdução a Arrays
/*string[] idsPedidosFraudulentos = ["A123", "B456", "C789"]; //sintaxe de expressão Collection

Console.WriteLine($"Primeiro: {idsPedidosFraudulentos[0]}");
Console.WriteLine($"Segundo: {idsPedidosFraudulentos[1]}");
Console.WriteLine($"Terceiro: {idsPedidosFraudulentos[2]}");

idsPedidosFraudulentos[0] = "F000";

Console.WriteLine($"Primeiro reatribuído: {idsPedidosFraudulentos[0]}");

Console.WriteLine($"Existem {idsPedidosFraudulentos.Length} pedidos fraudulentos para processar.");*/


// Implementando foreach para percorrer um array, através de um loop.
/*int[] estoque = { 200, 450, 700, 175, 250 };
int soma = 0;
int compartimento = 0;

foreach (int itens in estoque)
{
    soma += itens;
    compartimento++;
    Console.WriteLine($"Compartimento {compartimento} = {itens} items (Total acumulado: {soma})");
}

Console.WriteLine($"Temos {soma} itens em estoque.");*/

// Armazenar e iterar com Arrays e foreach
/*string[] idsPedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string idPedido in idsPedidos)
{
    if (idPedido.StartsWith('B'))
    {
        Console.WriteLine(idPedido);
    }
}*/


