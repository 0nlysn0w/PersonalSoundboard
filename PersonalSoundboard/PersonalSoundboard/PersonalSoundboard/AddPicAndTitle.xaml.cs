using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalSoundboard
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPicAndTitle : ContentPage
	{
		public AddPicAndTitle ()
		{
			InitializeComponent ();
		}
        private async void NavigateButton_OnReleased(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}