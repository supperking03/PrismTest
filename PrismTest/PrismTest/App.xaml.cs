using Prism.Navigation;
using Prism.Unity;
using PrismTest.Views;
using Xamarin.Forms;

namespace PrismTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            var navigationParameter = new NavigationParameters
            {
                {"message", "Hello"}
            };

            NavigationService.NavigateAsync("NavigationPage/MainPage", navigationParameter);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PageA>();
            ;
        }
    }
}
