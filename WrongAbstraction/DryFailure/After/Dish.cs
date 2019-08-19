using System.Collections.Generic;

namespace WrongAbstraction.DryFailure.After
{
    public class Dish : IDish<ITopping>
    {
        public Dish()
        {
            toppings = new HashSet<ITopping>();
        }

        private readonly HashSet<ITopping> toppings;

        public void AddTopping(ITopping topping)
        {
            toppings.Add(topping);
        }

        public void AddExtraTopping(IExtraTopping topping)
        {
            toppings.Add(topping);
        }
    }

}

