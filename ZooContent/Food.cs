namespace Zoo
{
    public abstract class Food : IFood
    {
        protected Food(int calories, int minAgeLimit = 0, int maxAgeLimit = int.MaxValue)
        {
            Calories = calories;
            MinAgeLimit = minAgeLimit;
            MaxAgeLimit = maxAgeLimit;
        }

        public int Calories { get; set; }
        public int MinAgeLimit { get; set; }
        public int MaxAgeLimit { get; set; }
    }

    public class Wiskas : Food
    {
        public Wiskas(int calories) : base(calories)
        {
        }
    }
    public class Proplan : Food
    {
        public Proplan(int calories) : base(calories)
        {
        }
    }
}
