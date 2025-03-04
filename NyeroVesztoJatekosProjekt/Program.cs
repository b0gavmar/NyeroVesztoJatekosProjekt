﻿using NyeroVesztoJatekosProjekt.Models;

// 1. feladat
try
{
    Player nandor = new Player("Negatív Nándor", "negativnandor@jatekos.hu", -1000);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Player janos = new Player("Játékos Jani", "jatekos.jani@nyertes.hu", 50);
Console.WriteLine(janos);

Console.WriteLine("\n");

// 2. feladat
janos.ChangeScore(20);
janos.ChangeScore(30);
Console.WriteLine($"{janos.Name} {janos.WinCount} alkalommal nyert!");
janos.ChangeScore(-40);
Console.WriteLine($"{janos.IsWinningString} Aktuális pontszáma: {janos.Score}\n");