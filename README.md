[![Build](https://github.com/Vagab0nd/AniDB.Api/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/Vagab0nd/AniDB.Api/actions/workflows/build.yml)
![NuGet Version](https://img.shields.io/nuget/v/AniDb.Api)
<!--
![GitHub contributors from allcontributors.org](https://img.shields.io/github/all-contributors/Vagab0nd/AniDB.Api)
![GitHub forks](https://img.shields.io/github/forks/Vagab0nd/AniDB.Api) 
 -->
![GitHub Repo stars](https://img.shields.io/github/stars/Vagab0nd/AniDB.Api?style=flat&color=yellow)
![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/Vagab0nd/AniDB.Api)
![GitHub License](https://img.shields.io/github/license/Vagab0nd/AniDB.Api?color=blue)

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

## ⚖ License

This project is licensed under the GNU General Public License v3.0 (GPL-3.0) - see the [LICENSE](LICENSE) file for more details.
