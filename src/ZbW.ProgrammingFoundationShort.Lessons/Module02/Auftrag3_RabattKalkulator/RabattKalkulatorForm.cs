namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

// ============================================================
// AUFTRAG 3 – RabattKalkulator (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Berechne einen Rabatt anhand von Kundentyp und Lehrling-Status.
//
// Anforderungen:
//   - TxtBetrag: Kaufbetrag einlesen
//   - RadioButtons: Normal (0%), Premium (10%), VIP (20%)
//   - CheckBox: Lehrling (+5% extra Rabatt)
//   - Anzeige: Originalbetrag, Rabatt in CHF, Endbetrag (2 Nachkommastellen)
//   - Geld als decimal (Block 01)
// ============================================================

public partial class RabattKalkulatorForm : Form
{
  public RabattKalkulatorForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    //Eingabe validieren, wenn kleiner als 0 Warnmeldung
    if (!decimal.TryParse(TxtBetrag.Text, out decimal betragOutput) || betragOutput <= 0)
    {
      MessageBox.Show("Wert muss über 0 sein", "Ungültiger Wert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    int rabattWert;

    if (RadVip.Checked)
    {
      rabattWert = 20;
    }
    else if (RadPremium.Checked)
    {
      rabattWert = 10;
    }
    else
    {
      rabattWert = 0; //Normal
    }

    //Lehrlingzuschlag
    if (ChkLehrling.Checked)
    {
      rabattWert += 5;
    }

    //Rabatt in CHF und Endbetrag
    decimal rabattBetrag = betragOutput * rabattWert / 100m;
    decimal endbetrag = betragOutput - rabattBetrag;

    //Ergebnis anzeigen
    LblErgebnis.Text =
      $"Originalbetrag: {betragOutput:F2} CHF{Environment.NewLine}" +
      $"Rabatt: {rabattBetrag:F2} CHF ({rabattBetrag} %){Environment.NewLine}" +
      $"Endbetrag: {endbetrag:F2} CHF";
  }
}
