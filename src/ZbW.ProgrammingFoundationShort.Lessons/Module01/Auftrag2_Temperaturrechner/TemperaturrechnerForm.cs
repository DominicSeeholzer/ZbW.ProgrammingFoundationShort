namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {

    if (!double.TryParse(TxtCelsius.Text, out double celsius))
    {
      MessageBox.Show($"Ungültiger Wert: {celsius}", "Ungültiger Wert", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Der Eingegebene Wert '{celsius}' liegt unter der ABsolutenZero");
      return;
    }

    double fahrenheit = celsius * 9.0 / 5.0 + 32;

    TxtFahrenheit.Text = ($"{fahrenheit:F2}");
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtFahrenheit.Text, out double fahrenheit))
    {
      MessageBox.Show($"Ungültiger Wert: {fahrenheit}", "Ungültiger Wert", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    double celsius = (fahrenheit - 32) * 5.0 / 9.0;

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Das Ergebnis '{celsius}' liegt unter dem gefrierpunkt!", "Tiefe Temperatur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    TxtCelsius.Text = ($"{celsius}");


    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0

    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")
  }
}
