# ShareSphere

## Overview
ShareSphere is a C# web application built with ASP.NET designed to facilitate donations for various projects. The platform includes features for user registration, login, and project management. It also provides administrative functionalities to manage users and projects, as well as track donation progress.

## Features

### User Features
- **Home Page**: Browse and view current projects seeking donations.
- **User Dashboard**: 
  - View personal donation history.
  - Update profile information (username, email, and password).
  - Submit feedback for projects.
- **Donation**: 
  - Make donations to projects.
  - View progress of donations made.
- **Authentication**: 
  - Register a new account.
  - Login and logout securely.

### Admin Features
- **Admin Dashboard**:
  - Create and manage projects.
  - View the list of all users.
  - Monitor active projects and their progress.
  - Track total funds raised for each project.

### Feedback
- Users can provide feedback on projects they have donated to.

## Database Schema

### Tables

- **user**
    - `userID` (INT, Primary Key, Identity)
    - `username` (NVARCHAR(50), NOT NULL)
    - `email` (NVARCHAR(100), NOT NULL, UNIQUE)
    - `password` (NVARCHAR(255), NOT NULL)
    - `reg_date` (DATETIME, DEFAULT GETDATE())
    - `isAdmin` (BIT, DEFAULT 0)

- **project**
    - `ProjectID` (INT, Primary Key, Identity)
    - `Title` (NVARCHAR(255), NOT NULL)
    - `Description` (NVARCHAR(MAX), NOT NULL)
    - `Image` (NVARCHAR(255))
    - `FundTarget` (DECIMAL(18,2), NOT NULL)
    - `FundRaised` (DECIMAL(18,2), DEFAULT 0.00)
    - `IsCurrent` (BIT, DEFAULT 1)

- **feedback**
    - `ID` (INT, Primary Key, Identity)
    - `UserID` (INT, Foreign Key)
    - `username` (NVARCHAR(50), NOT NULL)
    - `feedbacktext` (NVARCHAR(MAX), NOT NULL)
    - `DateTime` (DATETIME, DEFAULT GETDATE())
    - `ProjectID` (INT, Foreign Key)

- **donations**
    - `DonationID` (INT, Primary Key, Identity)
    - `UserID` (INT, Foreign Key)
    - `ProjectID` (INT, Foreign Key)
    - `Amount` (DECIMAL(18,2), NOT NULL)
    - `DonationDateTime` (DATETIME, DEFAULT GETDATE())

## Getting Started

### Prerequisites
- .NET Core 3.1 or higher
- SQL Server
- Visual Studio 2019 or higher

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/tricks-ter/shareshpere.git
    cd shareshpere
    ```

2. Open the solution file in Visual Studio.

3. Run the database migrations to create tables:
    ```bash
    Update-Database
    ```

4. Build and run the project using Visual Studio:
    - Press `F5` or click the `Start` button.

### Usage

1. **Register and Login**:
    - Access the home page and register a new account.
    - Log in with your credentials.

2. **User Dashboard**:
    - View and update your profile.
    - Make donations to projects.
    - Provide feedback for projects.

3. **Admin Dashboard** (Admin users only):
    - Create new projects.
    - Manage existing projects.
    - View all users and track donation progress.

## Contributing

We welcome contributions to enhance the platform. Please fork the repository and submit pull requests.

## License

This project is licensed under the MIT License.

## Contact

For any inquiries or support, please contact raselahmed152727@gmail.com.
