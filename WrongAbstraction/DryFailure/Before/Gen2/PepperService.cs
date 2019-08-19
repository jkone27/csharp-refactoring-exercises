namespace WrongAbstraction.DryFailure.Before
{
    public class PepperService : SaltAndPepperAndToppingService
    {
        public override string SpecificAddition => "salt";

        protected override void AddSpecific(IDish dish, Topping? optionalTopping = null)
        {
            dish.Pepper++;
        }
    }
}
