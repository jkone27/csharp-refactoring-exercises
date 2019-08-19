namespace WrongAbstraction.DryFailure.Before.Gen3
{
    public class PepperService : GenericSaltAndPepperOnlyBase
    {
        public override string SpecificAddition => "salt";

        protected override void ReallyAdd(IDish toBeAdded)
        {
            toBeAdded.Pepper++;
        }
    }
}
