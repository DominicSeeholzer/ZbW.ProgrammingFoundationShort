namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_TemperaturAuswertung;

partial class TemperaturAuswertungForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblMo = new Label();
    TxtMo = new TextBox();
    LblDi = new Label();
    TxtDi = new TextBox();
    LblMi = new Label();
    TxtMi = new TextBox();
    LblDo = new Label();
    TxtDo = new TextBox();
    LblFr = new Label();
    TxtFr = new TextBox();
    LblSa = new Label();
    TxtSa = new TextBox();
    LblSo = new Label();
    TxtSo = new TextBox();
    CmdAuswerten = new Button();
    LblDurchschnitt = new Label();
    LblMax = new Label();
    LblMin = new Label();
    SuspendLayout();

    LblMo.AutoSize = true;
    LblMo.Location = new Point(12, 20);
    LblMo.Name = "LblMo";
    LblMo.Text = "Mo:";
    TxtMo.Location = new Point(60, 17);
    TxtMo.Name = "TxtMo";
    TxtMo.Size = new Size(80, 23);

    LblDi.AutoSize = true;
    LblDi.Location = new Point(12, 50);
    LblDi.Name = "LblDi";
    LblDi.Text = "Di:";
    TxtDi.Location = new Point(60, 47);
    TxtDi.Name = "TxtDi";
    TxtDi.Size = new Size(80, 23);

    LblMi.AutoSize = true;
    LblMi.Location = new Point(12, 80);
    LblMi.Name = "LblMi";
    LblMi.Text = "Mi:";
    TxtMi.Location = new Point(60, 77);
    TxtMi.Name = "TxtMi";
    TxtMi.Size = new Size(80, 23);

    LblDo.AutoSize = true;
    LblDo.Location = new Point(12, 110);
    LblDo.Name = "LblDo";
    LblDo.Text = "Do:";
    TxtDo.Location = new Point(60, 107);
    TxtDo.Name = "TxtDo";
    TxtDo.Size = new Size(80, 23);

    LblFr.AutoSize = true;
    LblFr.Location = new Point(12, 140);
    LblFr.Name = "LblFr";
    LblFr.Text = "Fr:";
    TxtFr.Location = new Point(60, 137);
    TxtFr.Name = "TxtFr";
    TxtFr.Size = new Size(80, 23);

    LblSa.AutoSize = true;
    LblSa.Location = new Point(12, 170);
    LblSa.Name = "LblSa";
    LblSa.Text = "Sa:";
    TxtSa.Location = new Point(60, 167);
    TxtSa.Name = "TxtSa";
    TxtSa.Size = new Size(80, 23);

    LblSo.AutoSize = true;
    LblSo.Location = new Point(12, 200);
    LblSo.Name = "LblSo";
    LblSo.Text = "So:";
    TxtSo.Location = new Point(60, 197);
    TxtSo.Name = "TxtSo";
    TxtSo.Size = new Size(80, 23);

    CmdAuswerten.Location = new Point(12, 235);
    CmdAuswerten.Name = "CmdAuswerten";
    CmdAuswerten.Size = new Size(130, 28);
    CmdAuswerten.Text = "Auswerten";
    CmdAuswerten.Click += CmdAuswerten_Click;

    LblDurchschnitt.AutoSize = true;
    LblDurchschnitt.Location = new Point(12, 275);
    LblDurchschnitt.Name = "LblDurchschnitt";
    LblDurchschnitt.Text = "";

    LblMax.AutoSize = true;
    LblMax.Location = new Point(12, 295);
    LblMax.Name = "LblMax";
    LblMax.Text = "";

    LblMin.AutoSize = true;
    LblMin.Location = new Point(12, 315);
    LblMin.Name = "LblMin";
    LblMin.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(280, 345);
    Controls.Add(LblMo);
    Controls.Add(TxtMo);
    Controls.Add(LblDi);
    Controls.Add(TxtDi);
    Controls.Add(LblMi);
    Controls.Add(TxtMi);
    Controls.Add(LblDo);
    Controls.Add(TxtDo);
    Controls.Add(LblFr);
    Controls.Add(TxtFr);
    Controls.Add(LblSa);
    Controls.Add(TxtSa);
    Controls.Add(LblSo);
    Controls.Add(TxtSo);
    Controls.Add(CmdAuswerten);
    Controls.Add(LblDurchschnitt);
    Controls.Add(LblMax);
    Controls.Add(LblMin);
    Name = "TemperaturAuswertungForm";
    Text = "Temperatur-Auswertung – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblMo;
  private TextBox TxtMo;
  private Label LblDi;
  private TextBox TxtDi;
  private Label LblMi;
  private TextBox TxtMi;
  private Label LblDo;
  private TextBox TxtDo;
  private Label LblFr;
  private TextBox TxtFr;
  private Label LblSa;
  private TextBox TxtSa;
  private Label LblSo;
  private TextBox TxtSo;
  private Button CmdAuswerten;
  private Label LblDurchschnitt;
  private Label LblMax;
  private Label LblMin;
}
