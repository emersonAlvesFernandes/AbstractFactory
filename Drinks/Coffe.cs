using System;

namespace AbstractFactory_OCP
{
    public class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is delicious!");
        }
    }

}