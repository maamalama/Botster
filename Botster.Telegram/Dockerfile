FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Botster.Telegram/Botster.Telegram.csproj", "Botster.Telegram/"]
RUN dotnet restore "Botster.Telegram/Botster.Telegram.csproj"
COPY . .
WORKDIR "/src/Botster.Telegram"
RUN dotnet build "Botster.Telegram.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Botster.Telegram.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Botster.Telegram.dll"]
