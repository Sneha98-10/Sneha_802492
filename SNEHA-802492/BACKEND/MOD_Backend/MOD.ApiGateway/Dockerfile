FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.ApiGateway/MOD.ApiGateway.csproj", "MOD.ApiGateway/"]
RUN dotnet restore "MOD.ApiGateway/MOD.ApiGateway.csproj"
COPY . .
WORKDIR "/src/MOD.ApiGateway"
RUN dotnet build "MOD.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.ApiGateway.dll"]