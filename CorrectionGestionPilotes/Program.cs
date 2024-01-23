public class Pilote
{
    // Champs privés
    private int id;
    private string name;
    private string firstName;
    private string callSign;
    private string rank;
    private int flightTime;

    // Propriétés publiques
    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string CallSign { get => callSign; set => callSign = value; }
    public string Rank { get => rank; set => rank = value; }

    // Constructeurs
    public Pilote() { }

    public Pilote(int id, string name, string firstName)
    {
        this.id = id;
        this.name = name;
        this.firstName = firstName;
    }

    // Méthode privée qui calcule les nouvelles heures de vol au compteur du pilote.
    private int AddFlightTime(int addedFlightTime)
    {
        return flightTime += addedFlightTime;
    }

    // Méthode publique qui renseigne les champs callSign, rank et flightTime.
    public void EngagePilot(string callSign, string rank, int flightTime)
    {
        this.callSign = callSign;
        this.rank = rank;
        this.flightTime = flightTime;
    }

    // Méthode publique qui met à jour les heures du pilote à partir de la durée de la mission.
    public void MissionComeBack(int duration)
    {
        flightTime = AddFlightTime(duration);
    }

    public void DisplayPilot()
    {
        Console.WriteLine("{0} {1} {2} {3} {4} {5}", id, name, firstName, callSign, rank, flightTime.ToString());
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        //Saisie
        Console.WriteLine("Saisie Pilote:");
        Console.WriteLine("Saisir l'id du pilote");
        int idPilote = int.Parse(Console.ReadLine()??"");
        Console.WriteLine("Saisir le nom du pilote");
        string nomPilote = Console.ReadLine()??"Toto";
        Console.WriteLine("Saisir le prénom du pilote");
        string prenomPilote = Console.ReadLine()??"Tata";

        Pilote premierPilote = new Pilote(idPilote, nomPilote, prenomPilote);
        premierPilote.DisplayPilot();

        //Engagement
        Console.WriteLine("Saisir le callsign du pilote");
        string callSign = Console.ReadLine()??"Titi";
        Console.WriteLine("Saisir le grade");
        string grade = Console.ReadLine()??"Lieutenant";
        Console.WriteLine("Saisir les heures de vol du pilote");
        int heuresDeVol = int.Parse(Console.ReadLine() ?? "");

        premierPilote.EngagePilot(callSign, grade, heuresDeVol);

        premierPilote.DisplayPilot();


        Console.Read();

        


        
    }
}