#Functions Applying Recursivity

Just a couple of notes that were part of the process of designing de functions... there can be minor mistakes. :p


##Fibonacci

F(n) = F(n-1) + F(n-2)
Boris gave the progression -> ( f(1) = 0, f(2) = 1...but the most common one is the one below)

F(0) = 0
F(1) = 1


##Inversion of a string

Example:  Input -> Boris... Output -> siroB

there are two versions of this function in the project. One made entirely by the student using his own logic, and the other one made proposed by the professor. The one implemented is the second one.

## Product of an array
Example:  Array Values: |3|1|2|4|0|  Product: 24

Originally,  the idea was inspired by the thing below... but the implemention is a bit different. P means the function and A the array.
P(n-1) = P(n-2) *A[n-1]

P(0) = A[0] 


##A weird function G(x,y)
x >= y
G(x,y) = 1 / G(x-y, x+1)
x < y
G(x,y) = 2x - y

The implementation is practically a couple of conditions.
