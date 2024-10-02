# C# Translate API
Discover the Power of Lingvanex C# free Translation API
Unlock the potential of your applications with Lingvanex Translator, a cutting-edge cloud-based neural machine translation service. It is compatible with any operating system, Lingvanex Translator enables the creation of intelligent, multi-lingual solutions for all supported languages.

With our .net Translation API, you can effortlessly translate both text and HTML pages, enhancing your global reach and communication capabilities. Explore the capabilities of the [Lingvanex Cloud API](https://lingvanex.com/en/translationapi/) and learn more about our [Secure On-Premise Machine Translation](https://lingvanex.com/).

# How to get the authentication key
Before using the translation API C# you need to create the [account](https://lingvanex.com/registration/) and then generate the API key at the bottom of the page. You must use this authorization key to authorize requests.

# Installation
You can install the library:

```
pip install lingvanex
```
# Getting the list of languages
To retrieve the list of languages, perform a GET request with the authentication key as follows:

```
const options = {method: 'GET', headers: {accept: 'application/json'}};

fetch('https://api-b2b.backenster.com/b1/api/v3/getLanguages?platform=api&code=en_GB', options)
  .then(response => response.json())
  .then(response => console.log(response))
  .catch(err => console.error(err));
```

Options:
* `url`: https://api-b2b.backenster.com/b1/api/v3/getLanguages
* `platform`: api
* `Authorization`: The key must be obtained in advance
* `code`: the language code in the format “language code_code of the country”, which is used to display the names of the languages. The language code is represented only in lowercase letters, the country code only in uppercase letters (example en_GB, es_ES, ru_RU etc). If this option is not present, then English is used by default.


# Translate
This POST method translates text and HTML single string or arrays with the authentication key. Also it performs transliteration, language auto detection.

```
const options = {
  method: 'POST',
  headers: {accept: 'application/json', 'content-type': 'application/json'},
  body: JSON.stringify({platform: 'api'})
};

fetch('https://api-b2b.backenster.com/b1/api/v3/translate', options)
  .then(response => response.json())
  .then(response => console.log(response))
  .catch(err => console.error(err));
```

Options:
* `url`: https://api-b2b.backenster.com/b1/api/v3/translate
* `platform`: api
* `Authorization`: The key must be obtained in advance
* `from`: the language code in the format “language code_code of the country” from which the text is translated. The language code is represented only in lowercase letters, the country code only in uppercase letters (example en_GB, es_ES, ru_RU and etc.). If this parameter is not present, the auto-detect language mode is enabled.
* `to`: language code in the format “language code_code of the country” to which the text is translated (required)
* `data`: data for translation.
* `translateMode`: Describe the input text format. Possible value is "html" for translating and preserving html structure. If the value is not specified or is other than "html" then plain text is translating.
* `enableTransliteration`: If true response includes sourceTransliteration and targetTransliteration fields.


# Issues
If you are having problems using the library, please [contact](https://lingvanex.com/en/contact-us/) us.
