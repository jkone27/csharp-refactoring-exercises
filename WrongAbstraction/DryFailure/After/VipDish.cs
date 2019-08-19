namespace WrongAbstraction.DryFailure.After
{
    public class VipDish : IDish<IExtraTopping>
    {
        private readonly Dish dish;

        public VipDish(Dish dish)
        {
            this.dish = dish;
        }

        public void AddTopping(IExtraTopping topping)
        {
            dish.AddTopping(topping);
            dish.AddExtraTopping(topping);
        }
    }

}

