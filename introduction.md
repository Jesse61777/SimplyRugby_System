# Simply Rugby Management System - User Manual

Welcome to the **Simply Rugby Management System**. This guide provides an overview of how to use the application to manage rugby squads, players, and training performance.

---

## 1. System Overview
Simply Rugby is a comprehensive management tool designed for rugby clubs to track:
* **Junior & Senior Squads**: Separate management logic for age groups.
* **Player Profiles**: Personal details, health status, and membership.
* **Training Sessions**: Attendance tracking and focus areas.
* **Skill Assessments**: Performance metrics based on standard criteria.

---

## 2. Getting Started

### 2.1 Database Configuration
Before launching the application, ensure your local MySQL server is running.
1. Locate the `DbHelper.cs` file in the `Data` folder.
2. Update the connection string with your local credentials:
   `server=localhost; database=simply_rugby; uid=root; pwd=YOUR_PASSWORD;`

### 2.2 First Launch
Upon starting the application, you will be greeted by the **Main Dashboard**, providing a high-level summary of club activity.

---

## 3. Core Modules

### 3.1 Analytics Dashboard
* **Function**: Visualizes the total number of players, active squads, and upcoming sessions.
* **Action**: Use the navigation sidebar to switch between different management views.

### 3.2 Member Directory
* **View Members**: Browse a complete list of registered players.
* **Add/Edit**: Click "Add Member" to input new details. Validation ensures required fields (like names and emails) are not empty.
* **Export**: Use the "Export to CSV" feature to generate reports for offline use.

### 3.3 Training & Attendance
* **Session Logging**: Select a squad and mark attendance for specific dates.
* **Injury Tracking**: Update a player's status if they are unavailable for training.

### 3.4 Skill Assessment
The system uses a **1-5 Rating Scale**:
* **1-2 (Developing)**: Requires significant coaching.
* **3 (Competent)**: Meets standard performance for the age group.
* **4-5 (Exceptional)**: Demonstrates leadership and high technical skill.

---

## 4. Troubleshooting (FAQ)

**Q: Why does the program show a "Database Connection Failed" error?**
**A:** Check if your MySQL service is active and ensure the database schema `simply_rugby` has been initialized using the provided SQL script.

**Q: How do I access the technical API documentation?**
**A:** Click the "API Documentation" tab at the top of this webpage to view detailed C# class and method descriptions.

---

## 5. Contact & Support
If you encounter any bugs or require further assistance, please contact the development team or click the **"Feedback"** button within the application to send a report.