# 🌟 CultureGR

## 📚 Project Overview
**CultureGR** is a web platform that presents all the cultural landmarks of Greece—including museums, monuments, cultural centers, and more. The goal of this project is to offer users an engaging way to explore Greece's rich cultural heritage. The platform distinguishes between two main user roles:

- **Editorial Team Members:**  
  They can map, edit, and add new records (e.g., new museums, archaeological sites, etc.) to keep the content fresh and up-to-date.

- **Readers:**  
  They are encouraged to leave comments and rate the entries, thereby contributing to an interactive community experience.

Developed using **.NET 8** and **C# 12** in **Visual Studio 2022** and powered by **SQL Server Express**, CultureGR combines modern web technologies with a robust database backend.

---

## 🎯 Project Description

**CultureGR** is an online platform that showcases all the cultural landmarks of Greece, such as:  
- **Museums**  
- **Monuments**  
- **Cultural Centers**  
- **Other significant cultural sites**

The application is divided into two main user categories:

- **Members (Editorial Team):**  
  They can map, edit, and add new entries (e.g., new museums, archaeological sites, etc.).

- **Readers:**  
  They can write comments and rate the entries, thereby creating an interactive community.

---

## 🚀 Features

- **Interactive Map:**  
  Visual representation of cultural landmarks with geographic positioning.

- **Dynamic Content Management:**  
  Allows the editorial team to add, edit, and delete entries.

- **Reviews & Ratings:**  
  Enables readers to comment on and evaluate the entries.

- **Responsive Design:**  
  Optimized for all devices (desktop, tablet, mobile).

- **Security & Data Connectivity:**  
  Utilizes custom connection strings to manage database access.

## 🛠️ Project Evolution
CultureGR is designed to evolve over time. Future enhancements include:
- **New Features:** Regular updates to improve functionality.
- **Performance Improvements:** More efficient algorithms and optimizations.
- **Enhanced User Interface:** A more engaging and intuitive experience.
- **Robust Testing:** Integration of unit testing and debugging procedures.
- **Continuous Deployment:** Automation of build and deployment processes via CI/CD pipelines.

All progress is documented on GitHub to transparently track the project’s growth and improvements.

---

## 💻 Development Environment
The project is developed with the following tools and technologies:
- **IDE:** Visual Studio 2022
- **Backend:** .NET 8 and C# 12
- **Database:** SQL Server Express
- **Operating System:** Windows 10 (or later)
- **Additional Tools/Libraries:** Standard NuGet packages and any additional libraries as needed

---

## 🔗 Useful Links
- [.NET 8 Documentation](https://dotnet.microsoft.com/en-us/)
- [C# 12 Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [SQL Server Express Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

---

## ✨ Features
- **Interactive Map:**  
  Visual display of cultural landmarks across Greece.

- **Content Management:**  
  Editorial team members can add, edit, and manage cultural entries.

- **User Engagement:**  
  Readers can leave comments and rate the entries to share their experiences.

- **Secure Database Connectivity:**  
  Configurable connection strings for both general application access and administrative tasks.

- **Responsive Design:**  
  Optimized for various devices including desktops, tablets, and mobiles.

---

## 🎓 Developer Information
## This project was developed by Antoniou Ioannis, aspiring Full Stack Software Developer loving❤️ especialy ❤️.NET / ❤️ASP NET.
   ## Created with ❤️ FOR GREECE!

---

## 🚀 How to Run
To run the CultureGR project locally, follow these steps:

1. **Clone the Repository:**
 ## How to Clone the Repository and Open it Locally

Follow these steps to clone the repository, install Visual Studio Code, and open your project.

First, you need to clone the repository to your local machine. Open your terminal or command prompt and run the following command:

```bash
git clone https://github.com/AntoniouIoannis/myCodingFactoryExamsFinalProject.git

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Create a User `CultureGRAdmin` for SQL Server

In order to connect to the SQL Server database, you'll need to create a user `CultureGRAdmin` with the password `12345678`. Follow these steps:

1. Open **SQL Server Management Studio (SSMS)** and connect to your local instance using `localhost\SQLEXPRESS`.
   
2. Once connected, run the following SQL script to create the user:

```sql
USE [master];
GO

-- Create the login for the user
CREATE LOGIN CultureGRAdmin WITH PASSWORD = '12345678';
GO

-- Create the user in the specific database (replace 'YourDatabaseName' with the name of your database)
USE [YourDatabaseName];
GO

CREATE USER CultureGRAdmin FOR LOGIN CultureGRAdmin;
GO

-- Grant necessary permissions to the user (optional based on your needs)
ALTER ROLE db_owner ADD MEMBER CultureGRAdmin;
GO



