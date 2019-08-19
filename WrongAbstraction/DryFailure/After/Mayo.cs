namespace WrongAbstraction.DryFailure.After
{
    public class Mayo : ITopping, IExtraTopping
    {
        public INonNegativeQuantity Quantity => NonNegativeQuantity.Get(1);

        public INonNegativeQuantity Extra { get; }

        public Mayo()
        {
            Extra = NonNegativeQuantity.Get(0);
        }

        public Mayo(INonNegativeQuantity nonNegativeQuantity)
        {
            Extra = nonNegativeQuantity;
        }
    }

}

