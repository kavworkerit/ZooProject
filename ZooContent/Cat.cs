namespace Zoo
{
    /// <summary>
    /// Животное, Кошка
    /// </summary>
    public class Cat : Animal
    {
        public Cat(string name, string from, float cost, int age, int height, int weight) : base(name, from, cost, age, height, weight)
        {
        }

        public override string ToString()
        {
            return $"Кошка {base.ToString()}";
        }
    }
}
