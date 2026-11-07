namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

// ============================================================
// AUFTRAG 3 – Datentyp-Quiz (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Erstelle ein Konsolen-Quiz mit 5 Fragen zu C#-Datentypen und Operatoren.
//
// Anforderungen:
//   - Fragen per Console.Write ausgeben, Antwort mit Console.ReadLine() einlesen
//   - Gross-/Kleinschreibung ignorieren: .Trim().ToLower()
//   - Mindestens 1 Frage erwartet eine Zahl → mit int.TryParse prüfen
//   - Am Ende: $"Resultat: {punkte}/5" ausgeben
//   - Bonus: Gesamtzeit mit Stopwatch messen
//
// Frage 1 ist als Beispiel fertig. Ergänze die Fragen 2–5.
// ============================================================

public static class DatentypQuiz
{
  /// <summary>
  ///   Startet das Quiz auf der Konsole.
  /// </summary>
  public static void Start()
  {

    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    // TODO (Bonus): Stopwatch starten
    //         var stopwatch = System.Diagnostics.Stopwatch.StartNew();

    int punkte = 0;

    // ── Frage 1 (Beispiel, Textantwort) ──────────────────────
    Console.Write("Frage 1: Welcher Datentyp speichert true/false? ");
    string antwort1 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort1 == "bool")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: bool");
    }

    // TODO 2: Frage 2 (Text) – z. B. «Welcher Typ eignet sich für Geldbeträge?» → decimal
    Console.WriteLine("Frage 2: Welcher Typ eignet sich für Geldbeträge?");
    string antwort2 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort2 == "decimal")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Die Richtige Antwort wäre: 'decimal'");
    }

    // TODO 3: Frage 3 (Zahl) – z. B. «Was ergibt 7 / 2, wenn beide Zahlen int sind?» → 3
    Console.WriteLine("Frage 3: Was ergibt 7 / 2, wenn beide Zahlen int sind?");
    if (int.TryParse(Console.ReadLine() ?? "", out int antwort3) && antwort3 == 3)
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }

    else
    {
      Console.WriteLine("  Falsch. Die Richtige Antwort wäre: '3'");
    }
    // TODO 4: Frage 4 (Zahl) – z. B. «Was ergibt 10 % 3?» → 1
    Console.WriteLine("Frage 4: Was gibt 10 % 3?");
    if (int.TryParse(Console.ReadLine() ?? "", out int antwort4) && antwort4 == 1)
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }

    else
    {
      Console.WriteLine("  Falsch. Die Richtige Antwort wäre: '1'");
    }

    // TODO 5: Frage 5 (Text) – z. B. «Welcher Typ speichert genau ein Zeichen?» → char
    Console.WriteLine("Frage 5: Welcher Typ speichert genau ein Zeichen?");
    string antwort5 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort5 == "char")
    {
      Console.WriteLine("  Richtigè");
      punkte++;
    }

    else
    {
      Console.WriteLine("  Falsch. Die richtige Antwort wäre 'char'");
    }

    Console.WriteLine($"Resultat: {punkte}/5");

    stopwatch.Stop();
    Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }
}
