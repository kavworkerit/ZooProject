namespace Zoo
{
    public interface IAnimal: IZooContent
    {
        int Age { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
    }
}