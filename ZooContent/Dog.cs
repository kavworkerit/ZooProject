using System;


namespace Zoo
{
    /// <summary>
    /// Животное, Собака
    /// </summary>
    [System.Serializable]
    public class Dog : Animal
    {
        /// <summary>
        /// 
        /// </summary>
        public Dog()
        {
            Name = "Собака";
            Reproduction = ReproductionEnum.Genezis;
        }
        /// <summary>
        /// Издает Звук
        /// </summary>
        public override void Song()
        {
            Console.WriteLine("Гав.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, по кличке {Nickname}";
        }
    }
}
