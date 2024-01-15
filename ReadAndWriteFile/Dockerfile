FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ReadAndWriteFile/ReadAndWriteFile.csproj", "ReadAndWriteFile/"]
RUN dotnet restore "ReadAndWriteFile/ReadAndWriteFile.csproj"
COPY . .
WORKDIR "/src/ReadAndWriteFile"
RUN dotnet build "ReadAndWriteFile.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReadAndWriteFile.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReadAndWriteFile.dll"]
