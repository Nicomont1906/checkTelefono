# Check Telefono

Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota ""
```
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
```

