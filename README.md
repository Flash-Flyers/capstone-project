# Flash Flyerz Event Manager
This project is a demo web application intended to be used to share Kent State University campus events.

### Features: 
* Easy event sharing
* Upload flyers to add a QR code which links to Event page
* Event page displays useful information such as maps, descriptions and student engagement
* Search events by name, date, as well as interest tags
* Account based security and moderation

## Project Setup

* The IDE required to build this project is Visual Studio Community 2019
* The project uses the ASP.NET Core framework
* PostgreSQL is the database management system required to implement the models
* pgAdmin is the Administration access tool of choice for this project

### Database Setup and Build Steps

1. Create a PostgrSQL 13 database called 'DB' within pgAdmin
2. Within the Visual Studio Project open the Package Manager Console under Tools -> NuGet Package Manager
3. Run the command 'add-migration initial' within the Package Manager Console
4. Run the command 'update-database' within the Package Manager Console
5. Once the database 'DB' has been updated, it needs to be seeded with Location data which is found under the Project Files in a directory called 'SQL_MapBox'
6. Build the project using IIS Express

## API, Tools and Packages

* pgAdmin 4
* IIS Express
* Mapbox GL
* QRCoder
* MailKit
* Ethereal Email

## Authors

Matt Dietz - mdietz12@kent.edu 

Joshua Evans - jevans63@kent.edu 

Daniel Coduto - dcoduto@kent.edu 

James Gingerich - jginger5@kent.edu

Kyle Sinko - ksinko@kent.edu

## Project Status

This project is being developed for a Kent State University Capstone Project course.
