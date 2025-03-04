using NyeroVesztoJatekosProjekt.Models;

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
janos.Win(20);
janos.Win(30);
Console.WriteLine($"{janos.Name} {janos.WinCount} alkalommal nyert!");
janos.Lose(40);
Console.WriteLine($"{janos.IsWinningString} Aktuális pontszáma: {janos.Score}");

Console.WriteLine("\n");

// 3. feladat
Player viktor = new Player("Vesztő Viktor", "vesztoviktor@vesztes.hu", 40);
viktor.Win(20);
viktor.Lose(30);
viktor.Lose(10);
Console.WriteLine($"{viktor.IsWinningString}");

Console.WriteLine("\n");

// 4. feladat
Console.WriteLine(janos.CompareWith(viktor));

Console.WriteLine("\n");

// 5. feladat

try
{
    viktor.Win(-10);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
viktor.Lose(60);
try
{
    viktor.Lose(-10);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}