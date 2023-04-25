This repo contains source code for a library management system.
Project started on April 25th, 2023.

Bellow is basic requirements for the system:

1. A book catalog with search by the name, the author, and the category of the book. Note there may be more than one copy of each book, and a book may even be published by different publishers.
2. The ability to deactivate a patron's account if he/she doesn't return books after a specific period of time passes.
3. Records of books checked out as well as placed on hold (i.e., "reserved" by a patron to make sure the book is there when he/she gets to the library to check it out).
4. Notifications when the desired book becomes available and reminders that a book should be returned to the library, both by email.

Based on the requirements, I've designed the database for the system using Crow's foot database notation. Relationship between tables should be described as the symbols in the following image:
![image](https://user-images.githubusercontent.com/87921412/234423257-ca1a151f-79fd-486e-afc5-a1c049f135e3.png)
