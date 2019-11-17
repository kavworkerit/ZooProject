namespace Zoo
{
    public interface IEat<in T> where T : IFood
    {
        void Eat(T food);
    }


}
