using System;

class Project1

{
    static void Main()
    {
        var exit = false;

        while (!exit)
       
        {
            var input = Console.ReadLine();

            if (input == "exit")
            {

                exit = true;

            }
            else if (input.Contains("+"))
            {
                var numericResults=AddTwoNumbers(input);
                var textresults = numericResults.ToString();
                Console.WriteLine(textresults);

            }
            else if (input.Contains("-"))
            {
                var subtracting = input.Split('-');
                int firstNumber = int.Parse(subtracting[0]);
                int secondNumber = int.Parse(subtracting[1]);
                var results = firstNumber - secondNumber;
                var textresults = results.ToString();
                Console.WriteLine(textresults);
            }
            else if (input.Contains("*"))
            {
                var multiply = input.Split('*');
                int firstNumber = int.Parse(multiply[0]);
                int secondNumber = int.Parse(multiply[1]);
                var results = firstNumber * secondNumber;
                var textresults = results.ToString();
                Console.WriteLine(textresults);
            }
            else if (input.Contains("/"))
            {
                var division = input.Split('/');
                int firstNumber = int.Parse(division[0]);
                int secondNumber = int.Parse(division[1]);
                var results = firstNumber / secondNumber;
                var textresults = results.ToString();
                Console.WriteLine(textresults);
            }
        }
     
    }
    static int AddTwoNumbers(string input)
    {
        var addition = input.Split('+');
        int firstNumber = int.Parse(addition[0]);
        int secondNumber = int.Parse(addition[1]);
        var results = firstNumber + secondNumber;
        return results;
    }
}
//tab (forward)and shift tab(backward)