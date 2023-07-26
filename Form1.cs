using System.CodeDom.Compiler;
using System.Diagnostics;

namespace BruchrechnerLeander
{
    public partial class Programm : Form
    {
        public Programm()
        {
            this.Text = "GrinsenderBruchRechner";//Programm Titel wird geändert
            InitializeComponent();
        }
        private void Programm_Load(object sender, EventArgs e)
        {
        }
        private void ErsterZaehler_TextChanged(object sender, EventArgs e)
        {
            ErgebnisAnzeigeKontrolleMitQuadant();//Wenn etwas im ersten Zähler eingegeben wird wird überprüft ob alles passt und wenn alles passt wird das ergebnis ausgerechnet.
        }
        private void ErsterNenner_TextChanged(object sender, EventArgs e)
        {
            ErgebnisAnzeigeKontrolleMitQuadant();//Wenn etwas im ersten Nenner eingegeben wird wird überprüft ob alles passt und wenn alles passt wird das ergebnis ausgerechnet.
        }
        private void ZweiterZaehler_TextChanged(object sender, EventArgs e)
        {
            ErgebnisAnzeigeKontrolleOhneQuadant();//Wenn etwas im zweiten Zähler eingegeben wird wird überprüft ob alles passt und wenn alles passt wird das ergebnis ausgerechnet.
        }
        private void ZweiterNenner_TextChanged(object sender, EventArgs e)
        {
            ErgebnisAnzeigeKontrolleOhneQuadant();//Wenn etwas im zweiten Nenner eingegeben wird wird überprüft ob alles passt und wenn alles passt wird das ergebnis ausgerechnet.
        }
        private void Rechner_SelectedIndexChanged(object sender, EventArgs e)//Wird ausgeführt wenn der ein Rechenzeichen ausgewählt wurde
        {
            if (Rechner.SelectedIndex < 4) //Wenn das Rechenzeichen +, -, * oder / ist
            {
                ZweiterNenner.Visible = true;
                ZweiterZaehler.Visible = true;//Der zweite Bruch wird angezeigt
                Quadant.Visible = false;//Der Quadant wird unsichtbar gemacht
                if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && ZweiterZaehler.Text != "" && ZweiterNenner.Text != "")//Kontrolle ob es leere Textfelder gibt
                {
                    ErgebnisAnzeige();//Ergebnis wird ausgerechnet
                }
            }
            else//Wenn das Rechenzeichen ^ oder √ ist
            {
                Quadant.Visible = true;//Der Quadant wird angezeigt
                ZweiterNenner.Visible = false;
                ZweiterZaehler.Visible = false;//Der zweite Bruch wird Unsichtbar gemacht
                if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && Quadant.Text != "")
                {
                    ErgebnisAnzeige();
                }
            }
        }
        private void Quadant_TextChanged(object sender, EventArgs e)//Wird ausgeführt wenn etwas im Quadant eingegeben wird
        {
            if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && Quadant.Text != "")
            {
                ErgebnisAnzeige();
            }
        }

        private void ZeahlerErgebnis_TextChanged(object sender, EventArgs e)
        {
        }

        private void NennerErgebnis_TextChanged(object sender, EventArgs e)
        {
        }

        private void ErgebnisAnzeige()
        {
            if (Rechner.SelectedIndex < 4)
            {
                if (double.TryParse(ErsterZaehler.Text, out double z1) && double.TryParse(ErsterNenner.Text, out double n1) && double.TryParse(ZweiterNenner.Text, out double z2) && double.TryParse(ZweiterZaehler.Text, out double n2))//Kontrolle ob andere Textzeichen als Zahlen im den beiden Brüchen stehen.
                {
                    Ergebnis();//Das ergebnis wird ausgerechnet und angezeigt
                }
            }
            else
            {
                if (double.TryParse(ErsterZaehler.Text, out double z12) && double.TryParse(ErsterNenner.Text, out double n12) && double.TryParse(Quadant.Text, out double z22))//Kontrolle ob andere Textzeichen als Zahlen im ersten Bruch und dem Quadant steht
                {
                    Ergebnis();
                }
            }
        }
        private void Ergebnis()
        {
            double kgV;
            switch (Rechner.SelectedIndex)//Das Ergebnis wird jeh nach Wahl des Rechenzeichen ausgerechnet
            {
                case 0:// +
                    kgV = KGV(Convert.ToDouble(ErsterNenner.Text), Convert.ToDouble(ZweiterNenner.Text));//kgV wird ausgerechnet
                    ZeahlerErgebnis.Text = Convert.ToString((Convert.ToDouble(ErsterZaehler.Text) * (kgV / Convert.ToDouble(ErsterNenner.Text)) + (Convert.ToDouble(ZweiterZaehler.Text) * (kgV / Convert.ToDouble(ZweiterNenner.Text)))));//Der Zähler wird ausgerechnet
                    NennerErgebnis.Text = Convert.ToString(kgV);//Der Nenner wird ausgerechnet
                    break;
                case 1:// -
                    kgV = KGV(Convert.ToDouble(ErsterNenner.Text), Convert.ToDouble(ZweiterNenner.Text));
                    ZeahlerErgebnis.Text = Convert.ToString((Convert.ToDouble(ErsterZaehler.Text) * (kgV / Convert.ToDouble(ErsterNenner.Text)) - (Convert.ToDouble(ZweiterZaehler.Text) * (kgV / Convert.ToDouble(ZweiterNenner.Text)))));
                    NennerErgebnis.Text = Convert.ToString(kgV);
                    break;
                case 2:// *
                    ZeahlerErgebnis.Text = Convert.ToString(Convert.ToDouble(ErsterZaehler.Text) * Convert.ToDouble(ZweiterZaehler.Text));
                    NennerErgebnis.Text = Convert.ToString(Convert.ToDouble(ErsterNenner.Text) * Convert.ToDouble(ZweiterNenner.Text));
                    break;
                case 3:// /
                    ZeahlerErgebnis.Text = Convert.ToString(Convert.ToDouble(ErsterZaehler.Text) * Convert.ToDouble(ZweiterNenner.Text));
                    NennerErgebnis.Text = Convert.ToString(Convert.ToDouble(ErsterNenner.Text) * Convert.ToDouble(ZweiterZaehler.Text));
                    break;
                case 4:// ^
                    ZeahlerErgebnis.Text = Convert.ToString(Math.Pow(Convert.ToDouble(ErsterZaehler.Text), Convert.ToDouble(Quadant.Text)));
                    NennerErgebnis.Text = Convert.ToString(Math.Pow(Convert.ToDouble(ErsterNenner.Text), Convert.ToDouble(Quadant.Text)));
                    break;
                case 5:// √
                    ZeahlerErgebnis.Text = Convert.ToString(Math.Pow(Convert.ToDouble(ErsterZaehler.Text), 1 / Convert.ToDouble(Quadant.Text)));
                    NennerErgebnis.Text = Convert.ToString(Math.Pow(Convert.ToDouble(ErsterNenner.Text), 1 / Convert.ToDouble(Quadant.Text)));
                    break;
            }
            double ggt = GGT(Convert.ToDouble(ZeahlerErgebnis.Text), Convert.ToDouble(NennerErgebnis.Text));//GGT wird ausgerechnet
            double temp = Convert.ToDouble(ZeahlerErgebnis.Text);//Der Inhalt vom Zähler des Ergebnis wird in temp gespeichert
            ZeahlerErgebnis.Text = Convert.ToString(temp /= ggt);//Der Zähler vom Ergebnis wird gekürzt
            temp = Convert.ToDouble(NennerErgebnis.Text);//Der Inhalt vom Nenner des Ergebnis wird in temp gespeichert
            NennerErgebnis.Text = Convert.ToString(temp /= ggt);//Der Nenner vom Ergebnis wird gekürzt
            ZeahlerErgebnis.Visible = true;
            NennerErgebnis.Visible = true;//Der Ergebnisbruch wird angezeigt
        }
        private double KGV(double Zahl1, double Zahl2)//KGV wird ausgerechnet
        {
            Zahl1 = (UInt64)Zahl1;
            Zahl2 = (UInt64)Zahl2;
            double MAX = Math.Max(Zahl1, Zahl2);
            double MIN = Math.Min(Zahl1, Zahl2);
            double KGV = MAX;
            while (KGV % MIN != 0)
            {
                KGV += MAX;
            }
            return KGV;
        }
        private double GGT(double Zahl1, double Zahl2)//GGT wird ausgerechnet
        {
            Zahl1 = (UInt64)Zahl1;
            Zahl2 = (UInt64)Zahl2;
            while (Zahl2 != 0)
            {
                double temp = Zahl2;
                Zahl2 = Zahl1 % Zahl2;
                Zahl1 = temp;
            }
            return Zahl1;
        }
        private void ErgebnisAnzeigeKontrolleMitQuadant()//Kontrolle befohr der Ausrechnung
        {
            if (Rechner.TabIndex < 4)
            {
                if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && ZweiterZaehler.Text != "" && ZweiterNenner.Text != "")
                {
                    ErgebnisAnzeige();
                }
            }
            else
            {
                if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && Quadant.Text != "")
                {
                    ErgebnisAnzeige();
                }
            }
        }
        private void ErgebnisAnzeigeKontrolleOhneQuadant()//Kontrolle befohr der Ausrechnung
        {
            if (ErsterZaehler.Text != "" && ErsterNenner.Text != "" && ZweiterZaehler.Text != "" && ZweiterNenner.Text != "")
            {
                ErgebnisAnzeige();
            }
        }
    }
}