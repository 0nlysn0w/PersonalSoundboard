using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalSoundboard
{
	public partial class MainPage : ContentPage
	{

        ISimpleAudioPlayer[] players = new ISimpleAudioPlayer[1];
		public MainPage()
		{

            players[0] = PersonalSoundboard.App.CreateAudioPlayer();

            InitializeComponent();
            //Button button = new Button
            //{
            //    Text = "Navigate!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //button.Clicked += (s, e) => PlaySample();

            //Content = button;
            //LoadSamples();
            //PlaySample();
		}

        void LoadSamples()
        {
            players[0].Load(GetStreamFromFile("$Audio.biem.wav"));
        }

        void PlaySample()
        {
            players[0].Play();
        }

        Stream GetStreamFromFile(string fileName)
        {
            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PersonalSoundboard." + fileName);
            return stream;
        }
	}
}
