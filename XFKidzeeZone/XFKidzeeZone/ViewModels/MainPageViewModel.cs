using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFKidzeeZone.Models;
using XFKidzeeZone.Service;
using XFKidzeeZone.ViewModel;
using XFKidzeeZone.Views;

namespace XFKidzeeZone.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NavigateToDetailPageCommand = new Command<Game>(async (param) => await ExecuteNavigateToDetailPageCommand(param));
            GetGames();
            GetBestOfWeeks();
        }

        public Command NavigateToDetailPageCommand { get; }
        public ObservableCollection<Game> Games { get; set; }
        public ObservableCollection<BestOfWeek> BestOfWeeks { get; set; }

        void GetGames()
        {
            Games = new ObservableCollection<Game>(DataService.GetGames());
        }

        void GetBestOfWeeks()
        {
            BestOfWeeks = new ObservableCollection<BestOfWeek>(DataService.GetBestOfWeeks());
        }

        private async Task ExecuteNavigateToDetailPageCommand(Game param)
        {
            await Navigation.PushAsync(new DetailPage(param));
        }
    }
}
