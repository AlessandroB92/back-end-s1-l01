namespace back_end_s1_l01
{
    // Definizione della classe Atleta
    class Atleta
    {
        private string name;
        // Proprietà della classe Atleta
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string sport;
        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        // Metodo per stampare le informazioni dell'atleta
        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Name}, Età: {Age}, Sport: {Sport}");
        }
    }

    // Definizione della classe Dipendente
    class Dipendente
    {
        private string name; 
        // Proprietà della classe Dipendente
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Metodo per stampare le informazioni del dipendente
        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Name}, Mansione: {Role}, Stipendio: {Salary}");
        }
    }

    // Definizione della classe Animale
    class Animale
    {
        private string name;
        // Proprietà della classe Animale
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string species;
        public string Species
        {
            get { return species; }
            set { species = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Metodo per stampare le informazioni dell'animale
        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Name}, Specie: {Species}, Età: {Age}");
        }
    }

    // Definizione della classe Veicolo
    class Veicolo
    {
        private string brand;
        // Proprietà della classe Veicolo
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Metodo per stampare le informazioni del veicolo
        public void StampaInformazioni()
        {
            Console.WriteLine($"Marca: {Brand}, Modello: {Model}, Anno: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta { Name = "Mario Rossi", Age = 25, Sport = "Calcio" };
            Atleta atleta2 = new Atleta { Name = "Laura Bianchi", Age = 30, Sport = "Tennis" };

            Dipendente dipendente1 = new Dipendente { Name = "Giovanni Verdi", Role = "Programmatore", Salary = 3000 };
            Dipendente dipendente2 = new Dipendente { Name = "Anna Neri", Role = "Segretaria", Salary = 2000 };

            Animale animale1 = new Animale { Name = "Fido", Species = "Cane", Age = 5 };
            Animale animale2 = new Animale { Name = "Whiskers", Species = "Gatto", Age = 3 };

            Veicolo veicolo1 = new Veicolo { Brand = "Toyota", Model = "Corolla", Age = 2019 };
            Veicolo veicolo2 = new Veicolo { Brand = "Honda", Model = "Civic", Age = 2020 };

            // Stampare le informazioni di ogni oggetto
            Console.WriteLine("Informazioni degli atleti:");
            atleta1.StampaInformazioni();
            atleta2.StampaInformazioni();

            Console.WriteLine("\nInformazioni dei dipendenti:");
            dipendente1.StampaInformazioni();
            dipendente2.StampaInformazioni();

            Console.WriteLine("\nInformazioni degli animali:");
            animale1.StampaInformazioni();
            animale2.StampaInformazioni();

            Console.WriteLine("\nInformazioni dei veicoli:");
            veicolo1.StampaInformazioni();
            veicolo2.StampaInformazioni();

            Console.ReadLine();
        }
    }
}
