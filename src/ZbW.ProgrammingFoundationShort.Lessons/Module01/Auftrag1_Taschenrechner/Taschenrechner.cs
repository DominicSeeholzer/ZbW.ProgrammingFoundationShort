namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Startet den Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    //1. Zahl lesen
    Console.WriteLine("Gib die 1. Zahl ein");
    if (!double.TryParse(Console.ReadLine(), out double ersteZahl))
    {
      Console.WriteLine("Ungültige Zahl");
      return;
    }

    //2. Zahl lesen
    Console.WriteLine("GIb die 2. Zahl ein");
    if (!double.TryParse(Console.ReadLine(), out double zweiteZahl))
    {
      Console.WriteLine("Ungültige Zahl");
      return;
    }

    Console.WriteLine("Gib einen Operation ein '+', '-', '*', '/'");

    //Operator einlesen
    string operation = Console.ReadLine();


    //Berechnung durchführen

    double result;

    if (operation == "+")
    {
      result = ersteZahl + zweiteZahl;
    }

    else if (operation == "-")
    {
      result = ersteZahl - zweiteZahl;
    }

    else if (operation == "*")
    {
      result = ersteZahl * zweiteZahl;
    }

    else if (operation == "/")
    {
      if (zweiteZahl == 0)
      {
        Console.WriteLine("Durch 0 dividieren geht nicht!");
        return;
      }
      result = ersteZahl / zweiteZahl;
    }

    else
    {
      Console.WriteLine($"Unbekannter Operator: '{operation}'");
      return;
    }

    Console.WriteLine($"Ergebnis: {result:F2}");
  }
}
