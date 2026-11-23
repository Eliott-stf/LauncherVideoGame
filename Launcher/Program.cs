using Launcher;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Ecran.Titre("Comète — launcher");
Ecran.Info("Une information, en gris.");
Ecran.Succes("Un succès, en vert.");
Ecran.Erreur("Une erreur, en rouge.");

string pseudo = Ecran.Demander("Votre pseudo");
Ecran.Succes($"Bienvenue, {pseudo} !");