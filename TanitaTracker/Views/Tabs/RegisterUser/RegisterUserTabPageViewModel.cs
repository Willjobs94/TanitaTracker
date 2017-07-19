using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using TanitaTracker.BaseClasses;
using Prism.Commands;

namespace TanitaTracker.Views.Tabs
{
    public class RegisterUserTabPageViewModel : BaseViewModel
    {

        public RegisterUserTabPageViewModel()
        {
            CreateUserCommand = new DelegateCommand(CreateUser);

            Sexs = new List<string>{
                "Male",
                "Female",
                "Not Specified",
                "Other"
            };
            Height = new List<string>
            {
                 "5'0''",
                 "5'1''",
                 "5'2''",
                 "5'3''",
                 "5'4''",
                 "5'5''",
                 "5'6''",
                 "5'7''",
                 "5'8''",
                 "5'9''",
                 "5'10''",
                 "5'11''",
                 "5'12''",
                 "6'0''"
            };
        }


        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }


        public IEnumerable<string> Sexs
        {
            get => _sexs;
            set => SetProperty(ref _sexs, value);
        }

        public IEnumerable<string> Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }

        public DateTime Birthday
        {
            get => _birthday;
            set => SetProperty(ref _birthday, value);
        }

        public ICommand CreateUserCommand { get; set; }

        private async void CreateUser() {
            
        }

    private IEnumerable<string> _sexs;
		private IEnumerable<string> _height;
        private DateTime _birthday;
        private int _age;
        private string _name;

    }
}
