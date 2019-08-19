namespace WrongAbstraction.DryFailure.After
{
    public interface IExtraTopping : ITopping
    {
         INonNegativeQuantity Extra { get;}
    }
}