using System;

namespace CalculatorQuest;

public class Calc
{
    private string[] _sign = { "+", "-", "x", "/", "%" };

    public Calc()
    {
    }

    public int Operator(string calcul)
    {
        int result = 0;
        string[] calculs = calcul.Split(_sign, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[calculs.Length];
        for (int i = 0; i < calculs.Length; i++)
        {
            numbers[i] = int.Parse(calculs[i]);
        }

        if (calcul.Contains("+"))
        {
            result = numbers[0] + numbers[1];
        }
        else if (calcul.Contains("-"))
        {
            result = numbers[0] - numbers[1];
        }
        else if (calcul.Contains("x"))
        {
            result = numbers[0] * numbers[1];
        }
        else if (calcul.Contains("/"))
        {
            if (numbers[1] == 0)
            {
                throw new DivideByZeroException();
            }
            result = numbers[0] / numbers[1];
        }
        else if (calcul.Contains("%"))
        {
            if (numbers[1] == 0)
            {
                throw new DivideByZeroException();
            }
            result = numbers[0] % numbers[1];
        }
        else 
        {
            result = numbers[0];
        }

        return result;
    }
}