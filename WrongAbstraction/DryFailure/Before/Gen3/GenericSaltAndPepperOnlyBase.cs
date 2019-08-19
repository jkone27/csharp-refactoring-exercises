namespace WrongAbstraction.DryFailure.Before.Gen3
{
    public abstract class GenericSaltAndPepperOnlyBase : SaltAndPepperAndToppingService
    {
        protected override void AddSpecific(IDish dish, Topping? optionalTopping = null)
        {
            ReallyAdd(dish);
        }

        protected abstract void ReallyAdd(IDish toBeAdded);
    }
}
