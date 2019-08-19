namespace WrongAbstraction.DryFailure.After
{
    public class Salt : ITopping
    {
        public INonNegativeQuantity Quantity { get; }

        public Salt(INonNegativeQuantity positiveQuantity)
        {
            Quantity = positiveQuantity;
        }
    }

}

