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
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    var random = new Random();
    int geheimZahl = random.Next(0, 101);

    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int versuche = 0;
    bool geraten = false;

    Console.WriteLine("=== Zahlenraten (1–100) ===");
    Console.WriteLine("Versuche die geheime Zahl zu erraten!");

    // TODO 3: while-Schleife (!geraten)
    while (!geraten)
    {
      Console.Write("Dein Tipp: ");

      string eingabe = Console.ReadLine() ?? "";

      if (!int.TryParse(eingabe, out int tipp))
      {
        MessageBox.Show("Gib eine Zahl ein!", "Ungültige Zahl", MessageBoxButtons.OK, MessageBoxIcon.Error);
        continue;
      }

      versuche++;

      if (tipp < geheimZahl)
      {
        Console.WriteLine("Zu klein");
      }

      else if (tipp > geheimZahl)
      {
        Console.WriteLine("Zu gross");
      }

      else
      {
        geraten = true;
        Console.WriteLine($"Richtig! Du hast die Zahl '{geheimZahl}' mit {versuche} Versuche/n erraten.");
      }

    }
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen

    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
  }
}
