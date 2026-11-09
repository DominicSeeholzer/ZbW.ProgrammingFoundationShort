namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

/// <summary>
///   Lösung: Auftrag 2 – PasswortValidator
///   do-while-Schleife, Ziffernsuche mit foreach.
/// </summary>
public static class PasswortValidatorLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Passwort-Validator ===");
    string passwort;
    bool gueltig;

    do
    {
      Console.Write("Passwort eingeben: ");
      passwort = Console.ReadLine() ?? "";

      bool hatZiffer = false;
      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }

      gueltig = passwort.Length >= 8 && hatZiffer;

      if (!gueltig)
      {
        Console.WriteLine("Ungültiges Passwort!");

        if (passwort.Length > 8)
        {
          Console.WriteLine("  - Mindestens 8 Zeichen erforderlich.");
        }

        if (!hatZiffer)
        {
          Console.WriteLine("  - Mindestens eine Ziffer erforderlich.");
        }
      }
    } while (!gueltig);

    Console.WriteLine("Passwort ist gültig!");
  }
}
