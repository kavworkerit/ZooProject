
namespace ZooContent
{
    public enum GenderEnum { Male = 0, Female = 1 }
    public enum ReproductionEnum { Parthenogenesis = 1, Genezis = 2 }

    public partial class ZooAnimal : Animal
    {

    }

    /// <summary>
    /// Описывает любых животных в зоопарке
    /// </summary>
    [System.Serializable]
    public abstract partial class Animal : IAnimal
    {
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
