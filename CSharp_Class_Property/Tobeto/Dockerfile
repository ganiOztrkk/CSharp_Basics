FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Tobeto/Tobeto.csproj", "Tobeto/"]
RUN dotnet restore "Tobeto/Tobeto.csproj"
COPY . .
WORKDIR "/src/Tobeto"
RUN dotnet build "Tobeto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tobeto.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tobeto.dll"]
