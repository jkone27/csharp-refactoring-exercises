namespace WrongAbstraction.DryFailure.After
{
    public class NonNegativeQuantity : INonNegativeQuantity
    {
        public int Quantity { get; }
        private NonNegativeQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public static INonNegativeQuantity Get(int quantity)
        {
            if (quantity < 0)
            {
                return new InvalidQuantity(quantity);
            }
            else
            {
                return new NonNegativeQuantity(quantity);
            }
        }
    }
}