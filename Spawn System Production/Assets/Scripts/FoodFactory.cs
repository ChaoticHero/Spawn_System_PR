using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFoodFactory
{
    IFood Create(MagicRequirements requirements);
}

public class FastFoodFactory : IFoodFactory
{
    public IFood Create(MagicRequirements requirements)
    {
        if (requirements.Temp == 0)
        {
            if (requirements.processedFood == true) return new IceCream();
            if (requirements.processedFood == false) return new Muffin();
            else return new IceCream();
        }
        else
        {
            if (requirements.processedFood == true) return new FriedChicken();
            if (requirements.processedFood == false) return new HotDog();
            else return new FriedChicken();
        }
    }
}

public class HealthyFoodFactory : IFoodFactory
{
    public IFood Create(MagicRequirements requirements)
    {
        if (requirements.Temp == 0)
        {
            if (requirements.processedFood == true) return new Cheese();
            if (requirements.processedFood == false) return new WaterMelon();
            else return new IceCream();
        }
        else
        {
            if (requirements.processedFood == true) return new Chile();
            if (requirements.processedFood == false) return new Steak();
            else return new IceCream();
        }
    }
}

public class DrinksFactory : IFoodFactory
{
    public IFood Create(MagicRequirements requirements)
    {
        if (requirements.Temp == 0)
        {
            if (requirements.processedFood == true) return new Wine();
            if (requirements.processedFood == false) return new BlueDrink();
            else return new IceCream();
        }
        else
        {
            if (requirements.processedFood == true) return new RegularShowDrink();
            if (requirements.processedFood == false) return new GreenDrink();
            else return new IceCream();
        }
    }
}

public abstract class AbstractMagicFactory
{
    public abstract IFood Create();
}

//
public class FoodFactory : AbstractMagicFactory
{
    private readonly IFoodFactory _factory;
    private readonly MagicRequirements _requirements;

    public FoodFactory(MagicRequirements requirements)
    {
        if (requirements.Type == 0)
            _factory = (IFoodFactory)new FastFoodFactory();
        if (requirements.Type == 1)
            _factory = (IFoodFactory)new HealthyFoodFactory();
        else if (requirements.Type == 2)
            _factory = (IFoodFactory)new DrinksFactory();

        _requirements = requirements;
    }

    public override IFood Create()
    {
        return _factory.Create(_requirements);
    }

}