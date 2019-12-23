using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooContent
{
    public interface IZooContentFactory<out T> where T: IZooContent
    {
        T Create();
    }
    public interface IZooContentFactory : IZooContentFactory<IZooContent>
    {
        new IZooContent Create();
    }
    interface IAnimalFactory<T> : IZooContentFactory<T> where T :IAnimal
    {
        T Father { get; set; }
        T Mother { get; set; }
        new T Create();
    }

    public class Population<T> where T: IAnimal, new()
    {
        public Population(List<T> instances) => Instances = instances;

        public List<T> Instances { get; set; } = new List<T>();
    }

    public class Selector<T> where T : IAnimal, new()
    {
        public Population<T> InitialPopulation { get; private set; }

        public Selector(Population<T> initialPopulation)
        {
            InitialPopulation = initialPopulation;
        }

        public void Init(Population<T> initialPopulation)
        {
            InitialPopulation = initialPopulation;
        }
        public Population<T> Selection()
        {
            Population<T> instances = new Population<T>(new List<T>());
            instances.Instances.Add(InitialPopulation.Instances.Where(i => i.Gender == GenderEnum.Female.ToString()).First());
            instances.Instances.Add(InitialPopulation.Instances.Where(i => i.Gender == GenderEnum.Male.ToString()).First());
            return instances;
        }
    }

    public class AnimalFactory<T> : IZooContentFactory<T> where T : IAnimal, new()
    {
        public Selector<T> Selector { get; set; }
        public AnimalFactory(Selector<T> selector)
        {
            Selector = selector;
        }

        public AnimalFactory()
        {
        }

        public T Create()
        {
            Population<T> instances = Selector?.Selection();
            if (instances != null)
            {
                T father = instances.Instances.First();
                T mother = instances.Instances.Last();
                return new T() { Name = father.Name, Nickname = $"{father.Nickname} - {mother.Nickname}" };
            }
            else
            {
                return default;
            }
        }
    }
}
