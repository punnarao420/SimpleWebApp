FROM microsoft/aspnetcore-build
 
WORKDIR /home/app
 
COPY . .
 
RUN dotnet restore
 
RUN dotnet publish ./SimpleWebAP/SimpleWebAP.csproj -o /publish/
 
WORKDIR /publish
 
ENTRYPOINT ["dotnet", "SimpleWebAP.dll"]
