using System;

string[] nomesEstudantes = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
int[] notasEstudantes = new int[10];
string conceitoNotaEstudante = "";

int qtdNotasParciais = 5;

int[] notasSophia = [90, 86, 87, 98, 100, 94, 90];
int[] notasAndrew = [92, 89, 81, 96, 90, 89];
int[] notasEmma = [90, 85, 87, 98, 68, 89, 89, 89];
int[] notasLogan = [90, 95, 87, 88, 96, 96];
int[] notasBecky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] notasChris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] notasEric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] notasGregor = new int[] { 91, 91, 91, 91, 91, 91, 91 };

Console.WriteLine("Student\t\tGrade\n");

foreach (string nome in nomesEstudantes)
{
  string estudanteAtual = nome;

  if (estudanteAtual == "Sophia")
    notasEstudantes = notasSophia;
  else if (estudanteAtual == "Andrew")
    notasEstudantes = notasAndrew;
  else if (estudanteAtual == "Emma")
    notasEstudantes = notasEmma;
  else if (estudanteAtual == "Logan")
    notasEstudantes = notasLogan;
  else if (estudanteAtual == "Becky")
    notasEstudantes = notasBecky;
  else if (estudanteAtual == "Chris")
    notasEstudantes = notasChris;
  else if (estudanteAtual == "Eric")
    notasEstudantes = notasEric;
  else if (estudanteAtual == "Gregor")
    notasEstudantes = notasGregor;
  else
    continue;

  int somaEstudante = 0;
  decimal notaEstudante;

  int qtdNotasExtras = 0;

  foreach (int nota in notasEstudantes)
  {
    qtdNotasExtras++;
    
    if (qtdNotasExtras <= qtdNotasParciais)
      somaEstudante += nota;
    else
      somaEstudante += nota / 10;
  }

  notaEstudante = (decimal)somaEstudante / qtdNotasParciais;

  if (notaEstudante >= 97)
    conceitoNotaEstudante = "A+";
  else if (notaEstudante >= 93)
    conceitoNotaEstudante = "A";
  else if (notaEstudante >= 90)
    conceitoNotaEstudante = "A-";
  else if (notaEstudante >= 87)
    conceitoNotaEstudante = "B+";
  else if (notaEstudante >= 83)
    conceitoNotaEstudante = "B";
  else if (notaEstudante >= 80)
    conceitoNotaEstudante = "B-";
  else if (notaEstudante >= 77)
    conceitoNotaEstudante = "C+";
  else if (notaEstudante >= 73)
    conceitoNotaEstudante = "C";
  else if (notaEstudante >= 70)
    conceitoNotaEstudante = "C-";
  else if (notaEstudante >= 67)
    conceitoNotaEstudante = "D+";
  else if (notaEstudante >= 63)
    conceitoNotaEstudante = "D";
  else if (notaEstudante >= 60)
    conceitoNotaEstudante = "D-";
  else
    conceitoNotaEstudante = "F";

  Console.WriteLine($"{estudanteAtual}\t\t{notaEstudante}\t{conceitoNotaEstudante}");

}

Console.WriteLine("Pressioner a tecla Enter para continuar");
Console.ReadLine();



/*
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
*/
