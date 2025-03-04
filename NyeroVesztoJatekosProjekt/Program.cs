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