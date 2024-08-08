#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8088
EXPOSE 8089

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NLWestStandings/NLWestStandings.csproj", "NLWestStandings/"]
COPY ["NLWestStandings.Client/NLWestStandings.Client.csproj", "NLWestStandings.Client/"]
RUN dotnet restore "./NLWestStandings/NLWestStandings.csproj"
COPY . .
WORKDIR "/src/NLWestStandings"
RUN dotnet build "./NLWestStandings.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NLWestStandings.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NLWestStandings.dll"]