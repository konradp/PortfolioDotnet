# Portfolio Website

A modern portfolio website built with ASP.NET Core Razor Pages, showcasing professional experience and projects in game development and .NET programming.

## About

This portfolio website meant to be one published as my main portfolio. However, as it quickly turned out, tech stack used was quite expensive to run on a Azure server, mainly because site was dynamically loading data from JSON, which racked up cost quickly. I abandoned it and rewrite it in Next.js 

## Features

- Mobile-friendly layout that works across all devices
- Dynamic project gallery with detailed descriptions and links
- Comprehensive list of programming languages and tools
- Direct links to GitHub and LinkedIn profiles
- Bootstrap-based design with cards and clean typography

## Tech Stack

- ASP.NET Core 9.0
- Razor Pages
- HTML5, CSS3, Bootstrap
- JSON-based project storage
- Ready for cloud deployment

## Deployment

### Local Development
```bash
dotnet run --environment Development
```

### Production Build
```bash
dotnet publish -c Release -o ./publish
```

### Docker (Optional)
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY ./publish .
ENTRYPOINT ["dotnet", "portfolio.dll"]
```

## License

BSD 3-Clause
