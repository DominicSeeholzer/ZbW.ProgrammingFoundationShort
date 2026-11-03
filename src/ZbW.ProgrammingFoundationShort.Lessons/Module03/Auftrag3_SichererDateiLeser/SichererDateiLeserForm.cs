namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

// ============================================================
// AUFTRAG 3 – SichererDateiLeser (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Liest eine Datei mit try-catch-finally ab und zeigt Zeilen an.
//
// Anforderungen:
//   - TxtPfad: Dateipfad eingeben
//   - try: File.ReadAllLines, for-Schleife mit Zeilennummer
//   - catch FileNotFoundException: eigene Meldung
//   - catch Exception: allgemeiner Fehler
//   - vor dem Lesen CmdLesen deaktivieren, im finally wieder aktivieren
// ============================================================

public partial class SichererDateiLeserForm : Form
{
  public SichererDateiLeserForm()
  {
    InitializeComponent();
  }

  private void CmdLesen_Click(object sender, EventArgs e)
  {
    LstZeilen.Items.Clear();
    LblStatus.Text = "Lese...";
    CmdLesen.Enabled = false;

    try
    {
      //Datei einlesen
      string[] zeilen = File.ReadAllLines(TxtPfad.Text);

      // Zeilen mit Nummer in ListBox laden
      for (int i = 0; i < zeilen.Length; i++)
      {
        LstZeilen.Items.Add($"{i + 1,4}: {zeilen[i]}");
      }

      LblStatus.Text = $"{zeilen.Length} Zeile(n) geladen.";
    }


    catch (FileNotFoundException)
    {
      MessageBox.Show($"Die Datei wurde nicht gefunden\r\n {LstZeilen.Text}",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
      LblStatus.Text = "Datei wurde nicht gefunden.";
    }

    catch (Exception ex)
    {
      MessageBox.Show($"Fehler beim lesen {ex.Message}",
        "Allgemeiner Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
      LblStatus.Text = "Fehler beim Lesen.";
    }


    finally
    {
      // finally wird immer ausgeführt – egal ob Erfolg oder Fehler
      CmdLesen.Enabled = true;
    }
  }
}
