using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamDay.ViewModels;

namespace XamDay.Pages
{
    public partial class PersonalEventsPage : ContentPage
    {
        public PersonalEventsPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
