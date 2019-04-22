using AbstractFactory_OCP;

namespace AbstractFactory_OCP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}