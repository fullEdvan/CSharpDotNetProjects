using System;

string[] nomesEstudantes = ["Sophia", "Andrew", "Emma", "Logan"];

int notasParciais = 5;

int[] notasSophia = [90, 86, 87, 98, 100];
int[] notasAndrew = [92, 89, 81, 96, 90];
int[] notasEmma = [90, 85, 87, 98, 68];
int[] notasLogan = [90, 95, 87, 88, 96];

int somaAndrew = 0;
int somaEmma = 0;
int somaLogan = 0;

decimal notaAndrew;
decimal notaEmma;
decimal notaLogan;

foreach (string nome in nomesEstudantes)
{
  if (nome == "Sophia")
  {
    int somaSophia = 0;
    decimal notaSophia;

    foreach (int nota in notasSophia)
    {
      somaSophia += nota;
    }

    notaSophia = (decimal)somaSophia / notasParciais;

    string letraNotaSophia = "";

    if (notaSophia >= 97 && notaSophia <= 100)
    {
      letraNotaSophia = "A+";
    }
    else if (notaSophia >= 93 && notaSophia < 97)
    {
      letraNotaSophia = "A";
    }
    else if (notaSophia >= 90 && notaSophia < 93)
    {
      letraNotaSophia = "A-";
    }
    else if (notaSophia >= 87 && notaSophia < 90)
    {
      letraNotaSophia = "B+";
    }
    else if (notaSophia >= 83 && notaSophia < 87)
    {
      letraNotaSophia = "B";
    }
    else if (notaSophia >= 80 && notaSophia < 83)
    {
      letraNotaSophia = "B-";
    }
    else if (notaSophia >= 77 && notaSophia < 80)
    {
      letraNotaSophia = "C+";
    }
    else if (notaSophia >= 73 && notaSophia < 77)
    {
      letraNotaSophia = "C";
    }
    else if (notaSophia >= 70 && notaSophia < 73)
    {
      letraNotaSophia = "C-";
    }
    else if (notaSophia >= 67 && notaSophia < 70)
    {
      letraNotaSophia = "D+";
    }
    else if (notaSophia >= 63 && notaSophia < 67)
    {
      letraNotaSophia = "D";
    }
    else if (notaSophia >= 60 && notaSophia < 63)
    {
      letraNotaSophia = "D-";
    }
    else
    {
      letraNotaSophia = "F";
    }

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + notaSophia + "\t" + letraNotaSophia);
  }
}

foreach (int nota in notasAndrew)
{
  somaAndrew += nota;
}

foreach (int nota in notasEmma)
{
  somaEmma += nota;
}

foreach (int nota in notasLogan)
{
  somaLogan += nota;
}


notaAndrew = (decimal)somaAndrew / notasParciais;
notaEmma = (decimal)somaEmma / notasParciais;
notaLogan = (decimal)somaLogan / notasParciais;


Console.WriteLine("Andrew:\t\t" + notaAndrew + "\tB+");
Console.WriteLine("Emma:\t\t" + notaEmma + "\tB");
Console.WriteLine("Logan:\t\t" + notaLogan + "\tA-");

Console.WriteLine("Press the Enter key to continue");
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

// Otimização do if else para o cálculo da letra da nota de Sophia
/*string letraNotaSophia = "";

if (notaSophia >= 97)
    letraNotaSophia = "A+";
else if (notaSophia >= 93)
    letraNotaSophia = "A";
else if (notaSophia >= 90)
    letraNotaSophia = "A-";
else if (notaSophia >= 87)
    letraNotaSophia = "B+";
else if (notaSophia >= 83)
    letraNotaSophia = "B";
else if (notaSophia >= 80)
    letraNotaSophia = "B-";
else if (notaSophia >= 77)
    letraNotaSophia = "C+";
else if (notaSophia >= 73)
    letraNotaSophia = "C";
else if (notaSophia >= 70)
    letraNotaSophia = "C-";
else if (notaSophia >= 67)
    letraNotaSophia = "D+";
else if (notaSophia >= 63)
    letraNotaSophia = "D";
else if (notaSophia >= 60)
    letraNotaSophia = "D-";
else
    letraNotaSophia = "F";*/


// Otimização do if else para o cálculo da letra da nota de Sophia utilizando switch expression
/*string letraNotaSophia = notaSophia switch
{
>= 97 => "A+",
>= 93 => "A",
>= 90 => "A-",
>= 87 => "B+",
>= 83 => "B",
>= 80 => "B-",
>= 77 => "C+",
>= 73 => "C",
>= 70 => "C-",
>= 67 => "D+",
>= 63 => "D",
>= 60 => "D-",
_     => "F"
};*/