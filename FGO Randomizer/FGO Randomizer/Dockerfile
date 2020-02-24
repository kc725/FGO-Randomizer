FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["FGO Randomizer/FGO Randomizer.csproj", "FGO Randomizer/"]
RUN dotnet restore "FGO Randomizer/FGO Randomizer.csproj"
COPY . .
WORKDIR "/src/FGO Randomizer"
RUN dotnet build "FGO Randomizer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FGO Randomizer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FGO Randomizer.dll"]