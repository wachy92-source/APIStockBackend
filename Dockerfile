# Imagen base de compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar la solución
COPY *.sln ./

# Copiar todos los proyectos
COPY APIStock.API/*.csproj APIStock.API/
COPY APIStock.Application/*.csproj APIStock.Application/
COPY APIStock.Core/*.csproj APIStock.Core/
COPY APIStock.Infrastructure/*.csproj APIStock.Infrastructure/

# Restaurar paquetes
RUN dotnet restore

# Copiar todo el código
COPY . .

# Publicar
WORKDIR /src/APIStock.API
RUN dotnet publish -c Release -o /app/publish

# Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "APIStock.API.dll"]
