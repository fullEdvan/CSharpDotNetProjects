// Set up the game
Random random = new();
int numeroSecreto = random.Next(1, 21);
int maxTentativas = 5;
int contagemTentativas = 0;
bool acertou = false;

Console.WriteLine("Estou pensando em um número entre 1 e 20.");
Console.WriteLine($"Você tem {maxTentativas} tentativas. Boa sorte!");

// Ask the player to guess (Sem validação de entrada)
/* while (contagemTentativas < maxTentativas)
{
    contagemTentativas++;
    Console.Write($"\nTentativa #{contagemTentativas}: ");
    int palpite = Convert.ToInt32(Console.ReadLine());

    // Check the guess and give feedback
    if (palpite == numeroSecreto)
    {
        Console.WriteLine($"Acertou! Você conseguiu em {contagemTentativas} tentativas.");
        acertou = true;
        break;
    }
    else if (palpite < numeroSecreto)
    {
        Console.WriteLine("Palpite abaixo.");
    }
    else
    {
        Console.WriteLine("Palpite acima.");
    }
}
 */
//  Ask the player to guess (Com validação de entrada)
while (contagemTentativas < maxTentativas)
{
    int palpite;
    Console.Write($"\nTentativa #{contagemTentativas + 1}: ");

    // Fica preso em um mini-loop até que o usuário digite um número inteiro válido
    while (!int.TryParse(Console.ReadLine(), out palpite))
    {
        Console.WriteLine("Entrada inválida! Por favor, digite apenas números inteiros.");
        Console.Write($"Tentativa #{contagemTentativas + 1}: ");
    }

    // Agora que temos um número válido, incrementamos a tentativa
    contagemTentativas++;

    // Check the guess and give feedback
    if (palpite == numeroSecreto)
    {
        Console.WriteLine($"Acertou! Você conseguiu em {contagemTentativas} tentativas.");
        acertou = true;
        break;
    }

    // NOVO: Usa Math.Abs para verificar se está muito perto (diferença de até 2 unidades)
    int diferenca = Math.Abs(palpite - numeroSecreto);
    if (diferenca <= 2)
    {
        Console.WriteLine("🔥 Você está muito perto!");
    }

    if (palpite < numeroSecreto)
    {
        Console.WriteLine("Palpite abaixo.");
    }
    else
    {
        Console.WriteLine("Palpite acima.");
    }
}

// Announce the result
if (!acertou)
{
    Console.WriteLine($"\nFim das tentativas! O número era {numeroSecreto}.");
}
