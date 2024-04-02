
using System;
double Aire (double longueur,double Largeur)
{

    return longueur*Largeur;
}


double l;
double L;

Console.WriteLine("Saisir la longueur du rectangle :");
L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisir la largeur du rectangle :");
l = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"L'Aire vaut : {Aire(L,l)}");