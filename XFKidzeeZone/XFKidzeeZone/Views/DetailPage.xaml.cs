using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFKidzeeZone.Models;
using XFKidzeeZone.ViewModels;

namespace XFKidzeeZone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        const uint DURATION_ANIMATION_IMAGE = 350;
        const uint DURATION_ANIMATION = 550;

        public DetailPage(Game popular)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, popular);
            imageGame.TranslationX = -300;
            lbCompany.TranslationX = -350;
            lbName.TranslationX = -350;
        }

        protected override async void OnAppearing()
        {
            await imageGame.TranslateTo(-300, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.FadeTo(0.5, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.TranslateTo(-150, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.TranslateTo(0, 0, DURATION_ANIMATION_IMAGE, Easing.Linear);
            await imageGame.FadeTo(1, DURATION_ANIMATION_IMAGE, Easing.Linear);

            await Task.WhenAll(
              lbCompany.TranslateTo(-350, 0, DURATION_ANIMATION, Easing.Linear),
              lbCompany.TranslateTo(-175, 0, DURATION_ANIMATION, Easing.Linear),
              lbCompany.TranslateTo(0, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(-350, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(-175, 0, DURATION_ANIMATION, Easing.Linear),
              lbName.TranslateTo(0, 0, DURATION_ANIMATION, Easing.Linear)
          );
        }
    }
}