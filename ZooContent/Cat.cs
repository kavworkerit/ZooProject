namespace Zoo
{
    /// <summary>
    /// Животное, Кошка
    /// </summary>
    [System.Serializable]
    public class Cat : Animal
    {
        public Cat()
        {
            Name = "Кошка";
            Reproduction = ReproductionEnum.Genezis;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, по кличке {Nickname}";
        }
    }
}
