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
       return $"Bienvenue, {pseudo} ! Prêt pour le décollage ?";
    }

    // Exercice 2 — une méthode qui calcule : 10 points par astéroïde évité,
    // 50 par cristal ramassé.
    public static int CalculerScore(int asteroidesEvites, int cristaux)
    {
        const int AsteroidePoints = 10;
        const int CristalPoints = 50;
        return (asteroidesEvites * AsteroidePoints) + (cristaux * CristalPoints);
    }

    // Exercice 3 — conditions : le grade du pilote selon son score.
    //   moins de 500 → « Cadet » ; moins de 2 000 → « Pilote » ; sinon « As ».
    //   Un score négatif est une erreur : on lève une ArgumentOutOfRangeException.
    public static string Grade(int score)
    {
        if (score < 0)
            throw new ArgumentOutOfRangeException(nameof(score), "Un score ne peut pas être négatif.");
        if (score < 500) return "Cadet";
        if (score < 2000) return "Pilote";
        return "As";
    }

    // Exercice 4 — boucle for : CompteARebours(3) renvoie « 3… 2… 1… Décollage ! »
    // (le caractère « … » est un seul caractère : copiez-le depuis ce commentaire).
    public static string CompteARebours(int depart)
    {
        var morceaux = new List<string>();
        for (int i = depart; i >= 1; i--)
            morceaux.Add($"{i}…");
        morceaux.Add("Décollage !");
        return string.Join(" ", morceaux);
    }   
    // Exercice 5 — foreach sur une liste : le meilleur score et la moyenne.
    // Une liste vide renvoie (0, 0) au lieu de planter.
    public static (int Meilleur, double Moyenne) Statistiques(List<int> scores)
    {
        if (scores.Count == 0) return (0, 0);
        int meilleur = scores[0];
        int total = 0;
        foreach (int s in scores)
        {
            if (s > meilleur) meilleur = s;
            total += s;
        }
        return (meilleur, (double)total / scores.Count);
    }

    // Exercice 6 — dictionnaire : combien d'actualités par catégorie ?
    // ["annonce", "mise_a_jour", "annonce"] → { annonce: 2, mise_a_jour: 1 }
    public static Dictionary<string, int> CompterParCategorie(List<string> categories)
    {
        var compte = new Dictionary<string, int>();
        foreach (string c in categories)
        {
            if (compte.ContainsKey(c)) compte[c]++;
            else compte[c] = 1;
        }
        return compte;
    }

    // Exercice 7 — lire un entier saisi, sans planter.
    // LireEntier("42") renvoie 42 ; LireEntier("abc") renvoie null.
    public static int? LireEntier(string saisie)
    {
        if (int.TryParse(saisie, out int valeur))
            return valeur;
        return null;
    }
}
