using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Plugin.Calendar.Models;

namespace Server.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public EventCollection Events { get; set; }
        public DateTime selectedDate { get; set; }
        public DateTime maximumdDate { get; set; }
        public DateTime minimumdDate { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}