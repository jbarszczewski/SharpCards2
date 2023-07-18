using SharpCards2.ViewModels;

namespace SharpCards2.Views {
	public partial class CardsPage : ContentPage {
		
		public CardsPage(CardsViewModel viewModel) {
			InitializeComponent();
			BindingContext = viewModel;
		}
	}
}