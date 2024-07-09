// See https://aka.ms/new-console-template for more information
using ExoClasses.Classes;


/*
Chaise
Sujet
Créer une classe Chaise possédant comme variables
d’instance le nombre de pieds, le matériaux et la couleur
de l’objet
Afficher ses informations en surchargeant une méthode
de la classe Object
La classe Chaise pourra être instanciée avec ou sans
paramètres (Constructeur par défaut)
Afficher toutes les chaises (Possibilité de simplifier avec
une méthode ToString)
*/

Chaise chaise1 = new Chaise();
chaise1.NbrDePieds = 4;
chaise1.Couleur = "blanche";
chaise1.Matière = "bois";

Chaise chaise2 = new Chaise("","noire","métal",3);

Console.WriteLine(chaise1.Affiche());
Console.WriteLine(chaise2.Affiche());