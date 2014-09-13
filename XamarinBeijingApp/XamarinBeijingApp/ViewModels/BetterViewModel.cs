using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinBeijingApp.ViewModels
{
    internal class BetterViewModel : INotifyPropertyChanged
    {
        private string _countText;
        private string _greeting;
        private bool _isBusy;

        public BetterViewModel()
        {
            IsBusy = false;
            Count = 0;
            CountText = "You have clicked " + Count + " times";
            Greeting = "you have not entered your name yet.";

            CountCommand = new Command(CountBy1);
            SayHelloCommand = new Command(SayHello);

            Animals = new ObservableCollection<Animal>
            {
                new Animal {Name = "Koala", Color = "Grey", Age = "1"},
                new Animal {Name = "Cat", Color = "Orange", Age = "5"},
                new Animal {Name = "Panda", Color = "Black", Age = "8"}
            };
        }

        public ObservableCollection<Animal> Animals { get; set; }
        public ICommand CountCommand { get; set; }
        public ICommand SayHelloCommand { get; set; }

        public int Count { get; set; }

        public string CountText
        {
            get { return _countText; }
            set
            {
                _countText = value;
                OnPropertyChanged("CountText");
            }
        }

        public string Name { get; set; }

        public string Greeting
        {
            get { return _greeting; }
            set
            {
                _greeting = value;
                OnPropertyChanged("Greeting");
            }
        }

        public bool NotIsBusy
        {
            get { return !IsBusy; }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("NotIsBusy");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void CountBy1()
        {
            // Start doing a lot of work
            // Show the Busy indicator
            IsBusy = true;

            await Task.Delay(3000); // sleep for 3 seconds
            Count++;
            CountText = "You have clicked " + Count + " times";

            // Busy indicator is turned off
            IsBusy = false;
        }

        public void SayHello()
        {
            Greeting = "Hello " + Name;
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Age { get; set; }
    }
}