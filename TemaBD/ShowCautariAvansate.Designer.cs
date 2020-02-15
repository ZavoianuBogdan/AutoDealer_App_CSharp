namespace TemaBD
{
    partial class ShowCautariAvansate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCautariAvansate));
            this.buttonSpecial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPret1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPret2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNevandtue = new System.Windows.Forms.Button();
            this.buttonMedie = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonVandute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewRezultate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSpecial
            // 
            this.buttonSpecial.Location = new System.Drawing.Point(308, 301);
            this.buttonSpecial.Name = "buttonSpecial";
            this.buttonSpecial.Size = new System.Drawing.Size(75, 26);
            this.buttonSpecial.TabIndex = 1;
            this.buttonSpecial.Text = "Cauta";
            this.buttonSpecial.UseVisualStyleBackColor = true;
            this.buttonSpecial.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelele fara nicio vanzare";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelele vandute pentru un pret mai mare decat media vanzarilor:";
            // 
            // numericUpDownPret1
            // 
            this.numericUpDownPret1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPret1.Location = new System.Drawing.Point(16, 307);
            this.numericUpDownPret1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPret1.Name = "numericUpDownPret1";
            this.numericUpDownPret1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPret1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 73);
            this.label3.TabIndex = 7;
            this.label3.Text = "Masini vandute de un angajat ce a avut cel putin 2 facturi realizate, cu valoarea" +
    " masinii intre valorile:";
            // 
            // numericUpDownPret2
            // 
            this.numericUpDownPret2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPret2.Location = new System.Drawing.Point(182, 307);
            this.numericUpDownPret2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPret2.Name = "numericUpDownPret2";
            this.numericUpDownPret2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPret2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "----------------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = ">=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "----------------------------------------------------------------------------";
            // 
            // buttonNevandtue
            // 
            this.buttonNevandtue.Location = new System.Drawing.Point(308, 12);
            this.buttonNevandtue.Name = "buttonNevandtue";
            this.buttonNevandtue.Size = new System.Drawing.Size(75, 26);
            this.buttonNevandtue.TabIndex = 17;
            this.buttonNevandtue.Text = "Cauta";
            this.buttonNevandtue.UseVisualStyleBackColor = true;
            this.buttonNevandtue.Click += new System.EventHandler(this.buttonNevandtue_Click);
            // 
            // buttonMedie
            // 
            this.buttonMedie.Location = new System.Drawing.Point(308, 97);
            this.buttonMedie.Name = "buttonMedie";
            this.buttonMedie.Size = new System.Drawing.Size(75, 26);
            this.buttonMedie.TabIndex = 18;
            this.buttonMedie.Text = "Cauta";
            this.buttonMedie.UseVisualStyleBackColor = true;
            this.buttonMedie.Click += new System.EventHandler(this.buttonMedie_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonClear.Location = new System.Drawing.Point(151, 344);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 36);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonVandute
            // 
            this.buttonVandute.Location = new System.Drawing.Point(308, 160);
            this.buttonVandute.Name = "buttonVandute";
            this.buttonVandute.Size = new System.Drawing.Size(75, 26);
            this.buttonVandute.TabIndex = 24;
            this.buttonVandute.Text = "Cauta";
            this.buttonVandute.UseVisualStyleBackColor = true;
            this.buttonVandute.Click += new System.EventHandler(this.buttonVandute_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "Modelele ce au avut vanzari";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 34);
            this.label8.TabIndex = 25;
            this.label8.Text = "----------------------------------------------------------------------------";
            // 
            // dataGridViewRezultate
            // 
            this.dataGridViewRezultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezultate.Location = new System.Drawing.Point(426, 12);
            this.dataGridViewRezultate.Name = "dataGridViewRezultate";
            this.dataGridViewRezultate.RowHeadersWidth = 45;
            this.dataGridViewRezultate.Size = new System.Drawing.Size(362, 368);
            this.dataGridViewRezultate.TabIndex = 26;
            // 
            // ShowCautariAvansate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.dataGridViewRezultate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonVandute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMedie);
            this.Controls.Add(this.buttonNevandtue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPret2);
            this.Controls.Add(this.numericUpDownPret1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpecial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCautariAvansate";
            this.Text = "Cautari Avansate";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSpecial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPret1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPret2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNevandtue;
        private System.Windows.Forms.Button buttonMedie;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonVandute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewRezultate;
    }
}