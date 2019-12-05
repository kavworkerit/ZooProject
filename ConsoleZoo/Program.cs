using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Zoo;

namespace ConsoleZoo
{
    class Program
    {
        static void Main(string[] args)
        {

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ZooSQlite.db");

            var db = new SQLiteConnection(databasePath);

            db.CreateTable<Cat>();
            //db.CreateTable<Valuation>();

            Console.WriteLine("Создаем котиков...");

            List<Cat> cats = new List<Cat>()
            {
                new Cat() { Nickname = "Мурка", Gender = GenderEnum.Female },
                new Cat() { Nickname = "Мурзик", Gender = GenderEnum.Male }
            };
            cats.Add( new Cat() { Nickname = "Пушок", Gender = GenderEnum.Male } );
            cats.Add( new Cat() { Nickname = "Бусинка", Gender = GenderEnum.Female } );

            cats.ForEach(cat => Console.WriteLine(cat));

            List<IAnimal> vipcats = (from cat in cats where cat.Gender == GenderEnum.Female && cat.Nickname.Contains('М') select cat).ToList<IAnimal>();

            XmlSerializer xml = new XmlSerializer(cats.GetType());

            FileStream f = new FileStream("Cats.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            Console.WriteLine("Сохраняем котиков...");
            xml.Serialize(f, cats);
            f.Close();

            f = new FileStream("Cats.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Console.WriteLine("Загружаем котиков...");
            List<Cat> catsRead = xml.Deserialize(f) as List<Cat>;

            AnimalFactory<Cat> factoryCats = new AnimalFactory<Cat>(new Selector<Cat>(new Population<Cat>(catsRead)));
            catsRead.Add(factoryCats.Create());

            catsRead.ForEach(cat => Console.WriteLine(cat));

            Console.WriteLine("Создаем собачек...");

            List<Dog> dogs = new List<Dog>()
            {
                new Dog() { Nickname = "Дружок", Gender = GenderEnum.Female },
                new Dog() { Nickname = "Шарик", Gender = GenderEnum.Male }
            };
            dogs.Add(new Dog() { Nickname = "Тритон", Gender = GenderEnum.Male });
            dogs.Add(new Dog() { Nickname = "Гена", Gender = GenderEnum.Female });

            //dogs.ForEach(dog => Console.WriteLine(dog));
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"{ dog }");
                dog.Song();
                //zooContents.Add((dog as IZooContent));
            }

            f = new FileStream("Dogs.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            Console.WriteLine("Сохраняем собачек...");
            xml.Serialize(f, dogs);
            f.Close();

            f = new FileStream("Dogs.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Console.WriteLine("Загружаем собачек...");
            List<Dog> dogsRead = xml.Deserialize(f) as List<Dog>;

            Console.ReadLine();
        }

    }
}
