using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppStarWars.Model
{
    public class Character
    {

        public string Name { get; set; }
        public string Side { get; set; }
        public string Imgsource { get; set; }

        public static async Task<ObservableCollection<Character>> GetCharacters()
        {
            ObservableCollection<Character> LsChars;
            LsChars = new ObservableCollection<Character>() {
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
           
            return LsChars;
        }
    }
}
