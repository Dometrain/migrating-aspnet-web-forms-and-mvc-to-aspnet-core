# Migrating ASP.NET Web Forms and MVC to ASP.NET Core

Welcome to the repository for the **Migrating ASP.NET Web Forms and MVC to ASP.NET Core** course. This course is designed to help developers and software architects transition legacy ASP.NET Web Forms or MVC applications to modern ASP.NET Core applications. Whether you're familiar with these technologies or new to them, this course will guide you step-by-step through the migration process with practical, hands-on examples.

## About Me

Hello! My name is [**Jonathan "J." Tower**](http://linkedin.com/in/jtower), and I’m an eleven-time Microsoft MVP award recipient in .NET and a Founding Partner at [**Trailhead Technology Partners**](https://trailheadtechnology.com/). Over the years, I’ve helped countless teams modernize their legacy applications, moving them from older technologies to the latest and greatest that .NET has to offer. I started developing web applications even before .NET Framework existed, so I’ve had the privilege of watching the web development landscape evolve dramatically, from classic ASP to Web Forms, MVC, Razor Pages, and beyond.

I’ve worked with many teams to migrate legacy applications, and now I’m excited to share my knowledge and experience with you. In this course, we’ll explore how to successfully migrate your ASP.NET Web Forms and MVC applications to ASP.NET Core.

## Course Overview

This course focuses on migrating web applications built with ASP.NET Web Forms and MVC to ASP.NET Core. If you’re working with a legacy ASP.NET application and are ready to modernize it, this course is for you. You'll learn:

- Different migration strategies (Big Bang, Incremental, and Strangler Fig)
- How to modernize architecture, using features like Dependency Injection, Middleware, and more
- Migrating data access code (EF6 to EF Core, Dapper, ADO.NET)
- Step-by-step guidance on moving Web Forms and MVC to Razor Pages and MVC in ASP.NET Core
- Integrating modern and legacy systems during the migration process using YARP (Yet Another Reverse Proxy) for seamless communication between the old and new parts of your application

### Key Topics:
- **Module 1**: Course Overview & Prerequisites
- **Module 2**: Migration Fundamentals
- **Module 3**: Differences Between ASP.NET and ASP.NET Core
- **Module 4**: .NET Upgrade Assistant
- **Module 5**: Upgrading Class Libraries
- **Module 6**: Entity Framework Modernization Strategy
- **Module 7**: Migrating MVC to ASP.NET Core
- **Module 8**: Migrating Web Forms to ASP.NET Core
- **Module 9**: Advanced System.Web Adapters
- **Module 10**: Migrating Other Common Components
- **Module 11**: Future Modernization Options
- **Module 12**: Course Conclusion

For a detailed breakdown, you can find additional resources and presentation slides for each module throughout the repository.

## Contact Me

I’m always happy to help! If you have any questions or need further clarification on any topics covered in the course, feel free to reach out to me via email:

**📧 Email:** [jtower@trailheadtechnology.com](mailto:jtower@trailheadtechnology.com)

I strive to respond as quickly as possible, but please allow some time due to the volume of queries.

## Using the Code Samples

The code samples in this repository are designed to represent the **ending state** of each module. You can use them as a reference to see how the migration process unfolds in practical terms.

### Setting up the Database

To run the code samples successfully, you will need to restore the database from the `.bak` file located in the `data` folder. Here's how you can do that:

1. **Install SQL Server**: Ensure you have a local SQL Server instance running. I used `MSSQLSERVER01` as the name of the instance, but you can use your own instance name if different.
2. **Restore the Database**:
   - Open SQL Server Management Studio (SSMS).
   - Connect to your local instance.
   - Right-click on the `Databases` node and select `Restore Database`.
   - Choose the `.bak` file in the `data` folder.
   - Follow the prompts to restore the database.

## Getting Started

1. Clone this repository to your local machine.
2. Set up your local development environment:
   - **Visual Studio** (for C#/.NET development)
   - **SQL Server** (with a restored database from the `.bak` file in the data directory)
3. Explore each module folder for code examples and exercises.

## Conclusion

This course is designed to make the migration process clear and manageable. Whether you are moving a small MVC app or a large Web Forms application, this course will provide you with all the tools and techniques you need to complete the migration successfully.

Happy coding, and I hope you enjoy the course!
