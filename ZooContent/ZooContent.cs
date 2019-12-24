using System;
using System.Collections.Generic;

namespace ZooContent
{
    /// <summary>
    /// Описывает Любое имущество Зоопарка
    /// </summary>
    public abstract class ZooContent : IZooContent
    {
        protected ZooContent()
        {
        }

        public abstract float Cost { get; set; }
        public abstract string From { get; set; }
        public abstract string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ZooContent content &&
                   Name == content.Name &&
                   From == content.From &&
                   Cost == content.Cost;
        }

        public override int GetHashCode()
        {
            var hashCode = -1231080549;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Name} из {From} стоимостью: {Cost}";
        }
    }
}
