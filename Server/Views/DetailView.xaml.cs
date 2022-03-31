using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Server.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        public DetailView(EventModel eventModel)
        {
            InitializeComponent();
            this.Name.Text = eventModel.Name;
            this.PhoneNumber.Text = eventModel.PhoneNumber + "";
            this.Status.Text = eventModel.str_status;
            this.service.Text = eventModel.str_service;
            this.Paid.Text = eventModel.d_paid + "";
            this.Topay.Text = eventModel.d_topay + "";
            this.Time.Text = eventModel.t_bookedTime.TimeOfDay + "";
        }
    }
}