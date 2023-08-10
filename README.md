# Agility CMS & .NET 5 Starter

To start using the Agility CMS & .NET 5 Starter, [sign up](https://agilitycms.com/free) for a FREE account and create a new Instance using the Blog Template.

[Introduction to .NET and Agility CMS](https://help.agilitycms.com/hc/en-us/articles/4404089239693)

## About This Starter

- Uses the latest version of .NET, with greatly improved performance across many components, Language improvements to C# and F#, and much more.
- Supports full [Page Management](https://help.agilitycms.com/hc/en-us/articles/360055805831)
- Supports Preview Mode
- Includes an easy-to-use CLI tool that helps you download the Content Models from your Agility CMS instance, and generates the classes of the Content Models for you.

### Tailwind CSS

This starter uses [Tailwind CSS](https://tailwindcss.com/), a simple and lightweight utility-first CSS framework packed with classes that can be composed to build any design, directly in your markup.

It also comes equipped with [Autoprefixer](https://www.npmjs.com/package/autoprefixer), a plugin which use the data based on current browser popularity and property support to apply CSS prefixes for you.

## Getting Started

🚨 Before you dive into the code, it's important that you have the latest version of the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine (>=v5.0), as the project will _not_ run without this.

### Generating/Syncing Content Models from your Agility Instance

1. cd into the `Agility.NET.AgilityCLI` directory.
2. Rename the `App.config.example` file to `App.config`.
3. Overwrite the values in the `App.config` file with the values from the API Keys page in [Agility Settings](https://manager.agilitycms.com/settings/apikeys).
4. Run `dotnet run update preview` to download the Content Models from your Agility CMS instance, and generate the classes of the Content Models for you.

### Setting up the Starter

1. cd into the `Agility.NET.Starter` directory.
2. Rename the `appsetting.json.example` file to `appsettings.json`.
3. Overwrite the values in the `appsettings.json` file with the credentials from the API Keys page in [Agility Settings](https://manager.agilitycms.com/settings/apikeys).

## Running the Site Locally

- `dotnet build` => Builds your .NET project.
- `dotnet run` => Builds & runs your .NET project.
- `dotnet clean` => Cleans the build outputs of your .NET project.

## How It Works

- [How Pages Work](https://help.agilitycms.com/hc/en-us/articles/4404222849677)
- [How Page Modules Work](https://help.agilitycms.com/hc/en-us/articles/4404222989453)
- [How Page Templates Work](https://help.agilitycms.com/hc/en-us/articles/4404229108877)

## Deploy to Azure Web App

1. Create an Web App (server) to host your application by clicking `Azure Deploy` button below: <br/>
   [![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fagility%2Fagilitycms-dotnet-starter%2Fmain%2FAgility.NET.Starter%2Fazuredeploy.json)

2. Deploy your source to Web App by following the steps here [How to Deploy .NET 5.0 Starter to Azure](https://help.agilitycms.com/hc/en-us/articles/4404691689229)

## Resources

### Agility CMS

- [Official site](https://agilitycms.com)
- [Documentation](https://help.agilitycms.com/hc/en-us)

### .NET 5

- [Official site](https://dotnet.microsoft.com/)
- [Documentation](https://docs.microsoft.com/en-us/dotnet/)

### Tailwind CSS

- [Official site](http://tailwindcss.com/)
- [Documentation](http://tailwindcss.com/docs)

### Community

- [Official Slack](https://join.slack.com/t/agilitycommunity/shared_invite/enQtNzI2NDc3MzU4Njc2LWI2OTNjZTI3ZGY1NWRiNTYzNmEyNmI0MGZlZTRkYzI3NmRjNzkxYmI5YTZjNTg2ZTk4NGUzNjg5NzY3OWViZGI)
- [Blog](https://agilitycms.com/resources/posts)
- [GitHub](https://github.com/agility)
- [Forums](https://help.agilitycms.com/hc/en-us/community/topics)
- [Facebook](https://www.facebook.com/AgilityCMS/)
- [Twitter](https://twitter.com/AgilityCMS)

## Feedback and Questions

If you have feedback or questions about this starter, please use the [Github Issues](https://github.com/agility/agilitycms-dotnet-starter/issues) on this repo, join our [Community Slack Channel](https://join.slack.com/t/agilitycommunity/shared_invite/enQtNzI2NDc3MzU4Njc2LWI2OTNjZTI3ZGY1NWRiNTYzNmEyNmI0MGZlZTRkYzI3NmRjNzkxYmI5YTZjNTg2ZTk4NGUzNjg5NzY3OWViZGI) or create a post on the [Agility Developer Community](https://help.agilitycms.com/hc/en-us/community/topics).
