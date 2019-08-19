using System;

namespace WrongAbstraction.DryFailure.Before.Gen3
{
    public class VipToppingService : ToppingService
    {
        public override string SpecificAddition => "extra rich topping";

        public override void AddExtraTopping(IDish dish, Topping topping)
        {
            Console.WriteLine("extra rich! for our VIPs. Chef says hello!");
            base.AddExtraTopping(dish, topping);
            dish.IsVipDish = true;
        }
    }
}
