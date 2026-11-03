namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

// ============================================================
// AUFTRAG 2 – WochentageApp (⭐⭐ Mittel | ~30 Min.)
//
// Zeige Infos zum gewählten Wochentag.
//
// Anforderungen:
//   - CmbWochentag: ComboBox mit Mo, Di, Mi, Do, Fr, Sa, So
//   - switch expression: Werktag oder Wochenende? ("Samstag" or "Sonntag" → Wochenende)
//   - Ternärer Operator für den Ausgabetext
//   - LblErgebnis: Wochentag + Typ anzeigen, z. B. "Samstag ist ein Wochenende."
// ============================================================

public partial class WochentageAppForm : Form
{
  public WochentageAppForm()
  {
    InitializeComponent();

    //Array erstellen für jeden Wochentag
    string[] wochenTage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
    //übergib den Inhalt der Array auf jede Zeile sep. aus
    CmbWochentag.Items.AddRange(wochenTage);
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    //Gewählten Tag aus CmbWochentag lesen (CmbWochentag.Text)
    string inputTag = CmbWochentag.Text;

    //Eingabe prüfen, bevor etwas berechnet wird
    if (string.IsNullOrEmpty(inputTag))
    {
      MessageBox.Show("Wähle einen Wochentag aus", "Ungültiger Wert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    //switch expression -> bool
    bool istWerktag = true;

    istWerktag = inputTag switch
    {
      "Samstag" or "Sonntag" => false,
      _ => true
    };

    //tenärer Operator ? :
    string wochenTyp = istWerktag ? "Werktag" : "Wochenende";

    //Ergebnis anzeigen
    LblErgebnis.Text = $"{inputTag} ist ein {wochenTyp}";
  }
}
