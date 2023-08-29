# E-Commerce API README

Welcome to the README for the E-Commerce API project. This API provides the backend functionality for an e-commerce website that offers Consoles, Controllers, and supports basic CRUD operations, transaction management, and CSV file generation.

## Features
- Basic CRUD operations for Consoles and Controllers.
- Transaction management for tracking customer purchases.
- Generation of CSV files containing transaction data.

## Technologies Used
- ASP.NET Web API
- Entity Framework
- C#
- SQLServer

## Transaction Functionality
The API supports transaction functionality to track customer purchases. When a purchase is made, a transaction record is created, capturing details such as customer ID, purchased items, and purchase date.

## CSV File Generation
The API can generate CSV files containing transaction data. You can use the `/api/transactions/export` endpoint to retrieve transaction data and save it as a CSV file.

