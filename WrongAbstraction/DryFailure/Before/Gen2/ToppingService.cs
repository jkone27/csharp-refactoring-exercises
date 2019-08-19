using System;

namespace WrongAbstraction.DryFailure.Before
{
    public class ToppingService : SaltAndPepperAndToppingService
    {
        public override string SpecificAddition => "topping";

        protected override void AddSpecific(IDish dish, Topping? optionalTopping = null)
        {
            if (!optionalTopping.HasValue)
            {
                throw new ArgumentNullException(nameof(optionalTopping));
            }

            dish.Topping = optionalTopping.Value;
        }

        public virtual void AddExtraTopping(IDish dish, Topping topping)
        {
            dish.ExtraTopping = topping;
            Console.WriteLine("extra!");
        }
    }
}
