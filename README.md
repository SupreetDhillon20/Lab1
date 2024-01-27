LAB 1

1.	Create a class called Person that has the following six attributes: 
•	personId: int 
•	firstName: string
•	lastName: string
•	favoriteColour: string
•	age: int
•	isWorking: bool
Ensure that the Person class has the following methods:
•	DisplayPersonInfo: accepts the six person attributes and displays (Name= firstName + lastName)
personId: Name’s favorite color is favoriteColour 
•	ChangeFavoriteColour: changes the person’s favorite colour to white
•	GetAgeInTenYears: get the person’s age after 10 years
•	ToString method: displays all Person Object information as a list
2.	Create a class called Relation that has one attribute: 
•	RelationshipType: values can be Sister, Brother, Mother or Father
Ensure the Relation class has the following method:
•	ShowRelationShip: accepts two Person objects and displays the relationship between them
 
3.	Create a Main class.
a.	Create four objects using the following data:
personId	firstName	lastName	favoriteColour	age	isWorking
1	        Ian	      Brooks	     Red	        30	Yes
2	        Gina	    James	       Green	      18	No
3	        Mike	    Briscoe	     Blue	        45	Yes
4	        Mary	    Beals	       Yellow	      28	Yes
b.	Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour. 
c.	Display all of Mike’s information as a list.
d.	Change Ian’s Favorite Colour to white, and then print his information as a sentence.
e.	Display Mary’s age after ten years.
f.	Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.
g.	Add all the Person objects to a list, and then use the list to display the following:
•	The average age of the people in the list
•	The youngest person and the oldest person
•	The names of the people whose first names start with M
•	The person information of the person that likes the colour blue

OUTPUT
2: Gina James's favorite colour is Green
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavouriteColour: Blue
Age: 45
IsWorking: True
1: IanBrooks's favorite colour is White
MaryBeals's age in 10 years is 38
Relationship between Gina and Mary is: Sisterhood
Relationship between Ian and Mike is: Brotherhood
Person who likes the blue colour:
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavouriteColour: Blue
Age: 45
IsWorking: True
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavouriteColour: Blue
Age: 45
IsWorking: True
PersonId: 4
FirstName: Mary
LastName: Beals
FavouriteColour: Yellow
Age: 28
IsWorking: True
Average age is: 30.25
The youngest person is: Gina
The oldest person is: Mike
C:\Users\supre\Downloads\Task1\lab1\bin\Debug\net8.0\lab1.exe (process 31120) exited with 
code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging-
Automatically close the console when debugging stops.
Press any key to close this window . . .
