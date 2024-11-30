
# Bus Ticket Sales-Time Tracking Automation

## 📖 Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Features](#features)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

---

## 📚 Introduction

The **Bus Ticket Sales-Time Tracking Automation** project is a comprehensive solution designed for bus companies to manage and automate their operations. This dual-platform project features:

1. **A Web Application (ASP.NET MVC 5)**: For remote access and operations.
2. **A Desktop Application (C# Forms App)**: For local, high-performance tasks.

The system includes robust modules that streamline ticket sales, trip scheduling, time tracking, and driver management. These functionalities ensure the operational efficiency and scalability of bus companies.

---

## 🛠️ Technologies

### **Platforms**
- **Web Application**: ASP.NET MVC 5.
- **Desktop Application**: C# Forms App (.NET Framework).

### **Backend**
- **C#**: Used for business logic and processing.
- **Entity Framework**: For database interaction.
- **Dapper ORM**: For high-performance data queries.

### **Database**
- **Microsoft SQL Server**: Stores all operational data securely.

### **API & Web Services**
- **Web API**: Facilitates communication between applications.
- **RESTful Services**: Ensures interoperability and scalability.

### **UI/UX**
- **HTML5**, **CSS3**, **Material CSS**: Provides a responsive and clean user interface.
- **Responsive Design**: Ensures usability across devices.

### **Design Patterns**
- Creational: Singleton, Factory Method, Abstract Factory, Builder.
- Structural: Adapter, Facade, Proxy, Decorator.
- Behavioral: Mediator, Command, Iterator.

---

## 📂 Code Overview

### **Web Application**

1. **Models**:
   - Represent database entities such as tickets, trips, passengers, and drivers.
   - Used by both Entity Framework and Dapper for data interaction.

2. **Controllers**:
   - Handle business logic, such as trip scheduling, ticket sales, and invoice generation.
   - Manage data exchange between the user interface and the database.

3. **Views**:
   - Razor-based UI components provide a dynamic and responsive interface.
   - Includes ticket management, scheduling views, and administrative tools.

### **Desktop Application**

1. **Forms**:
   - GUI forms for local operations such as ticket sales, trip monitoring, and driver assignment.
   - Built for performance and simplicity.

2. **Services**:
   - Handles data retrieval and synchronization with the central SQL Server database.
   - Includes modules for managing invoices and reporting.

3. **Multithreading**:
   - Ensures real-time updates, especially in time-critical operations like trip tracking.

---

## 🔧 Features

### **Core Modules**

1. **Ticket Sales Management**
   - Allows ticket booking, cancellation, and modification.
   - Integrated with invoice generation for seamless operations.
   - Supports customer database integration to retain passenger details.

2. **Trip Scheduling and Management**
   - Provides dynamic trip scheduling based on route, time, and availability.
   - Includes tools for monitoring trip status (active, completed, or delayed).

3. **Driver Management**
   - Assigns drivers to trips based on schedules and availability.
   - Tracks driver working hours to ensure compliance with labor laws.

4. **Time Tracking**
   - Logs trip start and end times, delays, and durations.
   - Real-time updates for trip progress.

5. **Invoice and Reporting System**
   - Automatically generates invoices for customers.
   - Includes detailed reporting tools for trip revenue, operational costs, and driver performance.

### **Additional Features**

- **Real-Time Notifications**: Alerts operators about upcoming trips or scheduling conflicts.
- **Authentication and Authorization**: Role-based access control using Identity.
- **Data Export**: Supports exporting reports in JSON or CSV formats.
- **Asynchronous Operations**: Reduces wait times during critical operations like invoice generation.

---

## ⚙️ Usage

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-repo/bus-ticket-automation.git
   ```

2. **Set Up the Database**
   - Install **Microsoft SQL Server**.
   - Restore the `.bak` file provided in the project.

3. **Configure the Applications**
   - Update `appsettings.json` (Web Application).
   - Update `App.config` (Desktop Application).

4. **Run the Applications**
   - Open the project in **Visual Studio**.
   - Build the solution and run either the web or desktop application.

---

## 🖼️ Output

### **Ticket Sales Interface**
Allows operators to manage ticket bookings efficiently.
![Ticket Sales](https://via.placeholder.com/800x400?text=Ticket+Sales+Interface)

### **Trip Scheduling Interface**
Dynamic scheduling tool for managing routes and times.
![Trip Scheduling](https://via.placeholder.com/800x400?text=Trip+Scheduling+Interface)

### **Driver Management Dashboard**
Provides tools for assigning drivers and tracking their schedules.
![Driver Management](https://via.placeholder.com/800x400?text=Driver+Management+Dashboard)

---

## 🛡️ License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.
