<div align="center">

![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/Vagab0nd/AniDB.Api/build.yml)
![NuGet Version](https://img.shields.io/nuget/v/AniDb.Api)
![GitHub Repo stars](https://img.shields.io/github/stars/Vagab0nd/AniDB.Api?style=flat&color=yellow)
![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/Vagab0nd/AniDB.Api)
![GitHub License](https://img.shields.io/github/license/Vagab0nd/AniDB.Api?color=blue)
<!--
![GitHub contributors from allcontributors.org](https://img.shields.io/github/all-contributors/Vagab0nd/AniDB.Api)
![GitHub forks](https://img.shields.io/github/forks/Vagab0nd/AniDB.Api) 
 -->

</div>

<br />
<div align="center">
  <a href="https://github.com/Vagab0nd/AniDB.Api">
    <img src="Images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h2 align="center">AniDB.Api</h3>

  <p align="center">
    .Net library that provides wrapper for AniDB API!
  </p>
</div>

## 📥 Getting Started

### Install

Download and install library from NuGet Gallery:
```
dotnet add package AniDb.Api
```

or install separately nugets for either Http or Udp API:

```
dotnet add package AniDb.Api.Http
dotnet add package AniDb.Api.Udp
```

### Usage examples

#### GetAnime

```csharp
IAniDbHttpApi api = new AniDbHttpApi();

// Pass AniDB anime id.
Response<Anime> anime = await this.api.GetAnime(17709);
```

#### GetUserHints

```csharp
IAniDbHttpApi api = new AniDbHttpApi();

// Pass AniDB username and password.
// This is main password, not the API password specified in the profile.
// Library doesn't store this data.
Response<HintCollection> userHints = await this.api.GetUserHints("MyUsername", "MyPassword");
```

#### GetAnimeTitles

```csharp
IAniDbAnimeTitles animeTitlesDump = new AniDbAnimeTitles();

// Note: Remember to cache results! 
// Best strategy would be to call this method only from wrapper class
// that implements pernament (not in memory) caching.
AnimeTitlesCollection animeTitles = await this.animeTitlesDump.GetAnimeTitles();
```

### Caching

All users of this API should employ heavy local caching. 
In case of data dumps (Anime titles) requesting the same dataset multiple times on a single day can get you banned. 
The same goes for Http API request flooding. You should not request more than one page every two seconds.

## ☂️ Coverage

Coverage as of right now is:
 - [HTTP API](https://wiki.anidb.net/HTTP_API_Definition)
 - [Titles dump](https://wiki.anidb.net/API#Anime_Titles)

## 📝 Roadmap

- Implement UDP API.
- Use ISO 639 language codes.
- Add more comprehensive integration tests that check data mapping/validity
- Use `DateOnly` in models when migrating to .Net7 or higher - support for `DateOnly` conversion to/from XML.
- Use `required` keyword instead of null collapse in DTOs when migrating to .Net7 or higher.

## ➕ Contributing

See [Contributing doc](CONTRIBUTING.md).

## ⚖ License

This project is licensed under the GNU General Public License v3.0 (GPL-3.0) - see the [LICENSE](LICENSE) file for more details.
