const int V_Max = 10;
const int V_Min = 1;
int nombreDeVies = 4;

Random random = new Random();
int nombreMagique = random.Next(V_Min, V_Max);

while (nombreDeVies > 0)
{
    Console.Write("Devniez le nombre magique entre " + V_Min + " et " + V_Max + " (il vous reste " + nombreDeVies + " vies): ");
    String resultat = Console.ReadLine();

    int nombreUtilisateur = 0;

    if (int.TryParse(resultat, out nombreUtilisateur))
    {
        // La convertion s'est bien passée
        if (nombreUtilisateur < V_Min || nombreUtilisateur > V_Max) {
            Console.WriteLine("ERREUR: Vous devez rentrer un nombre entre " + V_Min + " et " + V_Max);
            Console.WriteLine("");
        }
        else {

            if (nombreUtilisateur < nombreMagique)
            {
                Console.WriteLine("Le nombre magique est plus grand");

            }
            else if (nombreUtilisateur > nombreMagique)
            {
                Console.WriteLine("Le nombre magique est plus petit");
            }
            else
            {
                // Egalité
                Console.WriteLine("BRAVO ! vous avez trouvez le nombre magique");
                Console.WriteLine("");
                break;
            }

            nombreDeVies--;
        }
    }

    else
    { // erruer dans la conversion
        Console.WriteLine("ERREUR: Vous devez rentre un nombre.");
    }

    Console.WriteLine("");
}

// Sortie de la boucle
if (nombreDeVies == 0)
{
    Console.WriteLine("Désolé, vous avez perdu, le nombre magique était " + nombreMagique);
    Console.WriteLine("");
}
