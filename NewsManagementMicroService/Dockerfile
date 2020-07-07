FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["NewsManagementMicroService/NewsManagementMicroService.csproj", "NewsManagementMicroService/"]
RUN dotnet restore "NewsManagementMicroService/NewsManagementMicroService.csproj"
COPY . .
WORKDIR "/src/NewsManagementMicroService"
RUN dotnet build "NewsManagementMicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NewsManagementMicroService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NewsManagementMicroService.dll"]

