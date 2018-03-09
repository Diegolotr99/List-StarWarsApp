using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStarWars.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStarWars.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        List<Character> DataSource = new List<Character>();

        public MainPage()
        {
            InitializeComponent();
            //lst.ItemsSource = new List<string>() { "item 1", "item 2", "Item 3" };
            lst.ItemsSource = new List<Character>() {
               new Character() {Name = "BB-8", Side="Light Side",  Imgsource = "http://image.ibb.co/dJkxhn/bb8.png",},
               new Character() {Name = "Luke Skywalker", Side="Light Side", Imgsource = "http://image.ibb.co/kwNchn/if_luke_skywalker_1626628.png", },
               new Character() {Name = "Old Ben Kenobi", Side="Light Side", Imgsource = "http://image.ibb.co/bzKONn/if_obiwan_kenobi_1626629.png",},
               new Character() {Name = "R2-D2", Side="Light Side",Imgsource = "http://image.ibb.co/djbv2n/r2d2.png",},
               new Character() {Name = "C3P0", Side="Light Side", Imgsource = "http://image.ibb.co/dCg68S/c3p0.png",},
               new Character() {Name = "Princess Leia", Side="Light Side", Imgsource = "http://image.ibb.co/cYXA2n/if_princess_leia_1626630.png",},
               new Character() {Name = "Han Solo", Side="Light Side", Imgsource = "http://image.ibb.co/erntNn/if_han_solo_1626619.png",},
               new Character() {Name = "Chewbacca", Side="Light Side", Imgsource = "http://image.ibb.co/iNdshn/chewbacca.png",},
               new Character() {Name = "Lando Calrissian", Side="Light Side", Imgsource = "http://image.ibb.co/eJnGa7/if_lando_calrissian_1626623.png",},
               new Character() {Name = "Boba Fett", Side="Dark Side", Imgsource = "http://image.ibb.co/eY86a7/if_boba_fett_1626610.png",},
               new Character() {Name = "Jango Fett", Side="Dark Side", Imgsource = "http://image.ibb.co/nw8iNn/jango_fett.png",},
               new Character() {Name = "Emperor Palpatine", Side="Dark Side", Imgsource = "http://image.ibb.co/jhNGa7/emperor_palpatine.png",},
               new Character() {Name = "Darth Vader", Side="Dark Side", Imgsource = "http://image.ibb.co/mX7zv7/if_darth_vader_1626615.png",},
               new Character() {Name = "Darth Maul", Side="Dark Side", Imgsource = "http://image.ibb.co/kDQma7/if_darth_maul_1626614.png",}

            };


            DataSource = lst.ItemsSource as List<Character>;
        }

        private void Button_Clicked_Light(object sender, EventArgs e)
        {
            Clear();
            List<Character> list = lst.ItemsSource as List<Character>;
            if (list != null)
            {
                
                var result = list.Where(character => character.Side == "Light Side" );
                lst.ItemsSource = result;
            }
        }
        private void Button_Clicked_Dark(object sender, EventArgs e)
        {
            Clear();
            List<Character> list = lst.ItemsSource as List<Character>;
            if (list != null)
            {
               
                var result = list.Where(character => character.Side == "Dark Side");
                lst.ItemsSource = result;
            }
        }
       
        private void Button_Clicked_Reset(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {

            if (DataSource != null)
            {

                lst.ItemsSource = DataSource;
            }

        }
    }
}