# Rental Service
RentalService manages all the operations and keeps lists of users, equipment, rentals.
The main object(Rental) of this service is created when a user requests to rent some equipment. 
The Rental objects contains dates and also User and Equipment objects which are abstract classes.
This allows to add new types of Users easily and without the necessity to modify base logic.
The system allows:
 - creation of Users (Employee, Student)
 - creation of Equipment (Laptop, Projector, Camera)
The Rentals:
 - can be created through the combination of a User, Equipment and a TimeSpan
 - can be returned 
 - displayed (only for certain User or only those which are overdue)

It is all combined into a short summary which:
 - prints all Users
 - prints all Equipment
 - prints all Rentals
