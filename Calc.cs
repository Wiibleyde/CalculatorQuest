using System;

namespace CalculatorQuest;

public class Calc
{
    private string[] _sign = { "+", "-", "x", "/", "%" };

    public Calc()
    {
    }

    public decimal Operator(string calcul)
    {
        char[] operators = { '+', '-', 'x', '/', '%' };

        string[] parts = calcul.Split(operators);

        if (parts.Length < 2)
        {
            throw new ArgumentException("Invalid input string. At least two operands are required.");
        }

        if (!decimal.TryParse(parts[0].Replace('.', ','), out decimal result))
        {
            throw new ArgumentException($"Invalid number '{parts[0]}' in the input string.");
        }

        for (int i = 1; i < parts.Length; i++)
        {
            int operatorIndex = calcul.IndexOfAny(operators, parts[i - 1].Length);

            if (operatorIndex == -1 || operatorIndex == calcul.Length - 1)
            {
                throw new ArgumentException($"Invalid input string. Operator missing after '{parts[i - 1]}'.");
            }

            char op = calcul[operatorIndex];

            if (!decimal.TryParse(parts[i].Replace('.', ','), out decimal operand))
            {
                throw new ArgumentException($"Invalid number '{parts[i]}' in the input string.");
            }

            switch (op)
            {
                case '+':
                    result += operand;
                    break;
                case '-':
                    result -= operand;
                    break;
                case 'x':
                    result *= operand;
                    break;
                case '/':
                    if (operand == 0)
                        throw new DivideByZeroException();
                    result /= operand;
                    break;
                case '%':
                    if (operand == 0)
                        throw new DivideByZeroException();
                    result %= operand;
                    break;
                default:
                    throw new ArgumentException($"Invalid operator '{op}' in the input string.");
            }
        }

        return result;
    }
}
