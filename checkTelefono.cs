using System;
using System.Collections.Generic;

public class Telefono
{
    public static string Check(string[] numeri)
    {
        foreach (string numero in numeri)
        {
            string num = "";

            foreach (char c in numero)
            {
                if (char.IsDigit(c) || (num.Length == 0 && c == '+'))
                {
                    num += c;
                }
            }

            if ((num.StartsWith("+39") && (num.Length == 13 || num.Length == 14)) ||
                (num.StartsWith("0039") && (num.Length == 14 || num.Length == 15)) ||
                (num.StartsWith("3") && (num.Length == 10 || num.Length == 11)))
            {
                return num;
            }
        }

        return "";
    }
}

