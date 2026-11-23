namespace Launcher;

public static class Ecran
{
    public static void Titre(string texte)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine(texte);
        Console.WriteLine(new string('═', texte.Length));
        Console.ResetColor();
    }

    private static void Ecrire(string texte, ConsoleColor couleur)
    {
        Console.ForegroundColor = couleur;
        Console.WriteLine(texte);
        Console.ResetColor();
    }

    public static void Succes(string texte) => Ecrire(texte, ConsoleColor.Green);
    public static void Erreur(string texte) => Ecrire("✗ " + texte, ConsoleColor.Red);
    public static void Info(string texte) => Ecrire(texte, ConsoleColor.DarkGray);

    public static string Demander(string question)
    {
        Console.Write($"{question} : ");
        return (Console.ReadLine() ?? "").Trim();
    }
}