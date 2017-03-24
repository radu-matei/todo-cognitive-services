ToDo Cognitive Services
=======================

This sample demonstrates how to use some of the Microsoft Cognitive Services APIs in a Xamarin.Forms application. 

In order to build the application, you need to add a JSON file called `appSettings.json` in the `Todo` folder where you need to add the Cognitive Services API keys:

```
{
	"AuthenticationTokenEndpoint": "https://api.cognitive.microsoft.com/sts/v1.0",
    "BingSpeechApiKey": "<INSERT_API_KEY_HERE>",
    "SpeechRecognitionEndpoint": "https://speech.platform.bing.com/recognize",
    "AudioContentType": "audio\/wav; codec=\"\"audio\/pcm\"\"; samplerate=16000",
    "BingSpellCheckApiKey": "<INSERT_API_KEY_HERE>",
    "BingSpellCheckEndpoint": "https://api.cognitive.microsoft.com/bing/v5.0/spellcheck/",
    "TextTranslatorApiKey": "<INSERT_API_KEY_HERE>",
    "TextTranslatorEndpoint": "https://api.microsofttranslator.com/v2/http.svc/Translate",
    "EmotionApiKey": "<INSERT_API_KEY_HERE>",
    "AudioFilename": "Todo.wav"
}
```

