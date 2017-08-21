using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamForms.Controls;

namespace HamburgerMenu.Views
{
    public partial class ViewA : ContentPage
    {
        Calendar calendar;
        public ViewA()
        {
            
            calendar = new Calendar
            {
                BorderColor = Color.Green,
                BorderWidth = 3,
                BackgroundColor = Color.Blue,
                StartDay = DayOfWeek.Sunday,
                StartDate = DateTime.Now
            };
            InitializeComponent();
        }
    }
}
