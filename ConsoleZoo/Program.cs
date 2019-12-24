using ConsoleZoo.Properties;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ZooContent;
using System.Deployment;
using ZooLinqDBTest;

namespace ConsoleZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            ZooDbDataContext dcZooDB = new ZooDbDataContext(Settings.Default.ZooDbConnectionString);
            if (dcZooDB.DatabaseExists()) { dcZooDB.DeleteDatabase(); }
            if (!dcZooDB.DatabaseExists())
            {
                dcZooDB.CreateDatabase();
            }

            //dcZooDBDataContext dcTestDb = new dcZooDBDataContext("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TestDb;Integrated Security=True");
            //if (dcTestDb.DatabaseExists()) { dcTestDb.DeleteDatabase(); }
            //if (!dcTestDb.DatabaseExists())
            //{
            //    dcTestDb.CreateDatabase();
            //}
            //var tblAChildSecond = dcTestDb.AContent;
            //AChildSecond second = new AChildSecond() { AType = "Second", Title = "Как то так", SecondGen = "Gen2" };
            //tblAChildSecond.InsertOnSubmit(second);
            //dcTestDb.SubmitChanges();


            Console.WriteLine("Создаем котиков...");

            List<Cat> cats = new List<Cat>()
            {
            };
            cats.Add( new Cat() { Nickname = "Пушок", Gender = GenderEnum.Male.ToString() } );
            cats.Add( new Cat() { Nickname = "Бусинка", Gender = GenderEnum.Female.ToString() } );

            cats.ForEach(cat => Console.WriteLine(cat));

            //List<IAnimal> vipcats = (from cat in cats where cat.Gender == GenderEnum.Female && cat.Nickname.Contains('М') select cat).ToList<IAnimal>();

            XmlSerializer xml = new XmlSerializer(cats.GetType());

            FileStream f = new FileStream("Cats.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            Console.WriteLine("Сохраняем котиков...");
            xml.Serialize(f, cats);
            f.Close();

            f = new FileStream("Cats.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Console.WriteLine("Загружаем котиков...");
            List<Cat> catsRead = xml.Deserialize(f) as List<Cat>;
            /*
            AnimalFactory<Cat> factoryCats = new AnimalFactory<Cat>(new Selector<Cat>(new Population<Cat>(catsRead)));
            catsRead.Add(factoryCats.Create());
            */
            catsRead.ForEach(cat => Console.WriteLine(cat));

            Console.WriteLine("Упаковываем котиков и отправляем на склад...");
            dcZooDB.Animal.InsertAllOnSubmit(catsRead);
            dcZooDB.SubmitChanges();

            Console.WriteLine("Проверяем качество упаковки котиков на складе...");
            var d = from c in dcZooDB.Animal where c is Cat select c;
            foreach (Cat cat in d)
            {
                Console.WriteLine(cat);
            }

            Console.ReadLine();

            Console.WriteLine("Создаем собачек...");
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog() { Nickname = "Полкан", Gender = GenderEnum.Male.ToString() });
            dogs.Add(new Dog() { Nickname = "Белка", Gender = GenderEnum.Female.ToString() });

            Console.WriteLine("Упаковываем собачек и отправляем на склад...");
            dcZooDB.Animal.InsertAllOnSubmit(dogs);
            dcZooDB.SubmitChanges();

            Console.WriteLine("Проверяем качество упаковки собачек на складе...");
            dogs.Clear();
            dogs = (from dog in dcZooDB.Animal where dog is Dog select dog as Dog).ToList();
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Console.ReadLine();

            Console.WriteLine("Проверяем качество упаковки Зверинца на складе...");
            List<IAnimal> animals;
            animals = (from animal in dcZooDB.Animal select animal as IAnimal).ToList();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();
        }

    }
}
