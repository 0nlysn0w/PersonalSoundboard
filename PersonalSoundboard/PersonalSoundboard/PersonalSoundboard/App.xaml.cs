using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PersonalSoundboard
{
	public partial class App : Application
	{

        public static Func<ISimpleAudioPlayer> CreateAudioPlayer { get; set; }
        //public static ISimpleAudioPlayer AudioPlayer { get; set; }

        public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
