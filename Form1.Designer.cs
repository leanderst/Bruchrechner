namespace BruchrechnerLeander
{
    partial class Programm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programm));
            ErsterZaehler = new TextBox();
            ErsterNenner = new TextBox();
            ZweiterZaehler = new TextBox();
            ZweiterNenner = new TextBox();
            Rechner = new ComboBox();
            colorDialog1 = new ColorDialog();
            ZeahlerErgebnis = new TextBox();
            Quadant = new TextBox();
            NennerErgebnis = new TextBox();
            SuspendLayout();
            // 
            // ErsterZaehler
            // 
            ErsterZaehler.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ErsterZaehler.Location = new Point(60, 257);
            ErsterZaehler.Name = "ErsterZaehler";
            ErsterZaehler.Size = new Size(200, 47);
            ErsterZaehler.TabIndex = 1;
            ErsterZaehler.TextAlign = HorizontalAlignment.Center;
            ErsterZaehler.TextChanged += ErsterZaehler_TextChanged;
            // 
            // ErsterNenner
            // 
            ErsterNenner.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ErsterNenner.Location = new Point(60, 391);
            ErsterNenner.Name = "ErsterNenner";
            ErsterNenner.Size = new Size(200, 47);
            ErsterNenner.TabIndex = 2;
            ErsterNenner.TextAlign = HorizontalAlignment.Center;
            ErsterNenner.TextChanged += ErsterNenner_TextChanged;
            // 
            // ZweiterZaehler
            // 
            ZweiterZaehler.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ZweiterZaehler.Location = new Point(545, 257);
            ZweiterZaehler.Name = "ZweiterZaehler";
            ZweiterZaehler.Size = new Size(200, 47);
            ZweiterZaehler.TabIndex = 3;
            ZweiterZaehler.TextAlign = HorizontalAlignment.Center;
            ZweiterZaehler.Visible = false;
            ZweiterZaehler.TextChanged += ZweiterZaehler_TextChanged;
            // 
            // ZweiterNenner
            // 
            ZweiterNenner.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ZweiterNenner.Location = new Point(545, 391);
            ZweiterNenner.Name = "ZweiterNenner";
            ZweiterNenner.Size = new Size(200, 47);
            ZweiterNenner.TabIndex = 4;
            ZweiterNenner.TextAlign = HorizontalAlignment.Center;
            ZweiterNenner.Visible = false;
            ZweiterNenner.TextChanged += ZweiterNenner_TextChanged;
            // 
            // Rechner
            // 
            Rechner.DropDownHeight = 300;
            Rechner.DropDownStyle = ComboBoxStyle.DropDownList;
            Rechner.DropDownWidth = 12;
            Rechner.FlatStyle = FlatStyle.Flat;
            Rechner.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Rechner.FormattingEnabled = true;
            Rechner.IntegralHeight = false;
            Rechner.Items.AddRange(new object[] { "+", "-", "×", "÷", "∧", "√" });
            Rechner.Location = new Point(378, 327);
            Rechner.Name = "Rechner";
            Rechner.Size = new Size(45, 39);
            Rechner.TabIndex = 5;
            Rechner.SelectedIndexChanged += Rechner_SelectedIndexChanged;
            // 
            // ZeahlerErgebnis
            // 
            ZeahlerErgebnis.BackColor = SystemColors.ControlLight;
            ZeahlerErgebnis.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ZeahlerErgebnis.Location = new Point(290, 12);
            ZeahlerErgebnis.Name = "ZeahlerErgebnis";
            ZeahlerErgebnis.ReadOnly = true;
            ZeahlerErgebnis.Size = new Size(230, 52);
            ZeahlerErgebnis.TabIndex = 6;
            ZeahlerErgebnis.TextAlign = HorizontalAlignment.Center;
            ZeahlerErgebnis.Visible = false;
            ZeahlerErgebnis.TextChanged += ZeahlerErgebnis_TextChanged;
            // 
            // Quadant
            // 
            Quadant.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Quadant.Location = new Point(600, 320);
            Quadant.Name = "Quadant";
            Quadant.Size = new Size(94, 47);
            Quadant.TabIndex = 7;
            Quadant.TextAlign = HorizontalAlignment.Center;
            Quadant.Visible = false;
            Quadant.TextChanged += Quadant_TextChanged;
            // 
            // NennerErgebnis
            // 
            NennerErgebnis.BackColor = SystemColors.ControlLight;
            NennerErgebnis.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            NennerErgebnis.Location = new Point(290, 149);
            NennerErgebnis.Name = "NennerErgebnis";
            NennerErgebnis.ReadOnly = true;
            NennerErgebnis.Size = new Size(230, 52);
            NennerErgebnis.TabIndex = 8;
            NennerErgebnis.TextAlign = HorizontalAlignment.Center;
            NennerErgebnis.Visible = false;
            NennerErgebnis.TextChanged += NennerErgebnis_TextChanged;
            // 
            // Programm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(NennerErgebnis);
            Controls.Add(Quadant);
            Controls.Add(ZeahlerErgebnis);
            Controls.Add(Rechner);
            Controls.Add(ZweiterNenner);
            Controls.Add(ZweiterZaehler);
            Controls.Add(ErsterNenner);
            Controls.Add(ErsterZaehler);
            Name = "Programm";
            Load += Programm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ErsterZaehler;
        private TextBox ErsterNenner;
        private TextBox ZweiterZaehler;
        private TextBox ZweiterNenner;
        private ComboBox Rechner;
        private ColorDialog colorDialog1;
        private TextBox ZeahlerErgebnis;
        private TextBox Quadant;
        private TextBox NennerErgebnis;
    }
}