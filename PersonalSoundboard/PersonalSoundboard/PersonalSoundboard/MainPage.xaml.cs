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
	public class Content
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string GroupId { get; set; }
		public string TypeId { get; set; }
	}
	public class Groups
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
	public partial class MainPage : ContentPage
	{
		private const string GroupUrl = "http://jooststam.com/soundboard/api.php/groups";
		private const string ContentUrl = "http://jooststam.com/soundboard/api.php/content";
		private HttpClient _client = new HttpClient();
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
		async void AddGroup(object sender, EventArgs e)
		{
			var group = new Groups { Id = "qwerty456", Name = "adsfasdf1230" };

			var body = JsonConvert.SerializeObject(group);

			var formContent = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("id", group.Id),
				new KeyValuePair<string, string>("name", group.Name),
			});

			await _client.PostAsync(GroupUrl, formContent);

			//await _client.PostAsync(Url, new StringContent(body, Encoding.UTF8, "application/json"));
		}
		async void AddContent(object sender, EventArgs e)
		{
			var content = new Content { Id = "qwerty456", Name = "adsfasdf1230", GroupId = "ytrewq00", TypeId = "1" };

			var body = JsonConvert.SerializeObject(content);

			var formContent = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("id", content.Id),
				new KeyValuePair<string, string>("name", content.Name),
				new KeyValuePair<string, string>("group_id", content.GroupId),
				new KeyValuePair<string, string>("type_id", content.TypeId)
			});

			await _client.PostAsync(ContentUrl, formContent);

			//await _client.PostAsync(Url, new StringContent(body, Encoding.UTF8, "application/json"));
		}



		//await client.PostAsync(uri, content);
		//Something like that:

		//var comment = "hello world";
		//var questionId = 1;

		//var formContent = new FormUrlEncodedContent(new[]
		//{
		//    new KeyValuePair<string, string>("comment", comment), 
		//    new KeyValuePair<string, string>("questionId", questionId) 
		//});

		//var myHttpClient = new HttpClient();
		//var response = await myHttpClient.PostAsync(uri.ToString(), formContent);
		//And if you need to get the response after post, you should use:

		//var stringContent = await response.Content.ReadAsStringAsync();
	}
}
