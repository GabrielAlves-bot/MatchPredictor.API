FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copia todos os .csproj e restaura as dependências
COPY ["MatchPredictor.API/MatchPredictor.API.csproj", "MatchPredictor.API/"]
COPY ["MatchPredictor.Application/MatchPredictor.Application.csproj", "MatchPredictor.Application/"]
COPY ["MatchPredictor.Domain/MatchPredictor.Domain.csproj", "MatchPredictor.Domain/"]
COPY ["MatchPredictor.Infrastructure.Data/MatchPredictor.Infrastructure.Data.csproj", "MatchPredictor.Infrastructure.Data/"]
COPY ["MatchPredictor.Infrastructure.IoC/MatchPredictor.Infrastructure.IoC.csproj", "MatchPredictor.Infrastructure.IoC/"]

RUN dotnet restore "MatchPredictor.API/MatchPredictor.API.csproj"

# Copia o restante do código
COPY . .

WORKDIR "/src/MatchPredictor.API"
RUN dotnet build "MatchPredictor.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MatchPredictor.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MatchPredictor.API.dll"]