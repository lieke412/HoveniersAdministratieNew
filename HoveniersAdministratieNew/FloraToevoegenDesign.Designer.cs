namespace Hoveniersadministratie
{
    partial class FloraToevoegenDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBoxNaam = new System.Windows.Forms.TextBox();
            this.TBoxJaargetijdeSnoeien = new System.Windows.Forms.TextBox();
            this.TBoxOpmerkingen = new System.Windows.Forms.TextBox();
            this.CBoxWaterAantal = new System.Windows.Forms.ComboBox();
            this.CBoxSoortFlora = new System.Windows.Forms.ComboBox();
            this.CBoxSnoeienAantal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnFloraToevoegen = new System.Windows.Forms.Button();
            this.NumUDWater = new System.Windows.Forms.NumericUpDown();
            this.NumUDSnoeien = new System.Windows.Forms.NumericUpDown();
            this.LblVerplicht = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBoxJaargetijdeWater = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDSnoeien)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxNaam
            // 
            this.TBoxNaam.Location = new System.Drawing.Point(358, 178);
            this.TBoxNaam.Name = "TBoxNaam";
            this.TBoxNaam.Size = new System.Drawing.Size(100, 22);
            this.TBoxNaam.TabIndex = 2;
            // 
            // TBoxJaargetijdeSnoeien
            // 
            this.TBoxJaargetijdeSnoeien.Location = new System.Drawing.Point(358, 291);
            this.TBoxJaargetijdeSnoeien.Name = "TBoxJaargetijdeSnoeien";
            this.TBoxJaargetijdeSnoeien.Size = new System.Drawing.Size(100, 22);
            this.TBoxJaargetijdeSnoeien.TabIndex = 4;
            // 
            // TBoxOpmerkingen
            // 
            this.TBoxOpmerkingen.Location = new System.Drawing.Point(358, 319);
            this.TBoxOpmerkingen.Name = "TBoxOpmerkingen";
            this.TBoxOpmerkingen.Size = new System.Drawing.Size(100, 22);
            this.TBoxOpmerkingen.TabIndex = 5;
            // 
            // CBoxWaterAantal
            // 
            this.CBoxWaterAantal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxWaterAantal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxWaterAantal.FormattingEnabled = true;
            this.CBoxWaterAantal.Items.AddRange(new object[] {
            "Per week",
            "Per maand",
            "Per kwartaal",
            "Per jaar"});
            this.CBoxWaterAantal.Location = new System.Drawing.Point(482, 203);
            this.CBoxWaterAantal.Name = "CBoxWaterAantal";
            this.CBoxWaterAantal.Size = new System.Drawing.Size(121, 24);
            this.CBoxWaterAantal.TabIndex = 6;
            // 
            // CBoxSoortFlora
            // 
            this.CBoxSoortFlora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxSoortFlora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSoortFlora.FormattingEnabled = true;
            this.CBoxSoortFlora.Items.AddRange(new object[] {
            "Plant",
            "Struik",
            "Boom"});
            this.CBoxSoortFlora.Location = new System.Drawing.Point(482, 120);
            this.CBoxSoortFlora.Name = "CBoxSoortFlora";
            this.CBoxSoortFlora.Size = new System.Drawing.Size(121, 24);
            this.CBoxSoortFlora.TabIndex = 7;
            // 
            // CBoxSnoeienAantal
            // 
            this.CBoxSnoeienAantal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBoxSnoeienAantal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSnoeienAantal.FormattingEnabled = true;
            this.CBoxSnoeienAantal.Items.AddRange(new object[] {
            "Per week",
            "Per maand",
            "Per kwartaal",
            "Per jaar"});
            this.CBoxSnoeienAantal.Location = new System.Drawing.Point(482, 262);
            this.CBoxSnoeienAantal.Name = "CBoxSnoeienAantal";
            this.CBoxSnoeienAantal.Size = new System.Drawing.Size(121, 24);
            this.CBoxSnoeienAantal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soort flora:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naam:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aantal keer water:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aantal keer snoeien:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tijd van het jaar:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opmerkingen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(215, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Flora toevoegen";
            // 
            // BtnFloraToevoegen
            // 
            this.BtnFloraToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFloraToevoegen.Location = new System.Drawing.Point(613, 355);
            this.BtnFloraToevoegen.Name = "BtnFloraToevoegen";
            this.BtnFloraToevoegen.Size = new System.Drawing.Size(141, 49);
            this.BtnFloraToevoegen.TabIndex = 16;
            this.BtnFloraToevoegen.Text = "Toevoegen";
            this.BtnFloraToevoegen.UseVisualStyleBackColor = true;
            this.BtnFloraToevoegen.Click += new System.EventHandler(this.BtnFloraToevoegen_Click);
            // 
            // NumUDWater
            // 
            this.NumUDWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumUDWater.Location = new System.Drawing.Point(358, 206);
            this.NumUDWater.Name = "NumUDWater";
            this.NumUDWater.Size = new System.Drawing.Size(100, 22);
            this.NumUDWater.TabIndex = 17;
            // 
            // NumUDSnoeien
            // 
            this.NumUDSnoeien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumUDSnoeien.Location = new System.Drawing.Point(358, 262);
            this.NumUDSnoeien.Name = "NumUDSnoeien";
            this.NumUDSnoeien.Size = new System.Drawing.Size(100, 22);
            this.NumUDSnoeien.TabIndex = 18;
            // 
            // LblVerplicht
            // 
            this.LblVerplicht.AutoSize = true;
            this.LblVerplicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerplicht.Location = new System.Drawing.Point(215, 355);
            this.LblVerplicht.Name = "LblVerplicht";
            this.LblVerplicht.Size = new System.Drawing.Size(70, 15);
            this.LblVerplicht.TabIndex = 19;
            this.LblVerplicht.Text = "* = verplicht";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tijd van het jaar:*";
            // 
            // TBoxJaargetijdeWater
            // 
            this.TBoxJaargetijdeWater.Location = new System.Drawing.Point(358, 234);
            this.TBoxJaargetijdeWater.Name = "TBoxJaargetijdeWater";
            this.TBoxJaargetijdeWater.Size = new System.Drawing.Size(100, 22);
            this.TBoxJaargetijdeWater.TabIndex = 20;
            // 
            // FloraToevoegenDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBoxJaargetijdeWater);
            this.Controls.Add(this.LblVerplicht);
            this.Controls.Add(this.NumUDSnoeien);
            this.Controls.Add(this.NumUDWater);
            this.Controls.Add(this.BtnFloraToevoegen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxSnoeienAantal);
            this.Controls.Add(this.CBoxSoortFlora);
            this.Controls.Add(this.CBoxWaterAantal);
            this.Controls.Add(this.TBoxOpmerkingen);
            this.Controls.Add(this.TBoxJaargetijdeSnoeien);
            this.Controls.Add(this.TBoxNaam);
            this.Name = "FloraToevoegenDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FloraToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDSnoeien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBoxNaam;
        private System.Windows.Forms.TextBox TBoxJaargetijdeSnoeien;
        private System.Windows.Forms.TextBox TBoxOpmerkingen;
        private System.Windows.Forms.ComboBox CBoxWaterAantal;
        private System.Windows.Forms.ComboBox CBoxSoortFlora;
        private System.Windows.Forms.ComboBox CBoxSnoeienAantal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnFloraToevoegen;
        private System.Windows.Forms.NumericUpDown NumUDWater;
        private System.Windows.Forms.NumericUpDown NumUDSnoeien;
        private System.Windows.Forms.Label LblVerplicht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBoxJaargetijdeWater;
    }
}