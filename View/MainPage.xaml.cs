using MVVM_Aprendendo.ViewModels;

namespace MVVM_Aprendendo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new MainPageViewModel();
	}	
}

