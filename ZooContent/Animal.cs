namespace Zoo
{
    /// <summary>
    /// Описывает любых животных в зоопарке
    /// </summary>
    public abstract class Animal : ZooContent, IAnimal
    {
        public Animal(string name, string from, float cost, int age, int height, int weight) : base(name, from, cost)
        {
            Age = age;
            Height = height;
            Weight = weight;
        }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
