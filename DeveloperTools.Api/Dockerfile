FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY DeveloperTools.Api/DeveloperTools.Api.csproj DeveloperTools.Api/
RUN dotnet restore DeveloperTools.Api/DeveloperTools.Api.csproj
COPY . .
WORKDIR /src/DeveloperTools.Api
RUN dotnet build DeveloperTools.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DeveloperTools.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DeveloperTools.Api.dll"]
