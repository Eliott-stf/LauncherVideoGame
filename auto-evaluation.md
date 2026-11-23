# Auto-évaluation

Deux usages, à deux moments :

1. **Un positionnement**, à remplir **avant le chapitre 00**, puis **à la fin**
   de la formation. Neuf compétences, notées de 0 à 3. La différence entre les
   deux colonnes mesure ce que vous avez réellement appris.
2. **Seize questions de contrôle**, à faire à la fin, ou à la fin de chaque
   chapitre concerné. Les réponses sont dépliables.

Ce document n'est ni un examen ni une note. Il n'est utile que s'il est
**honnête** : personne d'autre que vous ne le lira, sauf si vous choisissez de
le montrer.

---

## 1. Le positionnement

### L'échelle

| Note | Signification |
|:----:|---------------|
| **0** | Jamais fait |
| **1** | Avec de l'aide — en suivant un exemple pas à pas, ou en me faisant guider |
| **2** | Seul, avec la documentation — j'y arrive, en cherchant |
| **3** | Seul, et je saurais l'expliquer à quelqu'un d'autre |

La différence entre 2 et 3 est la plus importante. On croit souvent savoir
faire une chose qu'on ne saurait pas expliquer ; c'est le signe qu'on l'a
recopiée plus que comprise.

### Les neuf compétences

Recopiez ce tableau dans un fichier à vous, ou imprimez cette page. Remplissez
la colonne **Début** maintenant, **sans** lire les chapitres. Ne touchez pas à
la colonne **Fin** avant d'avoir terminé.

| # | Je sais… | Chapitre | Début | Fin |
|:-:|----------|:--------:|:-----:|:---:|
| 1 | Créer, compiler et lancer un programme C# en ligne de commande (`dotnet`). | 01 | 3 | |
| 2 | Utiliser variables, conditions, boucles et méthodes en C#. | 02 | 2.5 | |
| 3 | Écrire une classe avec propriétés, constructeur et méthodes. | 03 | 3 | |
| 4 | Lire un fichier JSON et le transformer en objet C#. | 03 | 3 | |
| 5 | Expliquer une requête HTTP : méthode, adresse, en-têtes, code de réponse. | 04 | 2 | |
| 6 | Appeler une API REST depuis C# avec `HttpClient`, `async` et `await`. | 05 | 2.6 | |
| 7 | Expliquer comment un jeton (JWT) prouve l'identité, et ce que protège la RLS. | 06 | 2.5 | |
| 8 | Télécharger un fichier, vérifier son empreinte SHA-256 et lancer un programme. | 07 | 2 | |
| 9 | Construire une fenêtre simple avec Avalonia (XAML, événements, liaison de données). | 08 | 1 | |
| | **Total (sur 27)** | | | |

> **L'item 9 relève du chapitre 08, facultatif.** Si vous vous arrêtez au
> palier 1, il restera probablement à 0 : c'est normal, et ce n'est pas un
> échec. Comparez alors vos totaux sur les **huit premiers items** (sur 24).

### Lire le résultat

À la fin, calculez **Fin − Début**.

| Progression | Ce qu'elle indique |
|-------------|--------------------|
| **+9 ou plus** | La progression visée par la formation : sur la plupart des items, vous avez progressé de « jamais fait » à « seul, avec la documentation » |
| **+5 à +8** | Une vraie progression, avec des points encore fragiles : repérez les items restés à 0 ou 1 |
| **moins de +5** | Soit vous partiez déjà de haut, soit des chapitres sont à reprendre. Regardez **quels** items n'ont pas bougé |

Un item qui reste à 1 à la fin désigne un chapitre à refaire, **sans** regarder
la solution cette fois. C'est la façon la plus sûre de le faire passer à 2.

---

## 2. Les questions de contrôle

Répondez **par écrit**, en une ou deux phrases, avant de déplier la réponse.
Une réponse formulée dans votre tête paraît toujours plus claire qu'elle ne
l'est.

**1.** *(chapitre 01)* Quelle est la différence entre `dotnet build` et
`dotnet run` ?

