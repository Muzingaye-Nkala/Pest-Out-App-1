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
    public partial class Pheromone_Shop : ContentPage
    {
        public Pheromone_Shop()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pherome_Traps());
        }

    }
}