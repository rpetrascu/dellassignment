How to run the application locally:
 - open Dell.sln with Visual Studio and rebuild the solution
 - in DatabaseSetup.cs replace the connectionString static field's value with yours of SQL Server
 - run the application from Debug -> Start Debugging (F5)

A sample of the web service request:
POST: http://localhost:50864/Customers/AddCustomer { "Name": "Test Test", "Email": "test@test.com" }