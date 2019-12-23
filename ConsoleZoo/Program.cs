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

namespace ConsoleZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooLinqDBTest.dcZooDBDataContext dcZooDB = new ZooLinqDBTest.dcZooDBDataContext();


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

            ZooDbDataContext zooDb = new ZooDbDataContext(Settings.Default.ZooDbConnectionString);

            Table<Cat> catsindb = zooDb.GetTable<Cat>();
            //List<Animal> animals = catsRead.Select(a => a as Animal).ToList();
            //zooDb.Animal.InsertOnSubmit(catsRead.First());
            catsindb.InsertAllOnSubmit(catsRead);
            zooDb.SubmitChanges();

            //catsRead.Select(c => catsindb.InsertAllOnSubmit(catsRead))
            var d = from c in catsindb select c;
            //zooDb.Animal.Select(a => a);

            Console.ReadLine();
        }

    }
}
