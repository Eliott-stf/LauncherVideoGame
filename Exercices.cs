namespace Bases;

/// <summary>
/// Les exercices du chapitre 02. Chacun est une méthode « static » : on
/// l'appelle sans créer d'objet, Exercices.CalculerScore(3, 1).
///
/// Remplacez chaque « throw new NotImplementedException() » par votre code,
/// puis lancez « dotnet run » : le programme vérifie vos réponses.
/// </summary>
public static class Exercices
{
    // Exercice 1 — chaînes et interpolation.
    // Bienvenue("Astra") renvoie « Bienvenue, Astra ! Prêt pour le décollage ? »
    public static string Bienvenue(string pseudo)
    {
        throw new NotImplementedException();
        
    }

    // Exercice 2 — une méthode qui calcule : 10 points par astéroïde évité,
    // 50 par cristal ramassé.
    public static int CalculerScore(int asteroidesEvites, int cristaux)
    {
        throw new NotImplementedException();
    }

    // Exercice 3 — conditions : le grade du pilote selon son score.
    //   moins de 500 → « Cadet » ; moins de 2 000 → « Pilote » ; sinon « As ».
    //   Un score négatif est une erreur : on lève une ArgumentOutOfRangeException.
    public static string Grade(int score)
    {
        throw new NotImplementedException();
    }

    // Exercice 4 — boucle for : CompteARebours(3) renvoie « 3… 2… 1… Décollage ! »
    // (le caractère « … » est un seul caractère : copiez-le depuis ce commentaire).
    public static string CompteARebours(int depart)
    {
        throw new NotImplementedException();
    }

    // Exercice 5 — foreach sur une liste : le meilleur score et la moyenne.
    // Une liste vide renvoie (0, 0) au lieu de planter.
    public static (int Meilleur, double Moyenne) Statistiques(List<int> scores)
    {
        throw new NotImplementedException();
    }

    // Exercice 6 — dictionnaire : combien d'actualités par catégorie ?
    // ["annonce", "mise_a_jour", "annonce"] → { annonce: 2, mise_a_jour: 1 }
    public static Dictionary<string, int> CompterParCategorie(List<string> categories)
    {
        throw new NotImplementedException();
    }

    // Exercice 7 — lire un entier saisi, sans planter.
    // LireEntier("42") renvoie 42 ; LireEntier("abc") renvoie null.
    public static int? LireEntier(string saisie)
    {
        throw new NotImplementedException();
    }
}
