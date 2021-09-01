FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "eRestoran.WebAPI" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD ./eRestoran.WebAPI/SlikeSeed ./SlikeSeed
ENTRYPOINT ["dotnet", "eRestoran.WebAPI.dll"]





