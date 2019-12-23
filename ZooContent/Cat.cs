namespace ZooContent
{
    /// <summary>
    /// Животное, Кошка
    /// </summary>
    [System.Serializable]
    public partial class Cat : ZooAnimal
    {
        partial void OnCreated()
        {
            Name = "Кошка";
            Reproduction = ReproductionEnum.Genezis.ToString();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, по кличке {Nickname}";
        }
    }
}
