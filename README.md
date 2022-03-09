# Los Barrios de Amarillo Test Webapp

First, we start by adding two folders. One for speaker and one for session.

In each of these new directories, **navigate to them in the terminal** and make a new class library: 
    
`dotnet new classlib`

Change the name of the `.cs` file to match the folder tied to it. 

_________________________________________________________

`new-item` to make a new item (Only in Powershell)
`touch README.MD` in BASH
`new-item README.MD` in POWERSHELL

1. `mkdir NewFolder` makes a new folder.
2. `cd NewFolder` navigates to the new folder
3. `ls` lists the contents of the directory
4. `rm Class1.cs` removes "Class1.cs" from the directory

__________________________________________________________

## Some Git Commands

`dotnet new gitignore`
    This is for not pushing thing that you don't want to to GitHub.

`git init` (track project)
`git add -A` (add all to track)
`git rm --cahced README.MD` (be careful that you still have this file locally)
`git commit -m 'initial commit'`

_________________________________________________________

Alright, now we're gonna add a solution `(.sln)` file and add our classes to it.

`PS C:\Users\rh1015989\LosBarriosTest> dotnet new sln`
`PS C:\Users\rh1015989\LosBarriosTest> dotnet sln add Session/session.csproj`
`PS C:\Users\rh1015989\LosBarriosTest> dotnet sln add Speaker/speaker.csproj`

_________________________________________________________

## Building the Classes

**Composition - "Has a" relationship**
**Inheritance - "Is a" relationship**

For this scenario, we are making composition. Each session "has a" speaker.
__________________________________________________

`using System.Collections.Generic;` is what you need in order to use lists in your code.

`{get; set;}` allows an attribute to be able to acquire a parameter from the code and assign itself to it. It can get an attribute and set it to itself.
__________________________________________________

# Testing Markdown Elements

Press `Ctrl+Shift+V` to preview this .MD file

## Header 2
### Header 3
###### Header 6

Inline `code` has `back-ticks around` it.

```
<!-- Want a 
block of code
highlighted? Use
three back-ticks -->
```

** Bold Text **
* Italics *
[Click Here](https://www.markdownguide.org/cheat-sheet/)

