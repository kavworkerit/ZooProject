﻿namespace ZooContent
{
    /// <summary>
    /// Животное, Кошка
    /// </summary>
    [System.Serializable]
    public partial class Cat : Animal
    {
        partial void OnCreated()
        {
            Name = "Кошка";
            ContentType = "Cat";
            Song = "Мяу";
            Reproduction = ReproductionEnum.Genezis.ToString();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, по кличке {Nickname}";
        }
    }
}
