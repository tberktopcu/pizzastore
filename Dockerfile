# Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Önce sadece proje dosyasını kopyala ve restore et
COPY *.csproj ./
RUN dotnet restore

# Sonra tüm dosyaları kopyala ve build et
COPY . ./
RUN dotnet publish -c Release -o out

# Çalışma aşaması (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "PizzaStore.dll"]
