namespace Zoo
{
    public interface IAnimal: IZooContent
    {
        int Age { get; set; }
        GenderEnum Gender { get; set; }
        int Height { get; set; }
        string Nickname { get; set; }
        ReproductionEnum Reproduction { get; set; }
        int Weight { get; set; }
    }
}