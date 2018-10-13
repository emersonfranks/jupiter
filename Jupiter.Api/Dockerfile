FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Jupiter.Api/Jupiter.Api.csproj Jupiter.Api/
RUN dotnet restore Jupiter.Api/Jupiter.Api.csproj
COPY . .
WORKDIR /src/Jupiter.Api
RUN dotnet build Jupiter.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Jupiter.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Jupiter.Api.dll"]
