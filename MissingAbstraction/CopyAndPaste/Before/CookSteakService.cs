using System;
using System.Collections.Generic;
using System.Text;

namespace MissingAbstraction.CopyAndPaste.Before
{
    public class CookSteakService
    {
        private readonly IGrillService grillService;

        public CookSteakService(IGrillService grillService)
        {
            this.grillService = grillService;
        }
        public Steak Cook()
        {
            return new Steak();
        }
    }
}
