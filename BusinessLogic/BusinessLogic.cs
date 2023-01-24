namespace BusinessLogic;
public class FactorialService
{
    public static int CalculateFactorial(int input)
    {
        if (input < 0)
        {
            throw new Exception("No negatives");
        }

        else if (input == 0)
        {
            return 1;
        }

        int result = 1;
        for (int i = 1; i <= input; i++)
        {
            result *= i;
        }
        return result;
    }
}
