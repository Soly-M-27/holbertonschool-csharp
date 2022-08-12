#!/usr/bin/env bash
mkdir $1 && sudo chmod -R 777 $1 && cd $1
sudo dotnet new sln
mkdir $2 && sudo chmod -R 777 $2 && cd $2
sudo dotnet new classlib
mv Class1.cs $2.cs
sudo sed -i $'7i \t<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>' $2.csproj
cd .. && sudo dotnet sln add $2/$2.csproj
mkdir $2.Tests && sudo chmod -R 777 $2.Tests && cd $2.Tests
sudo dotnet new nunit && mv UnitTest1.cs $2.Tests.cs
sudo dotnet add reference ../$2/$2.csproj
cd .. && sudo dotnet sln add $2.Tests/$2.Tests.csproj
