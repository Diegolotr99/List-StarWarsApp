using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStarWars.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStarWars.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharacterDetails : ContentPage
	{
		public CharacterDetails ()
		{
			InitializeComponent ();
            BindingContext = CharacterViewModel.GetInstance();
        }
	}
}