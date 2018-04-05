# ZooKeeper
A simple demo of how inheritance works in C#

Exercises:

Your uncle is a zookeeper and has asked you to help him build some software to track vital stats of the
various animals under his keep.
1. To start create a base class called Critter with  
a. A constructor that takes in the animal’s age and colour  
b. Eats() method that prints the eating behaviour of the animal (the default is ‘never eats’)  
c. Movement() method that prints how the animal moves (the default is ‘stationary’)  
d. Override ToString to print the animal type, colour and age. E.g. “Frog (Age=3,
Colour=Green)”  
2. Create four animal classes that inherit from Critter and specify the behaviour for each method.  
a. Frog  
b. Zebra  
c. Rabbit  
d. Elephant  
3. Create a program that prompts the user to create one of the four above animals. The program
must remain running until the user exits. After each animal is added it must print who is in the zoo.  
a. For each animal prompt for age and colour.  
b. Then create the animal object  
    &nbsp;&nbsp;&nbsp;&nbsp;i. Call the Eats() and Movement() methods after it is created printing the results to  
    &nbsp;&nbsp;&nbsp;&nbsp;the console. E.g. When creating a frog I would expect to see – “eats flies” and
    &nbsp;&nbsp;&nbsp;&nbsp;“hops and swims around” printed.
    &nbsp;&nbsp;&nbsp;&nbsp;ii. Finally, add the new critter to a collection until the application exits.  
c. After each animal is created print who is in the zoo.  
    &nbsp;&nbsp;&nbsp;&nbsp;i. After creating a rabbit that is 2 with brown fur    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**The Zoo Contains:**  
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Rabbit (Age=2,Colour=Brown)**  
    &nbsp;&nbsp;&nbsp;&nbsp;ii. After creating a zebra that is 5 with black and white hair.    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**The Zoo Contains:**  
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Rabbit (Age=2,Colour=Brown)**  
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Zebra (Age=5,Colour=Black and White)**  
