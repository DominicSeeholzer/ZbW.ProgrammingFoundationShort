namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    //random Zahl generieren
    var random = new Random();
    int geheimzahl = random.Next(1, 101);

    //variablen für Ausgaben
    bool erraten = false;
    int versuche = 0;

    while (!erraten)
    {
      //Eingabe auffordern
      Console.Write("Dein Tipp: ");
      string eingabe = Console.ReadLine() ?? "";



      //Eingabe validieren
      if (!int.TryParse(eingabe, out int tipp))
      {
        Console.WriteLine("Bitte eine ganze Zahl eingeben.");
        continue;
      }



      if (tipp < geheimzahl)
      {
        Console.WriteLine($"Dein Wert: {tipp} war zu klein");
        versuche++;
      }

      else if (tipp > geheimzahl)
      {
        Console.WriteLine($"Dein Wert: {tipp} war zu gross");
        versuche++;
      }

      else if (tipp == geheimzahl)
      {
        Console.WriteLine($"Dein Wert: {tipp} ist genau die gesuchte Zahl, du hast {versuche} gebraucht");
        versuche++;
      }

      else
      {
        return;
      }


    }
  }
}
