# 💰 Hisabati - Personal Budgeting Software

**Hisabati** is a desktop application designed to help users manage their personal finances effectively. Built with a focus on **Clean Architecture (3-Tier)** to ensure scalability and maintainability.

## 🚀 Key Features
* **Secure Authentication:** User Login and Registration system.
* **Identity-Based Accounts:** Automated unique Username generation (e.g., FirstName + LastName + ID).
* **3-Tier Architecture:** Complete separation between UI, Business Logic (BLL), and Data Access (DAL).
* **SQL Server Integration:** Reliable data storage with optimized queries and Identity columns.
* **Smart Validation:** Auto-formatting currency codes to Uppercase.

## 🛠️ Built With
* **Language:** C# (.NET Framework/Core)
* **Database:** SQL Server
* **UI:** Windows Forms (WinForms)
* **Architecture:** 3-Tier (DAL, BLL, UI)

## ⚙️ Setup
1. Clone the repository.
2. Run your SQL Server and create `SmartBudgetDB`.
3. Update the connection string in `clsDataAccessSettings`.
4. Build and Run using Visual Studio.
