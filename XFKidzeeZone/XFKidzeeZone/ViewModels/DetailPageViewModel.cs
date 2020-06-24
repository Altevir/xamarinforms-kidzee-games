using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFKidzeeZone.Models;
using XFKidzeeZone.ViewModel;

namespace XFKidzeeZone.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, Game game)
        {
            Navigation = navigation;
            PopDetailPageCommand = new Command(async () => await ExecutePopDetailPageCommand());
            Game = game;
        }

        public Command PopDetailPageCommand { get; }
        public Game Game { get; set; }

        private async Task ExecutePopDetailPageCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
