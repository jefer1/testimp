﻿namespace testImpol
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numMiddleDistance = new System.Windows.Forms.NumericUpDown();
            this.numLeftDistance = new System.Windows.Forms.NumericUpDown();
            this.numTopDistance = new System.Windows.Forms.NumericUpDown();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblLeftDistance = new System.Windows.Forms.Label();
            this.lblTopDistance = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBoxPar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblXY = new System.Windows.Forms.Label();
            this.lbCoordinates = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMiddleDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.groupBoxPar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Minimalna razdalja med robovi rondelic";
            // 
            // numMiddleDistance
            // 
            this.numMiddleDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numMiddleDistance.Location = new System.Drawing.Point(477, 196);
            this.numMiddleDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMiddleDistance.Name = "numMiddleDistance";
            this.numMiddleDistance.Size = new System.Drawing.Size(120, 26);
            this.numMiddleDistance.TabIndex = 6;
            // 
            // numLeftDistance
            // 
            this.numLeftDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLeftDistance.Location = new System.Drawing.Point(477, 132);
            this.numLeftDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLeftDistance.Name = "numLeftDistance";
            this.numLeftDistance.Size = new System.Drawing.Size(120, 26);
            this.numLeftDistance.TabIndex = 5;
            // 
            // numTopDistance
            // 
            this.numTopDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numTopDistance.Location = new System.Drawing.Point(477, 164);
            this.numTopDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTopDistance.Name = "numTopDistance";
            this.numTopDistance.Size = new System.Drawing.Size(120, 26);
            this.numTopDistance.TabIndex = 4;
            // 
            // numRadius
            // 
            this.numRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numRadius.Location = new System.Drawing.Point(167, 100);
            this.numRadius.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(120, 26);
            this.numRadius.TabIndex = 3;
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numWidth.Location = new System.Drawing.Point(167, 69);
            this.numWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 26);
            this.numWidth.TabIndex = 2;
            // 
            // numLength
            // 
            this.numLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLength.Location = new System.Drawing.Point(167, 36);
            this.numLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 26);
            this.numLength.TabIndex = 1;
            // 
            // lblLeftDistance
            // 
            this.lblLeftDistance.AutoSize = true;
            this.lblLeftDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeftDistance.Location = new System.Drawing.Point(24, 134);
            this.lblLeftDistance.Name = "lblLeftDistance";
            this.lblLeftDistance.Size = new System.Drawing.Size(447, 20);
            this.lblLeftDistance.TabIndex = 21;
            this.lblLeftDistance.Text = "Minimalna razdalja med začetkom in koncem in robom rondelic";
            // 
            // lblTopDistance
            // 
            this.lblTopDistance.AutoSize = true;
            this.lblTopDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTopDistance.Location = new System.Drawing.Point(24, 166);
            this.lblTopDistance.Name = "lblTopDistance";
            this.lblTopDistance.Size = new System.Drawing.Size(369, 20);
            this.lblTopDistance.TabIndex = 20;
            this.lblTopDistance.Text = "Minimalna razdalja med zgornjim in spodnjim robom";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRadius.Location = new System.Drawing.Point(24, 102);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(126, 20);
            this.lblRadius.TabIndex = 19;
            this.lblRadius.Text = "Polmer rondelice";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWidth.Location = new System.Drawing.Point(24, 70);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(89, 20);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Text = "Širina traka";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLength.Location = new System.Drawing.Point(24, 38);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(102, 20);
            this.lblLength.TabIndex = 17;
            this.lblLength.Text = "Dolžina traka";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculate.Location = new System.Drawing.Point(399, 266);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(233, 39);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Izračun postavitve";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBoxPar
            // 
            this.groupBoxPar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxPar.Controls.Add(this.lblLength);
            this.groupBoxPar.Controls.Add(this.lblWidth);
            this.groupBoxPar.Controls.Add(this.label1);
            this.groupBoxPar.Controls.Add(this.lblRadius);
            this.groupBoxPar.Controls.Add(this.numMiddleDistance);
            this.groupBoxPar.Controls.Add(this.lblTopDistance);
            this.groupBoxPar.Controls.Add(this.numLeftDistance);
            this.groupBoxPar.Controls.Add(this.lblLeftDistance);
            this.groupBoxPar.Controls.Add(this.numTopDistance);
            this.groupBoxPar.Controls.Add(this.numLength);
            this.groupBoxPar.Controls.Add(this.numRadius);
            this.groupBoxPar.Controls.Add(this.numWidth);
            this.groupBoxPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPar.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPar.Name = "groupBoxPar";
            this.groupBoxPar.Size = new System.Drawing.Size(620, 239);
            this.groupBoxPar.TabIndex = 30;
            this.groupBoxPar.TabStop = false;
            this.groupBoxPar.Text = "NASTAVITVENI PARAMETRI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblXY);
            this.groupBox1.Controls.Add(this.lbCoordinates);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 272);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REZULTATI";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(387, 232);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(217, 27);
            this.btnExport.TabIndex = 33;
            this.btnExport.Text = "Izvoz v datoteko";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(254, 35);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 26);
            this.txtResult.TabIndex = 32;
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXY.Location = new System.Drawing.Point(11, 87);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(260, 20);
            this.lblXY.TabIndex = 31;
            this.lblXY.Text = "Koordinate centra rondelic na traku:";
            // 
            // lbCoordinates
            // 
            this.lbCoordinates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCoordinates.FormattingEnabled = true;
            this.lbCoordinates.ItemHeight = 16;
            this.lbCoordinates.Location = new System.Drawing.Point(15, 110);
            this.lbCoordinates.Name = "lbCoordinates";
            this.lbCoordinates.Size = new System.Drawing.Size(589, 116);
            this.lbCoordinates.TabIndex = 30;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(11, 37);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(237, 20);
            this.lblResult.TabIndex = 29;
            this.lblResult.Text = "Skupno število rondelic na traku:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(520, 606);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 39);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Izhod";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(647, 656);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPar);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izsek rondelic";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMiddleDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.groupBoxPar.ResumeLayout(false);
            this.groupBoxPar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMiddleDistance;
        private System.Windows.Forms.NumericUpDown numLeftDistance;
        private System.Windows.Forms.NumericUpDown numTopDistance;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblLeftDistance;
        private System.Windows.Forms.Label lblTopDistance;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBoxPar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.ListBox lbCoordinates;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExport;
    }
}

