using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStarWars.Model;
using AppStarWars.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStarWars.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Character> DataSource = new ObservableCollection<Character>();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = CharacterViewModel.GetInstance();
           


            
        }

        private void Button_Clicked_Light(object sender, EventArgs e)
        {



            // list.Where(character => character.Side == "Light Side" );


        }
        private void Button_Clicked_Dark(object sender, EventArgs e)
        {
          
               
            //list.Where(character => character.Side == "Dark Side");
               
            
        }
       
        private void Button_Clicked_Reset(object sender, EventArgs e)
        {
            //list.Where(character => character.Side == "Dark Side" && character.Side == "Light Side");
        }
        
    }
}