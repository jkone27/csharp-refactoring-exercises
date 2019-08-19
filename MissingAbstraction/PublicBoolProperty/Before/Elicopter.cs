namespace MissingAbstraction.PublicBoolProperty.Before
{
    public class Elicopter : ITransport
    {
        public bool CanFly => true;

        public void Move() { }
    }
}
