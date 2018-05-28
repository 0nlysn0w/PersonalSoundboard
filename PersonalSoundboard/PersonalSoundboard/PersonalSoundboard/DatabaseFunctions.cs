using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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

	public class DatabaseFunctions
    {
		private const string GroupUrl = "http://jooststam.com/soundboard/api.php/groups";
		public static string ContentUrl = "http://jooststam.com/soundboard/api.php/content";
		public static HttpClient _client;

		async public static void PostGroup(string Name)
		{
			_client = new HttpClient();
			var group = new Groups { Id = Helper.GenerateId(), Name = Name };


			var formContent = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("id", group.Id),
				new KeyValuePair<string, string>("name", group.Name),
			});

			await _client.PostAsync(GroupUrl, formContent);

		}
		async void AddContent(object sender, EventArgs e)
		{
			var content = new Content { Id = "qwerty456", Name = "adsfasdf1230", GroupId = "ytrewq00", TypeId = "1" };

			var formContent = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("id", content.Id),
				new KeyValuePair<string, string>("name", content.Name),
				new KeyValuePair<string, string>("group_id", content.GroupId),
				new KeyValuePair<string, string>("type_id", content.TypeId)
			});

			await _client.PostAsync(ContentUrl, formContent);

		}

	}
}
