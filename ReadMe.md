# Advanced Programming 2016
## By Boris Ruiz Palma
##### Active Colaborators: José Andrés Álvarez Cabrera, Yulisa Ninett Azurdia Martínez.
#### [The Slides for this course can be found here](https://docs.google.com/presentation/d/1E-2gj9hJMsxTLuwpwJ7g4hJY1O_hTjuw46iE4ttdK5s/edit#slide=id.g117415e531_0_24)
### August 22nd, 2016

We used Markdown as an example of internal documentation and a proper way to 
describe our released features.

As an exercise for markdown I requested an example of tables using their
last semester´s grades as an example. _This are not my actual grades_ :p

| Date        | Subject           | Grade  |
| ------------- |-------------| -----:|
| 11/05/2009      | Software Engineering |  90 |
| 11/05/2009      | Financial Analysis |  85 |
| 11/05/2009      | Project Managment |  87 |

### August 24th, 2016
We started talking about the simple data structures. And Lists are the first example.
* We created an implementation using an array
* We created basic operations that are computationally expensive on purpose.
* Opertations Implemented
  * Initialize
  * InsertFirst
  * InsertLast
  * IsEmpty
  * FistElement
  * LastElement

### August 29th, 2016
We started by setting the constraints that are set in a Queue, basically **_FIFO (First In First Out)_** 
* We created an implementation using an array
* We created an implementation using an array
* We created basic operations that are computationally expensive on purpose.
  * Initialize  
  * Queue
  * Dequeue
  
### August 31st, 2016
We introduced the stack data structure, we analyzed how this structure contrasts with the Queue as it uses **_LIFO (List In First Out)_**

After presenting these 3 basic structures and implementing them using arrays the following exersices were presented.

Exercise # 1
Create the following instances. 
* 1 list of integers. (10 elements)
* 1 stack of integers. (10 elements)
* 1 queue of integers. (10 elements)

Add 10 random elements from 1 to 100 to the list.
Traverse the list from beggining to end, for each element greater than 50 add it to 
the stack, else add it to the queue.

Exercise # 2
Create the following instances. 
* 1 list of integers. (100 elements)
* 3 queues of integers. (100 elements)

Add 100 random elements from 1 to 100 to the list.
Traverse the list from beggining to end, for each element that is even add it to queue 1, 
for  each element that is a prime number add it to queue 2, for each element that is odd
add it to queue 3.

Ejercise # 3
Create the class Student with at least the following attributes.
* Name
* Study Program
* Semester he/she is currently studying.

Create the following instances. 
* 1 list of type Student. (10 elements)
* 2 queues of type Student.(10 elements)

According to a regular time table for URL student, traverse the list of students and 
add to queue 1 those whom attend during the morning and to queue 2 those who attend during
the evening.

### September 5th, 2016
We introduced the principles of recursivity, its several definitions, advantages and disadvantages.
* We made examples on the board of how a recursive function works by making as many iterations as it was neccessary.
* We sketched a stack on the board in order to show how a computer solves a recursive function piling up every calling to a previous value of the function until reaching the trivial/initial condition.

### September 7th, 2016
We challenged the students to implement the following functions, applying recursivity:
* Fibonacci (0, 1, 1, 2...)
* Inversion of an string (Input->Boris Output->Sirob)
* Product of the elements an array.
* G(x,y) = { G(x,y) = 1 / G(x-y, x+1) if x >= y ; 2x-y if x < y

### September 12th, 2016
We reviewed how to represent recursive calls using tree-like diagrams. After finishing clearing up quesitons about recursion we  changed topic and started discussing about how memeory works in computers. Topics covered included memory hierarchy, memory registers, direct access memory and random access memory. We finalized with the memory layout of a program (of C program). This will serve as an introduction to dynamic memory.

### September 14th, 2016
####Exam!

### September 18th, 2016

We presented a solution for the first exam of the course, and created some functions applying recursivity

####Palindromic words
A word is palindrome if the word reads the same forward as it does backward. This means that the meaning does not change. 

Example: the word “level”. Because we can do an inversion of the word and the meaning will be the same. 

In the project, there is a method that receive a string and the function of the method is to compare if the first half of the word is the same that the other half. 

####Prime numbers
To resolve this exercise in a recursive way we will need two parameters for our method “Prim”. The first parameter will be the number, and the second one will be the divisor. In this case, the method will do successive divisions. 

if (y == 1)

If the condition above is met, we will return true. 

if (x % y == 0)

If the condition above is met, we will return false because it means that the number can be divided for other numbers different of 1 and the same number entered. 

If the division is not exact we will decrease the divisor 1 number so we can continue with the successive divisions until one of the conditions can be met. 

Also, in the project it is a method with “x” as parameter (x is the number that will be evaluated). This method calls the “Prim” function so we can return the result. 

### September 21th, 2016
Day off.

### September 26th, 2016
After an overview of how memory hierarchy works, we started to learn C++ as it's memory management is more transparent to the programmer *unlike .net languages*. 
After a quick introduction on how to set up a C++ project we introduce the concept of pointers and its operators.

### September 28th, 2016
Day off.

### October 3rd, 2016
*"We have talked about pointers, but not about their practical application..."* - after such statement, we mention their application representing queues and stacks.

*"If we delete a position in the list, how do we know where the empty element is...?"*

Basically, we talked about the concept of a **linked list**, the type of structure that
allows to implement dynamic stacks and queues using pointers.
Homework was to look up what is a **double linked list**...

### October 5th, 2016
The previous class we talked about how expensive it would be to delete an specific element from a list and shift the left ones in an implementation using arrays.
* It turns out that is such more better to use a **linked list**, since it would only imply modifying the direction in memory that the *next* property of an element in the list is pointing to. We have then new several possibilities for working with queues, stacks and lists.

Also, we note that the elements in a **double linked list** have a reference to the previous and next node.

* *"What would happen if we look for an element in a list that is not double-linked...?"* It would be necessary to start from the begginning. For example, if we want to look for an element 2 nodes behind... a node wouldn't know how to go backwards; but if it is double-linked everything changes since it will have a *next* and *previous* property.

Furthermore, we made a couple of exercises applying pointers.

