namespace Todo
{
	public static class Constants
	{
		private static ApplicationSettings _applicationSettings = new ApplicationSettings();

		public static string AuthenticationTokenEndpoint => _applicationSettings.GetSetting("AuthenticationTokenEndpoint");

		public static string BingSpeechApiKey => _applicationSettings.GetSetting("BingSpeechApiKey");
		public static string SpeechRecognitionEndpoint => _applicationSettings.GetSetting("SpeechRecognitionEndpoint");
		public static string AudioContentType => _applicationSettings.GetSetting("AudioContentType");

		public static string BingSpellCheckApiKey => _applicationSettings.GetSetting("BingSpellCheckApiKey");
		public static string BingSpellCheckEndpoint => _applicationSettings.GetSetting("BingSpellCheckEndpoint");

		public static string TextTranslatorApiKey => _applicationSettings.GetSetting("TextTranslatorApiKey");
		public static string TextTranslatorEndpoint => _applicationSettings.GetSetting("TextTranslatorEndpoint");

		public static string EmotionApiKey => _applicationSettings.GetSetting("EmotionApiKey");

		public static string AudioFilename => _applicationSettings.GetSetting("AudioFilename");
	}
}
