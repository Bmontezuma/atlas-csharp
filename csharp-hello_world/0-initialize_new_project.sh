#!/usr/bin/env bash

# Create a new directory titled 0-new_project
mkdir 0-new_project

# Change the current directory to 0-new_project
cd 0-new_project

# Initialize a new C# console application project using dotnet
dotnet new console

# Restore project dependencies using dotnet restore
dotnet restore
