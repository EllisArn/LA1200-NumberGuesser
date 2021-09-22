# This is a tutorial to the "while-try-catch" command in C#


## Task and goals

After this the reader should be able to code a program with "while-try-catch"


## Content 1

As long as "While" is true, the program will loop the code in the while braces

```
while (x == 100)
{
    // do something
}
```


"If" checks whether a number or variable is the same as another or not

You write it like that:
```
if (x == 100)
{
    // do something
}
```


You can use "else if", if the first "if" is false, to ask something else
```
if (x < 100)
{
    // do something
}

else if (x > 100)
{
    // do something
}
```

"Try-catch" is to use if multible times and if none of the if's are true, the program uses the catch

As an example if you only want numbers, but the users input is a character

```
try
{
        if (x < 100)
        {
            // do something
        }

        else if (x > 100)
        {
            // do something
        }
} 
// for example if the input is not a number 

catch
{
    // do something
}
```



## Content 2

Everything together could look like this example:

This is from my NumberGuesser game

You can look at the whole code [here](https://github.com/EllisArn/LA1200-NumberGuesser) in Program.cs
```
while (userGuess != randomNumber)
                {
                    try
                    {
                      // this converts the input into an Int32
                        userGuess = Convert.ToInt32(Console.ReadLine());

              // Input is above 100

                        if (userGuess > 100)
                        {
                            Console.WriteLine(Error input above 100);
                        }

              // Input is lower than 1

                        else if (userGuess < 1)
                        {
                             Console.WriteLine(Error input lower than 1);
                        }

              // Input is lower than the random number

                        else if (userGuess > randomNumber)
                        {
                            Console.WriteLine(Too high);
                        }
                        
              // Input is higher than the random number

                        else if (userGuess < randomNumber)
                        {
                            Console.WriteLine(Too low);
                        }

                    }
                    
              // Input is not a number
                    
                    catch
                    {
                        Console.WriteLine(Error invalid input);
                        {
                            userAttempts--;
                        }

                    }
                }
```

## Content 3
Here is a link to a video of my NumberGuesser because it uses "while-try-catch"

It's in german so don't be confused

(Click on the Image)

[![image](https://user-images.githubusercontent.com/89130718/134318691-27437676-81d0-4960-b9f8-a26cffcbd286.png)
](https://youtu.be/aE53JePccuQ)

## Verification + Reflection

I showed this to my brother and he understands it

The project went good, but I had to re-write it once due to visual studio showing me weird errors

## Code

For just the code click [here](https://github.com/EllisArn/LA1200-NumberGuesser)
