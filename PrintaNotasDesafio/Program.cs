int qtdProvas = 5;

string[] nomesEstudantes = ["Sophia", "Andrew", "Emma", "Logan"];

int[] notasSophia = [90, 86, 87, 98, 100, 94, 90];
int[] notasAndrew = [92, 89, 81, 96, 90, 89];
int[] notasEmma = [90, 85, 87, 98, 68, 89, 89, 89];
int[] notasLogan = [90, 95, 87, 88, 96, 96];

int[] notasEstudante = new int[10];

string conceitoNotaEstudante = "";

Console.Clear();
Console.WriteLine("Estudante\tNota1\tNota2 Conceito\tExtra Crédito\n");

foreach (string nome in nomesEstudantes)
{
  string estudanteAtual = nome;

  if (estudanteAtual == "Sophia")
    notasEstudante = notasSophia;

  else if (estudanteAtual == "Andrew")
    notasEstudante = notasAndrew;

  else if (estudanteAtual == "Emma")
    notasEstudante = notasEmma;

  else if (estudanteAtual == "Logan")
    notasEstudante = notasLogan;

  int somatorioProvas = 0;
  decimal nota1 = 0;
  decimal nota2 = 0;
  int qtdNotas = 0;
  int somatorioExtras = 0;
  decimal notaExtra = 0;
  decimal credito = 0;

  foreach (int nota in notasEstudante)
  {
    qtdNotas += 1;

    if (qtdNotas <= qtdProvas)
      somatorioProvas += nota;

    else
      somatorioExtras += nota;
  }

  nota1 = (decimal)(somatorioProvas) / qtdProvas;
  notaExtra = (decimal)(somatorioExtras) / (qtdNotas - qtdProvas);
  credito = (somatorioExtras * 0.1m) / qtdProvas;
  nota2 = nota1 + credito;

  if (nota2 >= 97)
    conceitoNotaEstudante = "A+";

  else if (nota2 >= 93)
    conceitoNotaEstudante = "A";

  else if (nota2 >= 90)
    conceitoNotaEstudante = "A-";

  else if (nota2 >= 87)
    conceitoNotaEstudante = "B+";

  else if (nota2 >= 83)
    conceitoNotaEstudante = "B";

  else if (nota2 >= 80)
    conceitoNotaEstudante = "B-";

  else if (nota2 >= 77)
    conceitoNotaEstudante = "C+";

  else if (nota2 >= 73)
    conceitoNotaEstudante = "C";

  else if (nota2 >= 70)
    conceitoNotaEstudante = "C-";

  else if (nota2 >= 67)
    conceitoNotaEstudante = "D+";

  else if (nota2 >= 63)
    conceitoNotaEstudante = "D";

  else if (nota2 >= 60)
    conceitoNotaEstudante = "D-";

  else
    conceitoNotaEstudante = "F";

  Console.WriteLine($"{estudanteAtual}\t\t{nota1}\t{nota2}\t  {conceitoNotaEstudante}\t{notaExtra} ({credito} pts)");
}

Console.WriteLine("\n\rPressione qualquer tecla para sair...");
Console.ReadLine();
