namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    //variablen erstellen
    string passwort;
    bool gueltig;

    do
    {
      //Passwort eingeben und in variable speichern
      Console.WriteLine("Passwort eingeben:");
      passwort = Console.ReadLine() ?? "";

      //Zeichen überprüfen
      bool hatZiffer = false;
      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }

      //Passwort länge überprüfen mind. 8 und Ziffer erforderlich
      gueltig = passwort.Length >= 8 && hatZiffer;
      if (!gueltig)
      {
        Console.WriteLine("Ungültiges Passwort!");
        if (passwort.Length < 8)
        {
          Console.WriteLine("  - Mindestens 8 Zeichen erforderlich.");
        }

        if (!hatZiffer)
        {
          Console.WriteLine("  - Mindestens eine Ziffer erforderlich.");
        }
      } //wenn gültig Text ausgeben
    } while (!gueltig);
      Console.WriteLine("Passwort ist gültig");
  }
}
