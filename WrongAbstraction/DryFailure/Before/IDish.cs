namespace WrongAbstraction.DryFailure.Before
{
    public interface IDish
    {
        int Salt { get; set; }
        int Pepper { get; set; }
        Topping Topping { get; set; }
        Topping ExtraTopping { get; set; }
        bool IsVipDish { get; set; }
    }
}