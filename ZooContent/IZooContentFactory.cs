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
    public interface IIncubator<T>
    {
        T ParentFather { get; set; }
        T ParentMather { get; set; }
    }
    interface IAnimalFactory<T> : IZooContentFactory<T>, IIncubator<T> where T :IAnimal
    {

    }

    public class AnimalFactory<T> : IAnimalFactory<T> where T : IAnimal,new()
    {
        public AnimalFactory()
        {
        }

        public T ParentFather { get; set; }
        public T ParentMather { get; set; }

        public T Create()
        {
            return new T();
        }
    }
}
