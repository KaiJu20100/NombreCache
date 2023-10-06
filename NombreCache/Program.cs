/**
 * Jeu du nombre caché
 * auteur : Emds
 * date : 02/10/2023
 */
using System;

namespace NombreCache
{
    class Program
    {
        static int essai;

        static void saisie()
        {
            bool correct = false; //toujours mettre correct = false avant le while try and catch
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : Saisissez un nombre entier");
                }
            }
        }

        static void Main(string[] args)
        {
            //Déclaration
            int valeur = 0, essai = 0, nbre = 1;
            bool correct = false; //toujours mettre correct = false avant le while try and catch

            //Saisie du nombre à chercher
            while (!correct)
            {
                try 
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch 
                {
                    Console.WriteLine("Erreur de saisie : Saisissez un nombre entier");
                }
            }
            Console.Clear();


            //Saisie du premier essai
            saisie();

            //Créer la boucle
            while (essai != valeur)
            {
                //Test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> Trop grand ! ");
                }
                else
                {
                    Console.WriteLine(" --> Trop petit ! ");
                }
                //Saisie d'un nouvel essai
                saisie()
                //compteur d'essais
                nbre++;
            }

            //valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+ nbre +" fois !");

            Console.ReadLine();
        }
    }
}
