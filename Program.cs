using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, ce programme va calculer votre IMC (Indice de Masse Corporelle) \n");
            Console.WriteLine("Entrez votre taille en m (exemple : 1,70)");
            double height = double.Parse(Console.ReadLine()); // on affecte valeur récupéré convertie en double à la var "height"
            Console.WriteLine("Entrez votre poids en kg");
            double weight = double.Parse(Console.ReadLine()); // idem avec "weight"
            double imc = Math.Round(weight / Math.Pow(height,2),2); // calcul de l'IMC : poids / taille au carré
            Console.WriteLine($"Votre Indice de Masse Corporelle est : {imc}");
            // selon la valeur de l'IMC, on obtient un message adapté
            if (imc < 16.5)
            {
                Console.WriteLine("Dénutrition");
            }
            else if (imc > 16.5 && imc <= 18.5)
            {
                Console.WriteLine("Maigreur");
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Corpulence Normale");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Surpoids");
            }
            else if (imc > 30 && imc <= 35)
            {
                Console.WriteLine("Obésité Modérée");
            }
            else if (imc > 35 && imc <= 40)
            {
                Console.WriteLine("Obésité Sévère");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obésité Morbide ou Massive");
            }
            else
            {
                Console.WriteLine("Je n'ai pas compris ! Il doit y avoir une erreur...");
            }
        }
    }
}
