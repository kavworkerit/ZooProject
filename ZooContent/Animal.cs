
namespace Zoo
{
    public enum GenderEnum { Male = 0, Female = 1 }
    public enum ReproductionEnum { Parthenogenesis = 1, Genezis = 2 }

    /// <summary>
    /// Описывает любых животных в зоопарке
    /// </summary>
    [System.Serializable]
    public abstract class Animal : ZooContent, IAnimal
    {
        public Animal() : this(name: "Животное", from: "", cost: 0)
        {
        }

        protected Animal(string name, string from, float cost) : base(name, from, cost)
        {
        }

        /// <summary>
        /// Кличка животного
        /// </summary>
        public string Nickname { get; set; } = "";
        /// <summary>
        /// Возраст дней
        /// </summary>
        public int Age { get; set; } = 0;
        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ReproductionEnum Reproduction { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
