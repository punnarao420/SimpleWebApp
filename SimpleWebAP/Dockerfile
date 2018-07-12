FROM microsoft/aspnetcore-build:2.0 AS build-env

CMD echo $pwd
CMD ls -l $pwd
CMD echo "copying from shared path "
COPY \\my\share\PushToDocker .
CMD ls -l .
CMD echo $(build.artifactstagingdirectory)
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
