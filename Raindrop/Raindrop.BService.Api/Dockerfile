#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Raindrop.BService.Api/Raindrop.BService.Api.csproj", "Raindrop.BService.Api/"]
COPY ["Raindrop.AService.ApiClient/Raindrop.AService.ApiClient.csproj", "Raindrop.AService.ApiClient/"]
RUN dotnet restore "Raindrop.BService.Api/Raindrop.BService.Api.csproj"
COPY . .
WORKDIR "/src/Raindrop.BService.Api"
RUN dotnet build "Raindrop.BService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Raindrop.BService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Raindrop.BService.Api.dll"]