<details>
<summary><b>Réponse</b></summary>

`dotnet build` compile le projet et s'arrête : il produit les fichiers dans
`bin/`. `dotnet run` compile **puis** lance le programme. Pour vérifier qu'un
code compile sans l'exécuter, `dotnet build` suffit.

</details>

**2.** *(chapitre 02)* Que renvoie `int.TryParse("abc", out int n)`, et que vaut
`n` ensuite ? Pourquoi préfère-t-on `TryParse` à `int.Parse` pour une saisie ?

<details>
<summary><b>Réponse</b></summary>

`false`, et `n` vaut `0`. `int.Parse("abc")` lèverait une `FormatException`.
Une saisie humaine est souvent fausse : ce n'est pas une situation
exceptionnelle, on la **teste** avec `TryParse` plutôt que de la laisser
planter.

</details>

**3.** *(chapitre 03)* Pourquoi compare-t-on des numéros de version avec une
classe `NumeroVersion`, et non comme des chaînes de caractères ?

<details>
<summary><b>Réponse</b></summary>

En ordre alphabétique, `"1.10.0"` vient **avant** `"1.9.0"` (le caractère `1`
précède `9`). Or la 1.10 est plus récente. `NumeroVersion` compare les trois
nombres un par un, comme des nombres.

</details>

**4.** *(chapitre 03)* Votre programme affiche « Fichier de configuration
introuvable », alors que `config.json` est bien dans le dossier du projet.
Pourquoi ?

<details>
<summary><b>Réponse</b></summary>

Le programme s'exécute depuis `bin/Debug/net10.0/`, et cherche le fichier là.
Il faut que le `.csproj` demande de l'y recopier :
`<None Update="config.json" CopyToOutputDirectory="PreserveNewest" />`.

</details>

**5.** *(chapitre 04)* Quelles sont les quatre parties d'une requête HTTP, et
les deux d'une réponse ?

<details>
<summary><b>Réponse</b></summary>

Requête : une **méthode** (`GET`, `POST`…), une **adresse**, des **en-têtes**,
et parfois un **corps**. Réponse : un **code** (200, 401, 404…) et un **corps**
(souvent du JSON), plus ses propres en-têtes.

</details>

**6.** *(chapitre 04)* Que fait l'adresse
`rest/v1/actualites?select=*&order=publiee_le.desc&limit=3` ?

<details>
<summary><b>Réponse</b></summary>

Elle demande à PostgREST l'équivalent de
`SELECT * FROM actualites ORDER BY publiee_le DESC LIMIT 3` : les trois
actualités les plus récentes. La réponse est un tableau JSON.

</details>

**7.** *(chapitre 05)* Que fait `await`, exactement ? Le programme est-il
bloqué pendant ce temps ?

<details>
<summary><b>Réponse</b></summary>

`await` suspend la méthode jusqu'à ce que l'opération (ici, la réponse du
réseau) soit terminée, **sans bloquer le fil d'exécution** : il est rendu pour
faire autre chose, et la méthode reprend quand la réponse arrive. C'est ce qui
permet à une fenêtre de rester réactive pendant un téléchargement.

</details>

**8.** *(chapitre 05)* `JoueursEnLigne` vaut toujours 0, sans aucune erreur.
Quelle est la cause la plus probable ?

<details>
<summary><b>Réponse</b></summary>

Le serveur envoie `joueurs_en_ligne`, la propriété C# s'appelle
`JoueursEnLigne` : sans `JsonNamingPolicy.SnakeCaseLower`, les noms ne
correspondent pas. Le désérialiseur ne trouve rien à mettre dans la propriété,
qui garde sa valeur par défaut — sans signaler d'erreur.

</details>

**9.** *(chapitre 05)* Un code 404 provoque-t-il une exception dans
`HttpClient` ? Comment le launcher le traite-t-il ?

<details>
<summary><b>Réponse</b></summary>

