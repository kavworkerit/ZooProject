using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
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

    public class AnimalFactory<T> : IAnimalFactory<T> where T : IAnimal, new()
    {
        public AnimalFactory(T father = default, T mother = default)
        {
            Father = father;
            Mother = mother;
        }

        public T Father { get; set; }
        public T Mother { get; set; }

        public T Create()
        {
            return new T() {Name = Father.Name, Nickname = $"{Father.Nickname} - {Mother.Nickname}" };
        }
    }
}
