FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["aot-e-security/aot_e_security.csproj", "aot-e-security/"]

RUN dotnet restore "aot-e-security/aot_e_security.csproj"
COPY . .
WORKDIR "/src/aot-e-security"
RUN dotnet build "aot_e_security.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "aot_e_security.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aot_e_security.dll"]