using Server.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Models;
using Server.Views;

namespace Server.ViewModels
{
    public class SimplePageViewModel : BasePageViewModel
    {
        public ICommand TodayCommand => new Command(() =>
        {
            Year = DateTime.Today.Year;
            Month = DateTime.Today.Month;
        });
        //call function when event clicked
        public ICommand EventSelectedCommand => new Command(async (item) => await ExecuteEventSelectedCommand(item));

        public SimplePageViewModel() : base()
        {
            // testing all kinds of adding events
            // when initializing collection
            Events = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                {
                    new EventModel { Name = "Nate", PhoneNumber = 123456 ,t_bookedTime = new DateTime(), d_paid = 1000, str_service = "massage", str_status = "closed"},
                    new EventModel { Name = "David",  PhoneNumber = 123456 , t_bookedTime = new DateTime(), d_paid = 200, str_service = "massage", str_status = "opened"}
                }
            };
        }
        //set date to today. You can change it
        public EventCollection Events { get; }

        private int _month = DateTime.Today.Month;

        public int Month
        {
            get => _month;
            set => SetProperty(ref _month, value);
        }

        private int _year = DateTime.Today.Year;

        public int Year
        {
            get => _year;
            set => SetProperty(ref _year, value);
        }

        private DateTime? _selectedDate = DateTime.Today;

        public DateTime? SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }
        // set minimumdate to 2019.4.29
        private DateTime _minimumDate = new DateTime(2019, 4, 29);

        public DateTime MinimumDate
        {
            get => _minimumDate;
            set => SetProperty(ref _minimumDate, value);
        }
        // set manximumdate to today+5months
        private DateTime _maximumDate = DateTime.Today.AddMonths(5);

        public DateTime MaximumDate
        {
            get => _maximumDate;
            set => SetProperty(ref _maximumDate, value);
        }

        private async Task ExecuteEventSelectedCommand(object item)
        {
            if (item is EventModel eventModel)
            {
                await App._NavigationPage.PushAsync(new DetailView(eventModel));
            }
        }
    }
}
