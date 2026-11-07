namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    //Eingabe validieren
    if (!int.TryParse(TxtPunkte.Text, out int punkte))
    {
      MessageBox.Show($"Der Eingegebene Wert {TxtPunkte.Text} ist ungültig!");
      return;
    }

    int note;
    string bewertung;

    if (punkte >= 90)
    {
      note = 6;
      bewertung = "Sehr gut";
    }

    else if (punkte >= 75)
    {
      note = 5;
      bewertung = "Gut";
    }

    else if (punkte >= 60)
    {
      note = 4;
      bewertung = "genügend";
    }

    else
    {
      note = 3;
      bewertung = "ungenügend";
    }

    LblNote.Text = $"Du hast die Note: {note}";
    LblBewertung.Text = $"Bewertung: {bewertung}";

  }
}
