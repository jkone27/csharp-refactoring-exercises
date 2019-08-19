namespace MissingAbstraction.PublicBoolProperty.Before
{

    public class Aeroplane : ITransport
    {
        public bool CanFly => true;
        public void Move() { }
    }
}
