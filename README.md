# Check Telefono

Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota 
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

> Questo codice rappresenta una classe chiamata "Telefono" contente un metodo chiamato "Check" che prende in input un array di stringhe chiamto numeri. Nel metodo "Check" viene utilizzato un ciclo "foreach" che attraversa ciascuna stringa presente nell'array "numeri". All'interno del ciclo viene inizializzata una stringa vuota chiamata "num" che viene utilizzata per costruire un numero di telefono. Viene eseguito un altro ciclo "foreach" che attraversa ciascun carattere nella stringa "numero" 
e per ciascun carattere, viene verificato se è un carattere numerico (0-9) o se è il primo carattere della stringa ed è un segno "+". Se il carattere soddisfa una delle condizioni,viene aggiunto alla stringa "num".

```
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
```
Qui viene verificato se la stringa "num" rappresenta un numero di telefono italiano valido. La validità viene verificata in base alla lunghezza della stringa e al suo prefisso. Se la stringa soddisfa una delle tre condizioni,viene restituita come un numero di telefono valido; altrimenti, viene restituita una stringa vuota. Le tre condizioni sono le seguenti:

Inizia con "+39" e ha una lunghezza di 13 o 14 caratteri.
Inizia con "0039" e ha una lunghezza di 14 o 15 caratteri.
Inizia con "3" e ha una lunghezza di 10 o 11 caratteri.

In caso contrario, il metodo restituirà una stringa vuota

