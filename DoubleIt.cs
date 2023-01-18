// GOAL OF APPLICATION: Collect a number from user, double the number for User and then show user the doubled value


using System;

// our class name is now DoubleIt and no longer Program; that's to tell you we can name our class anything
class DoubleIt{
    static void Main()
    {
        // DoubleIt Application Logic will go here

        // code to Interact with User
        Console.WriteLine("Give me a number and I will double it for you :) ");
        // Console.Writeline() writes a line to the console and Console.ReadLine() method we attached to the return value of the variable is used to retrieve input the user has typed into the command line
        
        // having done this before:  [int yourNumber = Console.ReadLine();]  we had an error because the Console.ReadLine() actually creates a string; However we are trying to save its return value into an int variable called yourNumber. 
        // C# throws an error to prevent this because its a strongly-typed Language(the code below would have perfectly worked in JavaScript)
        // to fix the error now we added the 2 Lines below and a final line after multiplying our number by 2
        // since we already know Console.WriteLine() would only create us a string now the line below will gather user's input in the correct datatype(string --we called it stringNumber)
        string stringNumber = Console.ReadLine(); // Line to solve the build error we got

        // this line below defines yourNumber variable as the result of transforming stringNumber from a string to an intand uses the in-built int.parse() method
        int yourNumber = int.Parse(stringNumber); // 2nd Line to solve the build error we got

       

        // code that doubles the number and prints it back to the user
        // here we are simply multiplying the yourNumber variable by 2 and printing the results back out to the user with the Console.WriteLine() you already know
        int yourDoubledNumber = yourNumber * 2;
        
        // this line below[the final line for solving our build error] takes the result of multiplying our int by two and turns it backinto a string using the TOString() method... 
        // this way it can be concatenated with the rest of our statement and printed to the console 
        string stringDoubledNumber = yourDoubledNumber.ToString(); // 3rd Line to solve the build error we got
        Console.WriteLine("You gave me: "+ stringNumber + " I doubled your number for you: " + yourDoubledNumber + ". Run the command dotnet run to play again :)");
    }

}