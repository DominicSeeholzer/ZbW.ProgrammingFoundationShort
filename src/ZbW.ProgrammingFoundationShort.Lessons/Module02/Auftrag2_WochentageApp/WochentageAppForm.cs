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
    string[] wochentag = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
    //übergib den Inhalt der Array auf jede Zeile sep. aus
    foreach (string w in wochentag)
    {
      CmbWochentag.Items.Add(w);
    }

    CmbWochentag.SelectedIndex = 0;

  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    //Gewählten Tag aus CmbWochentag lesen (CmbWochentag.Text)
    string inputTag = CmbWochentag.Text;

    //switch expression -> bool
    bool istWerktag = inputTag switch
    {
      "Samstag" or "Sonntag" => false,
      _ => true
    };

    //tenärer Operator ? :
    string typ = istWerktag ? "Werktag" : "Wochenende";
    LblErgebnis.Text = $"{inputTag} ist ein {typ}";
  }
}
