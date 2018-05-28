using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

		void Upload (object sender, EventArgs e)
		{

		}
		void AddGroup(object sender, EventArgs e)
		{
			DatabaseFunctions.PostGroup(groupname.Text);
		}

		//async void AddContent(object sender, EventArgs e)
		//{
		//	var content = new Content { Id = "qwerty456", Name = "adsfasdf1230", GroupId = "ytrewq00", TypeId = "1" };

		//	var body = JsonConvert.SerializeObject(content);

		//	var formContent = new FormUrlEncodedContent(new[]
		//	{
		//		new KeyValuePair<string, string>("id", content.Id),
		//		new KeyValuePair<string, string>("name", content.Name),
		//		new KeyValuePair<string, string>("group_id", content.GroupId),
		//		new KeyValuePair<string, string>("type_id", content.TypeId)
		//	});

		//	await _client.PostAsync(ContentUrl, formContent);

		//}



	}
}
