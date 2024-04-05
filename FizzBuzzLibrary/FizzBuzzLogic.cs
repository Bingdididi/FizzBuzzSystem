namespace FizzBuzzLibrary;

public class FizzBuzzLogic
{
    // public string? GetOutput(int number)
    // {
    //    return number.ToString() + "";
    // }

    public string? GetOutput(int? number)
    {
         string output = string.Empty;
        if (number < 0)
        {
            throw new Exception("Number must be greater than 0");
        }
        if (number > 100)
        {
            throw new Exception("Number can't be greater than 100");
        }
        if (number == null)
        {
            throw new Exception("Number can't be null");
        }
        if (number == 0)
        {
            output += " ";
        }
       
        for (int i = 1; i <= number; i++)
        {
             if (i % 5 == 0 && i % 3 == 0)
            {
                output += "FizzBuzz ";
            }
           
            else
           if (i % 3 == 0)
            {
                output += "Fizz ";
            }
            else
           if (i % 5 == 0)
            {
                output += "Buzz ";
            }
            else
            {
                output += $"{i} ";
            }
        }
        return output;
    }

    

}
