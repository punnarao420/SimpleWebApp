#FROM microsoft/dotnet:2.1-sdk AS build
FROM microsoft/aspnet

# The final instruction copies the site you published earlier into the container.
COPY ./SimpleWebAP/obj/Release/ /inetpub/wwwroot

#COPY ./SimpleWebAP .
#WORKDIR ./SimpleWebAP

#RUN dotnet publish -c Release -o out


#FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
#WORKDIR /app
#COPY --from=build /app/SimpleWebAP/out ./
#ENTRYPOINT ["dotnet", "SimpleWebAP.dll"]
#WORKDIR /app

# Copy csproj and restore as distinct layers
#COPY ./SimpleWebAP/*.csproj ./
#RUN dotnet restore

# Copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out

# Build runtime image
#FROM microsoft/aspnetcore:2.0
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "SimpleWebAP.csproj"]
