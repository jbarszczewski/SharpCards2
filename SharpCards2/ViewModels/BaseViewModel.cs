using CommunityToolkit.Mvvm.ComponentModel;

namespace SharpCards2.ViewModels {
	public partial class BaseViewModel : ObservableObject {
		[ObservableProperty]
		private bool isBusy;

		[ObservableProperty]
		private string title = string.Empty;
	}
}
