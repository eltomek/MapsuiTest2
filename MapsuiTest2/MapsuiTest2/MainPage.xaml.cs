using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapsuiTest2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void OnRouteIconTapped(object s, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }

    }
}
