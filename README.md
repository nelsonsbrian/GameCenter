# Word Counter

#### Program to Count inputted words - September 7, 2018

#### By **Brian Nelson**

## Description

A simple program that allows a user to input a master string, then enter in a list of words. The program then can return to the user how many times the full word in each item of the list is repeated inside the master string.

### Specs

Game and GamePlay

| Spec | Input | Output | Why |
| :-------------     | :------------- | :------------- | :----------- |
| **Program returns master string to user.** | "programmingisfun" to "programmingisfun" | true | It is important to see if the base parameters are being returns correctly. |
| **Program returns a user inputted word to user.** | "fun" to "fun" | true | It is important to see if the base parameters are being returns correctly. |
| **Program checks to see if a single inputted word matches the mater string when the word and master match exactly.** | "tissue" to "tissue" | true | Starts with a simple direct comparison. |
| **Program checks returns the count of how many times a word appears in the master string(not same length).** | "an" to "banana" | 2 | Adds some complexity to an otherwise direct comparison. |
| **Program returns a int for how many times a word is repeated in the master word for each element of the list.** | "an" to "banana" && "na" to "banana" | 2 && 2 | Repeats the previous spec for a certain amount of times. |



## Setup/Installation Requirements

* Clone this repository: https://github.com/nelsonsbrian/WordCounter.git

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
* Atom
* GitHub
* MS Test

## Support and contact details

_Brian Nelson nelsonsbrian@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2018 **_Brian Nelson_**
