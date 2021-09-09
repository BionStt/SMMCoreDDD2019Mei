#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1903 AS build
WORKDIR /src
COPY ["SMMCoreDDD2019.Web/SMMCoreDDD2019.Web.csproj", "SMMCoreDDD2019.Web/"]
RUN dotnet restore "SMMCoreDDD2019.Web/SMMCoreDDD2019.Web.csproj"
COPY . .
WORKDIR "/src/SMMCoreDDD2019.Web"
RUN dotnet build "SMMCoreDDD2019.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SMMCoreDDD2019.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SMMCoreDDD2019.Web.dll"]