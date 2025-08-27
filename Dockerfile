# Imagen base de compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar csproj y restaurar dependencias
COPY *.sln .
COPY APIStock/*.csproj APIStock/
RUN dotnet restore

# Copiar el resto del código y compilar
COPY . .
WORKDIR /src/APIStock
RUN dotnet publish -c Release -o /app/publish

# Imagen final de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "APIStock.dll"]