Non : pour `HttpClient`, une réponse 404 est une réponse comme une autre. Il
faut tester `IsSuccessStatusCode`. Le launcher le fait dans
`ClientSupabase.VerifierAsync`, qui transforme tout code 4xx ou 5xx en
`ErreurApi`, avec le code et le message du serveur. Le menu l'attrape et
l'affiche.

</details>

**10.** *(chapitre 06)* La clé anon est dans le code de chaque launcher. Qu'est-ce
qui empêche alors un joueur de modifier le profil d'un autre ?

<details>
<summary><b>Réponse</b></summary>

Les règles **RLS** de la base, appliquées par le serveur : un utilisateur
connecté ne peut modifier que la ligne dont l'identifiant est le sien
(`id = auth.uid()`, lu dans **son** jeton). La clé anon dit seulement « quel
projet » ; elle ne protège rien.

</details>

**11.** *(chapitre 06)* Un `PATCH` sur le profil d'un autre joueur renvoie une
liste vide, sans erreur. Une lecture de `versions` sans être connecté renvoie
401. Pourquoi deux comportements différents ?

<details>
<summary><b>Réponse</b></summary>

Sans connexion, vous n'avez **aucun droit sur la table** `versions` : refus,
401. Connecté, vous avez le droit de modifier la table `profils`, mais la
règle RLS **filtre les lignes** : aucune ne correspond, donc aucune n'est
modifiée, et la liste renvoyée est vide. Une liste vide n'est donc pas
forcément un bogue de votre code.

</details>

**12.** *(chapitre 06)* Peut-on lire le contenu d'un JWT sans connaître la clé
du serveur ? Qu'en conclure ?

<details>
<summary><b>Réponse</b></summary>

Oui : sa partie centrale est du JSON encodé en base64, lisible par tous. Un JWT
est **signé**, pas **chiffré** : la signature empêche de le modifier, pas de le
lire. On n'y met donc jamais rien de secret.

</details>

**13.** *(chapitre 07)* Pourquoi télécharge-t-on le jeu « en flux », par
morceaux, plutôt que d'un seul bloc ?

<details>
<summary><b>Réponse</b></summary>

Un seul bloc chargerait tout le fichier en mémoire avant d'en écrire le premier
octet, et ne permettrait pas d'afficher une progression. En flux, on lit
80 Ko, on les écrit, on signale l'avancement, et on recommence : la mémoire
reste faible quelle que soit la taille du fichier.

</details>

**14.** *(chapitre 07)* L'empreinte calculée est
`3F9A…` et celle du serveur `3f9a…`. Le fichier est-il corrompu ?

<details>
<summary><b>Réponse</b></summary>

Pas forcément : `Convert.ToHexString` écrit en **majuscules**, la table en
minuscules. La comparaison échoue alors que le fichier est bon. Utilisez
`Convert.ToHexStringLower`. En revanche, un seul octet différent dans le
fichier change toute l'empreinte, pas seulement la casse.

</details>

**15.** *(chapitre 07)* Pourquoi le launcher décompresse-t-il la nouvelle version
dans un dossier à côté, avant de remplacer l'ancienne ?

<details>
<summary><b>Réponse</b></summary>

Pour qu'une erreur — archive corrompue, disque plein, coupure — ne laisse
jamais le joueur **sans jeu**. Tant que la nouvelle version n'est pas entièrement
prête, l'ancienne reste intacte. Le remplacement n'a lieu qu'à la toute fin.

</details>

**16.** *(chapitre 08, facultatif)* Pourquoi `async void` est-il admis pour
`Connecter_Click`, et nulle part ailleurs ?

<details>
<summary><b>Réponse</b></summary>

Un gestionnaire de clic a une signature imposée qui renvoie `void` : on ne peut
pas y renvoyer de `Task`. Mais une exception dans une méthode `async void` n'a
personne pour la recevoir et arrête l'application. D'où la règle : `async void`
seulement pour un gestionnaire d'événement, et toujours avec un `try`/`catch`
à l'intérieur (`Essayer(…)` dans le launcher).

</details>

---

**Retour :** [annexes](README.md) · [sommaire de la formation](../README.md)
