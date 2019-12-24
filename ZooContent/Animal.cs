
namespace ZooContent
{
    public enum GenderEnum { Male = 0, Female = 1 }
    public enum ReproductionEnum { Parthenogenesis = 1, Genezis = 2 }

    /// <summary>
    /// Описывает любых животных в зоопарке
    /// </summary>
    [System.Serializable]
    public partial class Animal : IAnimal
    {
        partial void OnCreated()
        {
            Name = "";
            ContentType = "";
            From = "";
            Reproduction = ReproductionEnum.Genezis.ToString();
        }

        public override string ToString()
        {
            return $"{Name} из {From} стоимостью: {Cost}";
        }
    }
}
