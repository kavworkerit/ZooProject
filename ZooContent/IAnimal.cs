namespace ZooContent
{
    public interface IAnimal: IZooContent
    {
        int Age { get; set; }
        string Gender { get; set; }
        int Height { get; set; }
        string Nickname { get; set; }
        string Reproduction { get; set; }
        int Weight { get; set; }
    }
}