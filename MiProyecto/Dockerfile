#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5024

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MiProyecto/MiProyecto.csproj", "MiProyecto/"]
RUN dotnet restore "MiProyecto/MiProyecto.csproj"
COPY . .
WORKDIR "/src/MiProyecto"
RUN dotnet build "MiProyecto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MiProyecto.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiProyecto.dll"]
