namespace MissingAbstraction.CopyAndPaste.Before
{
    public class CookSandwitchService
    {
        private readonly IToastService toastService;

        public CookSandwitchService(IToastService toastService)
        {
            this.toastService = toastService;
        }

        public Sandwitch Cook()
        {
            var sandwitch = new Sandwitch();
            return toastService.Toast(sandwitch);
        }
    }


}
