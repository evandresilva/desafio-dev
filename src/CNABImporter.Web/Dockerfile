#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["CNABImporter.Web/CNABImporter.Web.csproj", "CNABImporter.Web/"]
RUN dotnet restore "CNABImporter.Web/CNABImporter.Web.csproj"
COPY . .
WORKDIR "/src/CNABImporter.Web"
RUN dotnet build "CNABImporter.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CNABImporter.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CNABImporter.Web.dll"]