using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalSoundboard
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void Upload(object sender, EventArgs e)
		{
			WebClient client = new WebClient();

			client.UploadFile("http://jooststam.com/soundboard/upload.php", "POST", "./Aqua Muck.png");

		}
	}
}
