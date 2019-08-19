namespace WrongAbstraction.DryFailure.After
{
    public class InvalidQuantity : INonNegativeQuantity
    {
        public int Quantity {get;}

        public InvalidQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}