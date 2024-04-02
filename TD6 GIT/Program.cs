
using System;
//Calcule de l'aire d'un rectangle avec variables longueur et largeur -> passage en parametres
//Valeur de retour: aire du rectangle
double Aire (double longueur,double Largeur)
{

    return longueur*Largeur;
}


double l;
double L;

//Saisie des variables 
Console.WriteLine("Saisir la longueur du rectangle :");
L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisir la largeur du rectangle :");
l = Convert.ToDouble(Console.ReadLine());
//Affichage
Console.WriteLine($"L'Aire vaut : {Aire(L,l)}");