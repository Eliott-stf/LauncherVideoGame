// Vérifie chaque exercice de Exercices.cs. Vous n'avez pas à modifier ce fichier.
//
//   ✓  l'exercice donne le résultat attendu
//   ✗  il donne autre chose (le résultat attendu est affiché à côté)
//   ·  il n'est pas encore écrit (NotImplementedException)
using Bases;

int reussis = 0, total = 0;

void Verifier(string nom, Func<object?> calcul, object? attendu)
{
    total++;
    object? obtenu;
    try
    {
        obtenu = calcul();
    }
    catch (NotImplementedException)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"· {nom} : à faire");
        Console.ResetColor();
        return;
    }
    catch (Exception e)
    {
        obtenu = $"{e.GetType().Name} : {e.Message}";
    }

    bool ok = Equals(obtenu, attendu);
    if (ok) reussis++;
    Console.ForegroundColor = ok ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine($"{(ok ? "✓" : "✗")} {nom} : {obtenu ?? "null"}{(ok ? "" : $"   (attendu : {attendu ?? "null"})")}");
    Console.ResetColor();
}

Console.OutputEncoding = System.Text.Encoding.UTF8;

Verifier("Exercice 1", () => Exercices.Bienvenue("Astra"), "Bienvenue, Astra ! Prêt pour le décollage ?");
Verifier("Exercice 2", () => Exercices.CalculerScore(12, 3), 270);
Verifier("Exercice 3 — 0", () => Exercices.Grade(0), "Cadet");
Verifier("Exercice 3 — 500", () => Exercices.Grade(500), "Pilote");
Verifier("Exercice 3 — 2000", () => Exercices.Grade(2000), "As");
Verifier("Exercice 3 — négatif", () =>
{
    try
    {
        Exercices.Grade(-1);
        return "pas d'exception";
    }
    catch (ArgumentOutOfRangeException)
    {
        return "ArgumentOutOfRangeException";
    }
}, "ArgumentOutOfRangeException");
Verifier("Exercice 4", () => Exercices.CompteARebours(3), "3… 2… 1… Décollage !");
Verifier("Exercice 5 — meilleur", () => Exercices.Statistiques(new List<int> { 120, 480, 300 }).Meilleur, 480);
Verifier("Exercice 5 — moyenne", () => Exercices.Statistiques(new List<int> { 120, 480, 300 }).Moyenne, 300.0);
Verifier("Exercice 5 — liste vide", () => Exercices.Statistiques(new List<int>()), (0, 0.0));
Verifier("Exercice 6", () =>
{
    var compte = Exercices.CompterParCategorie(new List<string> { "annonce", "mise_a_jour", "annonce" });
    return $"annonce={compte["annonce"]}, mise_a_jour={compte["mise_a_jour"]}";
}, "annonce=2, mise_a_jour=1");
Verifier("Exercice 7 — 42", () => Exercices.LireEntier("42"), 42);
Verifier("Exercice 7 — abc", () => Exercices.LireEntier("abc"), null);

Console.WriteLine($"\n{reussis}/{total} vérifications réussies.");
return reussis == total ? 0 : 1;
