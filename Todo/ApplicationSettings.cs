using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Todo
{
	public class ApplicationSettings
	{
		private dynamic _settings { get; set; }

		public ApplicationSettings()
		{
			var assembly = typeof(ApplicationSettings).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("Todo.appSettings.json");

			string settings;
			using (var streamReader = new StreamReader(stream))
			{
				settings = streamReader.ReadToEnd();
			}
			_settings = JsonConvert.DeserializeObject(settings);
		}
		public string GetSetting(string settingName)
		{
			var value = _settings[settingName].ToString();
			return value;
		}
	}
}
