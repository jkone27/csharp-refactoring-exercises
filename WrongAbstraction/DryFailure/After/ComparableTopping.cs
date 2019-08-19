using System;

namespace WrongAbstraction.DryFailure.After
{
    public abstract class ComparableTopping : ITopping, IEquatable<ComparableTopping>
    {
        protected ComparableTopping(INonNegativeQuantity quantity)
        {
            Quantity = quantity;
        }

        public INonNegativeQuantity Quantity { get;}

        public bool Equals(ComparableTopping other)
        {
            return this.Quantity == other.Quantity;
        }
    }

}

