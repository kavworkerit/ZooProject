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
            Console.WriteLine("Создаем котиков...");

            List<Cat> cats = new List<Cat>()
            {
                new Cat() { Nickname = "Мурка", Gender = GenderEnum.Female },
                new Cat() { Nickname = "Мурзик", Gender = GenderEnum.Male }
            };
            cats.Add( new Cat() { Nickname = "Пушок", Gender = GenderEnum.Male } );
            cats.Add( new Cat() { Nickname = "Бусинка", Gender = GenderEnum.Female } );

            cats.ForEach(cat => Console.WriteLine(cat));

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

            Console.ReadLine();
        }

    }
}
