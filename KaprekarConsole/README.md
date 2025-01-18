# Kaprekar's Routine Console Application

https://www.youtube.com/watch?v=d8TRcZklX_Q

1. Choose any four unique numbers. You cannot repeat a number. For example 1874.

1. Take the number chosen and put it in ascending order
8741

2. Take the number chosen and put it in descending order
1478

3. Subtract the numbers ascending from descending

```math
8741 - 1748 = 6993
```

1. repeat the steps 2 through 4 again with the new number. IE 6993

```math
9963 - 3699 = 5934
```

Keep repeating the sequence and you will eventually get to 6174. 

psuedo code

1. get the 4 digit number from the console. 
2. test if the input is valid, if not, provide a friendly error and ask again
    1. is the string null? 
    2. can the string (input) be converted to a number (no alpha chars)
    3. is the string the right length (4)
    4. are there any zeros in the provided number?
3. take each character for the string and then sort it ascending
4. take each character for the string and then sort it descending
5. Subtract the descending from the ascending number. If the result is not 6174, repeat steps 3-5 with the new total until you get to 6174
4. Print each rounds result to the console