#!/usr/bin/env bash
sudo dotnet new console -n $1
sudo dotnet build $1
sudo chmod -R 777 $1
cd $1 && mv Program.cs $1.cs
