# ASP.NET Core MVC Company Website

A simple and responsive company website built using ASP.NET Core MVC.

## Features

- Home Page
- About Us
- Services
- Career
- Contact Us
- Shared Layout
- Razor Views
- MVC Architecture
- Bootstrap Responsive Design

## Technologies Used

- ASP.NET Core MVC (.NET 10)
- C#
- Razor Views
- HTML5
- CSS3
- Bootstrap 5

## Project Structure

```
Controllers/
Models/
Views/
wwwroot/
Program.cs
appsettings.json
```

## How to Run

### Clone Repository

```bash
git clone https://github.com/yourusername/company-website-mvc.git
```

### Navigate to Project

```bash
cd company-website-mvc
```

### Restore Packages

```bash
dotnet restore
```

### Run Application

```bash
dotnet run
```

Open your browser:

```
https://localhost:5001
```

or

```
http://localhost:5000
```


## Pull Image

```bash
docker pull mohdmusheer/5pages:latest
```

## Run Container

```bash
docker run -d \
  --name 5pages \
  -p 8080:8080 \
  mohdmusheer/5pages:latest
```

## Access Application

Open:

```
http://localhost:8080
```

or

```
http://<YOUR_SERVER_IP>:8080
```

## Exposed Port

```
8080
```

## Docker Commands

### View Running Containers

```bash
docker ps
```

### Stop Container

```bash
docker stop 5pages
```

### Start Container

```bash
docker start 5pages
```

### Remove Container

```bash
docker rm -f 5pages
```


## Deployment

The project can be deployed on:

- AWS EC2 (Linux)
- IIS
- Docker
- Azure App Service

## Learning Objectives

This project demonstrates:

- MVC Pattern
- Routing
- Controllers
- Models
- Razor Views
- Shared Layouts
- Static Files
- Bootstrap Integration
- ASP.NET Core Deployment

## Author

Musheer