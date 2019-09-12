### SomeSnippet

Simple web application that allows you to save your small pieces of code (snippets). Work in progress...

### How to run this app
- First of all, you need to build frontend. Go to "CodeSnippets/static/src" and run this line in console:

`npm run build`

- You also need to update database with all those migrations. Run (in PackageManagerConsole). Do not forget to choose CodeSnippets.Database as a default project!

`Update-Database`

### Features

- Standart AUTH with login and password;
- You can store snippets with variosity on languages and simplify search(not done yet) with tags.