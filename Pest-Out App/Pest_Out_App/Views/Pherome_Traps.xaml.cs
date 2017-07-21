using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pest_Out_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pherome_Traps : ContentPage
    {
        public Pherome_Traps()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pheromone_Shop());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPicture());
        }

    }
}