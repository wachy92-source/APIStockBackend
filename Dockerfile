# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copiar el archivo de solución
COPY APIStock.sln ./

# Copiar los proyectos
COPY APIStock/*.csproj APIStock/
COPY APIStock.Application/*.csproj APIStock.Application/
COPY APIStock.Core/*.csproj APIStock.Core/
COPY APIStock.Infrastructure/*.csproj APIStock.Infrastructure/

# Restaurar paquetes
RUN dotnet restore

# Copiar todo el código
COPY . .

# Compilar en Release
RUN dotnet publish APIStock.sln -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar desde la etapa de build
COPY --from=build /app/publish .

# Exponer el puerto (ajústalo según tu app)
EXPOSE 5000

# Comando para iniciar la aplicación
ENTRYPOINT ["dotnet", "APIStock.dll"]
