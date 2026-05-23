ARG APP_PROJECT=LawFirmApp.Web
ARG APP_DLL=LawFirmApp.Web.dll

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG APP_PROJECT
WORKDIR /src

COPY LawFirmApp_ui.sln ./
COPY src/LawFirmApp.Web/LawFirmApp.Web.csproj src/LawFirmApp.Web/
COPY src/LawFirmApp.Api/LawFirmApp.Api.csproj src/LawFirmApp.Api/
RUN dotnet restore LawFirmApp_ui.sln

COPY . .
RUN dotnet publish src/${APP_PROJECT}/${APP_PROJECT}.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
ARG APP_DLL
WORKDIR /app
ENV APP_DLL=${APP_DLL}
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["sh", "-c", "dotnet \"$APP_DLL\""]
