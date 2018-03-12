using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.ObjectModel;
using AppStarWars.Model;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using AppStarWars.View;

namespace AppStarWars.ViewModel
{
    public class CharacterViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static CharacterViewModel instance = null;

        private CharacterViewModel()
        {
            InitClass();
            InitCommands();
        }

        public static CharacterViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new CharacterViewModel();
            }
            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion
        #region Instances
        private List<Character> InitialListCharacters = new List<Character>();
        private ObservableCollection<Character> _LstCharacters = new ObservableCollection<Character>();
        public ObservableCollection<Character> LstCharacters
        {
            get
            {
                return _LstCharacters;
            }

            set
            {
                _LstCharacters = value;
                OnPropertyChanged("LstCharacters");

            }

        }
        private string _SearchText = string.Empty;

        public string SearchText
        {
            get
            {
                return _SearchText;
            }
            set
            {
                _SearchText = value;
                OnPropertyChanged("SearchText");
                FilterCharacter(_SearchText);
            }
        }
        private Character _ActualCharacter { get; set; }

        public Character ActualCharacter
        {
            get
            {
                return _ActualCharacter;
            }
            set
            {
                _ActualCharacter = value;
                OnPropertyChanged("ActualCharacter");
            }
        }
        public ICommand FilterByLightSideCommand { get; set; }
        public ICommand FilterByDarkSideCommand { get; set; }
        public ICommand SeeCharacterCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        #endregion
      
        #region Methods
        private void InitCommands()
        {
            FilterByLightSideCommand = new Command(FilterByLightSide);
            FilterByDarkSideCommand = new Command(FilterByDarkSide);
            ClearCommand = new Command(ClearList);
            SeeCharacterCommand = new Command<string>(SeeCharacter);
        }

        #endregion
       
        private async void InitClass()
        {

            LstCharacters = await Character.GetCharacters();
            InitialListCharacters = LstCharacters.ToList();
        }
      

        #region Actions
        private void FilterCharacter(string pSearchText)
        {
            LstCharacters.Clear();
            InitialListCharacters.Where(x => x.Name.ToLower().Contains(pSearchText.ToLower())).ToList().ForEach(x => LstCharacters.Add(x));

        }
        private void FilterByLightSide()
        {
            LstCharacters.Clear();
            string pSide = "Light Side";
            InitialListCharacters.Where(x => x.Side.ToLower().Contains(pSide.ToLower())).ToList().ForEach(x => LstCharacters.Add(x));

        }
        private void FilterByDarkSide()
        {
            LstCharacters.Clear();
            string pSide = "Dark Side";
            InitialListCharacters.Where(x => x.Side.ToLower().Contains(pSide.ToLower())).ToList().ForEach(x => LstCharacters.Add(x));
           
        }
        private void SeeCharacter(string pName)
        {
           
           ActualCharacter = InitialListCharacters.Where(x => x.Name == pName).FirstOrDefault();
            
           ContentPage cd = new CharacterDetails();
           App.Current.MainPage.Navigation.PushAsync(cd);
           
            

        }

        private void ClearList() {
            LstCharacters.Clear();
            LstCharacters=new ObservableCollection<Character>(InitialListCharacters);
            SearchText = "";
        }
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
