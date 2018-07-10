FROM microsoft/aspnetcore-build
 
WORKDIR /home/app
 
COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done

RUN dotnet restore
 
COPY . .

RUN dotnet publish ./SimpleWebAP/SimpleWebAP.csproj -o /publish/
 
WORKDIR /publish
 
ENTRYPOINT ["dotnet", "SimpleWebAP.dll"]
