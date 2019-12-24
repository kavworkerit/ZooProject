using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooContent
{

    [System.Serializable]
    public partial class Dog : Animal
    {
        partial void OnCreated()
        {
            Name = "Собака";
            ContentType = "Dog";
            Song = "Гав";
            Reproduction = ReproductionEnum.Genezis.ToString();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, по кличке {Nickname}";
        }
    }
}
