
using System;

double Aire (double longueur,double Largeur)
{

    return longueur*Largeur;
}
//Calcul de l'aire d'un hexagone avec logueurCote passé en parametre
double AireHexagone (double longueurCote)
{
    return (3 * Math.Sqrt(3) * Math.Pow(longueurCote, 2)) / 2;
}

double l, L;

Console.WriteLine("Saisir la longueur du rectangle :");
L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisir la largeur du rectangle :");
l = Convert.ToDouble(Console.ReadLine());

double aireRectangle = Aire(L, l);

Console.WriteLine($"L'aire du rectangle est : {aireRectangle}");


double longueurCote = 3.8;

double aireHexagone = AireHexagone(longueurCote);

Console.WriteLine($"L'aire de l'hexagone est : {aireHexagone}");
