namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern

    int[] array = new int[5];
    Console.WriteLine("----Statistik Rechner----");
    Console.WriteLine("Du musst 5 Zahlen eingeben");

    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"Zahl {i + 1}: ");

      while (!int.TryParse(Console.ReadLine(), out array[i]))
      {
        Console.WriteLine("Ungültige Eingabe  ");
      }
    }


    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)},
    //         Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");
    Console.WriteLine($"Min: {Minimum(array)}");
    Console.WriteLine($"Max: {Maximum(array)}");
    Console.WriteLine($"Avg: {Average(array)}");
    
  }

  public static int Minimum(int[] zahlen)
  {
    // TODO: Kleinste Zahl finden (Schleife, kein LINQ)
    int min = zahlen[0];
    for (int z = 0; z < zahlen.Length; z++)
    {
      if (zahlen[z] < min)
      {
        min = zahlen[z];
      }
    }
    return min;
  }

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)
    int max = zahlen[0];
    for (int z = 0; z < zahlen.Length; z++)
    {
      if (zahlen[z] > max)
      {
        max = zahlen[z];
      }
    }
    return max;
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)
    double summe = 0;
    for (int z = 0; z < zahlen.Length; z++)
    {
      summe += zahlen[z];
    }
    return summe / zahlen.Length;
  }
}
