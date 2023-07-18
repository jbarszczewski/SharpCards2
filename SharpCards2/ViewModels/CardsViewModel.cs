using CommunityToolkit.Mvvm.Input;
using SharpCards2.Models;
using SharpCards2.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SharpCards2.ViewModels {
	public partial class CardsViewModel : BaseViewModel {
		private readonly ICardService cardService;

		public ObservableCollection<Card> Cards { get; } = new();

		public CardsViewModel(ICardService cardService) {
			Title = "Cards";
			this.cardService = cardService;
		}

		[RelayCommand]
		private async Task GetCards() {
			if (IsBusy) return;
			try {
				IsBusy = true;
				var cards = await cardService.GetItemsAsync();
				Cards.Clear();
				foreach (var card in cards) {
					Cards.Add(card);
				}
			} catch (Exception ex) {
				Debug.WriteLine(ex);
				await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
			} finally {
				IsBusy = false;
			}
		}
	}
}
