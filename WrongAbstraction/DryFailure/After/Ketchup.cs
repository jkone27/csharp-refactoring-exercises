namespace WrongAbstraction.DryFailure.After
{
    public class Ketchup : ITopping, IExtraTopping
    {
        public INonNegativeQuantity Quantity => NonNegativeQuantity.Get(1);
        public INonNegativeQuantity Extra { get; }

        public Ketchup()
        {
            Extra = NonNegativeQuantity.Get(0);
        }

        public Ketchup(INonNegativeQuantity nonNegativeQuantity)
        {
            Extra = nonNegativeQuantity;
        }
    }

}

