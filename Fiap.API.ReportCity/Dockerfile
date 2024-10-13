
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Fiap.API.ReportCity/Fiap.API.ReportCity.csproj", "Fiap.API.ReportCity/"]
RUN dotnet restore "Fiap.API.ReportCity/Fiap.API.ReportCity.csproj"

COPY . .
WORKDIR "/src/Fiap.API.ReportCity"
RUN dotnet build "Fiap.API.ReportCity.csproj" -c $BUILD_CONFIGURATION -o /app/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Fiap.API.ReportCity.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fiap.API.ReportCity.dll"]
