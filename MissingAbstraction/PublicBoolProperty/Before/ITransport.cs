namespace MissingAbstraction.PublicBoolProperty.Before
{
    public interface ITransport
    {
        //should we really use bool properties? what do they mean for CODE?
        bool CanFly { get; }
        void Move();
    }
}
