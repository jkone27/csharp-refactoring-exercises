using System.Collections.Generic;

namespace WrongAbstraction.DryFailure.After
{
    public interface IDish<T> where T : ITopping
    {
        void AddTopping(T topping);
    }
}

