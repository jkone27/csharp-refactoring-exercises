namespace WrongAbstraction.DryFailure.After
{
    public class Pepper : ITopping
    {
        public INonNegativeQuantity Quantity { get; }

        public Pepper(INonNegativeQuantity positiveQuantity)
        {
            Quantity = positiveQuantity;
        }
    }

}

