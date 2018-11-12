# BikeHike

Multi-User BikeHike App

Windows desktop GUI app to allow for the rental of bikes. Supports the notion of multiple users accessing the BikeHike database concurrently.

The app should interact with the database to provide the following functionality, with all changes to the database being persistent. In other words, if customer A rents a bike, that rental should be reflected in the database. If the app is closed and then reopened, the bike is still rented. The BikeHike app should work correctly in the presence of multiple users accessing the database concurrently. 

Functionality requirements:
1. Display a list of all the customers, in alphabetical order by last name. If 2 customers have the same last name, order by first name.
2. Select a customer from the list (or provide a search feature) to display customer’s ID and email, and whether the customer is currently out on a rental. If the customer is with a rental, display how many bikes, and the expected return date and time.
3. Display a list of all bikes, in order by bike id.

4. Select a bike from the list (or provide a search feature) to display bike’s year, type (the description, not the type id), and the rental price per hour. Also display whether the bike is currently out on a rental; if so, display the expected return date and time.
5. Display a list of bikes available for rent, by type. For bikes of the same type, list in order by newest bikes --- i.e. in descending order by year put into service.
6. Allow customer C to rent N > 0 bikes for H hours; the hours can be a real number, e.g. 3.5 hours. The UI can be as simple as selecting a customer and then inputting a set of bike ids into a text box, but the app must confirm that (a) the customer exists, (b) the customer is not already out on a rental, and (c) each of the bikes is available for rent. These conditions should be checked before the rental is entered into the database. If the rental is successful, display the rental ID (MessageBox.Show is fine).
7. Allow customer C to return from a rental, in which case all N bikes are returned at the same time. The app should display (MessageBox.Show is fine) the total cost of the rental based on the actual return time.
8. Add a “Reset Database” button or menu item. 
  a. Delete all rows in the RentalDetails table
  b. Delete all rows in the Rentals table
  c. Set all Rented bits to 0 (not rented) in the Bikes table
  
9. Add 2 or more indexes to your database to speed up the execution of the app (the database is too small to actually see any performance improvement, but the exercise is still worthwhile). You’ll need to modify your project #1 DDL to create the indexes, and then take advantage of these indexes by modifying your SQL queries in project #2. You’ll want to add “WITH” hints to make sure the DBMS actually uses your indexes. Searches and joins are likely candidates for taking advantage of indexes.

10. Add transactions to the application where appropriate; this implies for both (a) easier error handling, and (b) correct operation in the presence of multiple users. At a minimum, the “Reset” functionality from step 1 above should be wrapped in a transaction, as well as the operations to rent bikes and return bikes. You are required to use (a) ADO.NET transactions, and (b) Try-Catch-Finally to properly Commit or Rollback in the presence of exceptions (and retry at least 3 times in the presence of deadlock).

11. Add a way to simulate and test your multi-user app. In particular, add a text box so the user can enter a delay in milliseconds (e.g. 1000 => 1 sec). Then add delays inside your transaction-processing code. For example, when renting bikes, add a delay after you check if the customer and bikes are available for rent, but before you update the database. Likewise, when returning bikes, add a delay after you update the database to make sure other users don’t see these changes until the Tx is committed.
