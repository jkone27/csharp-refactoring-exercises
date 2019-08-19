using System;

namespace WrongAbstraction.DryFailure.Before.Gen1
{
    public class SaltAndPepperService
    {
        //smart dev notices we are always adding, apart from topping everything else is the same,
        //but with a smart switch statement we can fix that! (haha)
        public void Add(IDish dish, WhatYouWantToAdd whatYouWantToAdd, Topping? optionalTopping = null)
        {
            switch (whatYouWantToAdd)
            {
                case WhatYouWantToAdd.Salt:
                    AddSalt(dish);
                    break;
                case WhatYouWantToAdd.Pepper:
                    AddPepper(dish);
                    break;
                case WhatYouWantToAdd.Topping:
                    if (!optionalTopping.HasValue)
                    {
                        throw new ArgumentNullException(nameof(optionalTopping));
                    }

                    AddTopping(dish, optionalTopping.Value);
                    break;
                default: break;
            }
        }

        private void AddSalt(IDish dish)
        {
            dish.Salt++;
            System.Console.WriteLine("we added salt!");
        }

        private void AddPepper(IDish dish)
        {
            dish.Pepper++;
            System.Console.WriteLine("we added salt!");
        }

        private void AddTopping(IDish dish, Topping topping)
        {
            dish.Topping = topping;
            System.Console.WriteLine($"we added {topping}!");
        }
    }
}
