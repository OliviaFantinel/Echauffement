namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour, je suis Olivia Fantinel.\nJe suis une grande fan de Slay the Spire.");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Comment vous appelez-vous?");
        string name = Console.ReadLine();
        Console.WriteLine("Quel est votre âge?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        Console.WriteLine("Tu es " + (age < 18 ? "mineur." : "majeur."));
        
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros a tu sur toi?");
        float money = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine(
            "Écoute " + name + ", c'est la crise. Les prix des jeux vidéos ont explosés. Je me suis donc reconvertie dans le recel d'armes digitales.\n" +
            "Laquelle de ces armes pourrait t'intéresser? Écris le nombre de l'arme qui t'intéresse.\n" +
            "1. Un pistolet à eau tiède;\n" +
            "2. Un gratouilleur de dos;\n" +
            "3. Une lampe torche et une loupe;\n" +
            "4. Un vrai flingue avec de vraies balles.\n"
            );
        

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}