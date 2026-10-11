// Set up the game
Random random = new Random();
int roundsPlayed = 8;
List<int> allScores = new List<int>();

Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

// Simulate playing rounds and log every score
for (int round = 1; round <= roundsPlayed; round++)
{
  int score = random.Next(0, 101);
  allScores.Add(score);
  Console.WriteLine($"Round {round}: scored {score} points");
}

Console.WriteLine($"\nTotal rounds logged: {allScores.Count}");

// Build the Top 5 leaderboard array
allScores.Sort();
allScores.Reverse();

int[] topScores = new int[5];

// NOVO: Usa Math.Min para evitar erros caso a lista tenha menos itens que o array
int slotsToFill = Math.Min(topScores.Length, allScores.Count);

for (int i = 0; i < slotsToFill; i++)
{
  topScores[i] = allScores[i];
}

// Print the leaderboard
Console.WriteLine("\n🏆 Top 5 Leaderboard 🏆");

for (int i = 0; i < topScores.Length; i++)
{
  // NOVO: Alinhamento usando {valor, largura}
  // {i + 1,2} reserva 2 espaços para o ranking (alinhado à direita)
  // {topScores[i],3} reserva 3 espaços para a pontuação
  Console.WriteLine($"{i + 1,2}. {topScores[i],3} points");
}
