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
	public partial class RecordSound : ContentPage
	{
		public RecordSound ()
		{
			InitializeComponent ();
		}
        private async void NavigateButton_OnReleased(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPicAndTitle());
        }
    }
}