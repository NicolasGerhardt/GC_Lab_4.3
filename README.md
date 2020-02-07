# Lab 4.3 Prime Numbers
## Task
Using Test Driven Development practices, create an application that locates prime
numbers.

## What will the application do?
* The application locates prime numbers in a sequence (ex: 1st prime number is 2, 10th
prime number is 29, etc.; note that 1 isn’t considered a prime).
* The application prompts the user which sequenced prime they want to locate.
* The application displays the prime number and its sequence number, and prompts the
user to find another prime.
* When the user chooses to end his or her search, the application displays a goodbye
message.

## Build Specifications/Grading Standards
Pair Program! Work with your assigned partner and follow Test-Driven Development.
1. Create a Prime Numbers class with a GetPrime() method. GetPrime returns the nth prime
number where n is the method’s integer parameter. (1 returns 2, 2 returns 3, 3 returns 5,
etc.
    * Class is properly formed—1 point
    * Method has proper header—1 point
    * Method returns the correct prime number for the argument—2 points
1. Create Unit Tests for your program, as you go, following TDD methodology. Write a test,
fail it, implement code, pass it, repeat.
    * Solution has at least 5 valid Unit Tests—5 points (1 each)
1. Create a Main which takes user input and, using the class, displays the proper prime
    * Program takes integer input correctly and displays the prime—1 point
    
## Extended Challenges
* Consider efficiency. What algorithm would have the greatest time efficiency? Now that
you’ve got tests, refactor your code for efficiency.
