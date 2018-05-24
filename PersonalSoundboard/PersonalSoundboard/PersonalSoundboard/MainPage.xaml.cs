﻿using System;
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
        private async void NavigateButton_OnReleased(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordSound());
        }
	}
}
