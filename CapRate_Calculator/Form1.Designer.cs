namespace CapRate_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baseRate = new System.Windows.Forms.NumericUpDown();
            this.baseRateLabel = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.NumericUpDown();
            this.upfrontCost = new System.Windows.Forms.NumericUpDown();
            this.upfrontCostLabel = new System.Windows.Forms.Label();
            this.termLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.term)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upfrontCost)).BeginInit();
            this.SuspendLayout();
            // 
            // baseRate
            // 
            this.baseRate.DecimalPlaces = 2;
            this.baseRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.baseRate.Location = new System.Drawing.Point(142, 215);
            this.baseRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.baseRate.Name = "baseRate";
            this.baseRate.Size = new System.Drawing.Size(212, 38);
            this.baseRate.TabIndex = 1;
            this.baseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // baseRateLabel
            // 
            this.baseRateLabel.AutoSize = true;
            this.baseRateLabel.Location = new System.Drawing.Point(43, 215);
            this.baseRateLabel.Name = "baseRateLabel";
            this.baseRateLabel.Size = new System.Drawing.Size(74, 17);
            this.baseRateLabel.TabIndex = 2;
            this.baseRateLabel.Text = "Base Rate";
            // 
            // term
            // 
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term.Location = new System.Drawing.Point(142, 278);
            this.term.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(212, 38);
            this.term.TabIndex = 3;
            this.term.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upfrontCost
            // 
            this.upfrontCost.DecimalPlaces = 2;
            this.upfrontCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upfrontCost.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upfrontCost.Location = new System.Drawing.Point(142, 162);
            this.upfrontCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.upfrontCost.Name = "upfrontCost";
            this.upfrontCost.Size = new System.Drawing.Size(212, 38);
            this.upfrontCost.TabIndex = 4;
            this.upfrontCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upfrontCost.ThousandsSeparator = true;
            // 
            // upfrontCostLabel
            // 
            this.upfrontCostLabel.AutoSize = true;
            this.upfrontCostLabel.Location = new System.Drawing.Point(46, 162);
            this.upfrontCostLabel.Name = "upfrontCostLabel";
            this.upfrontCostLabel.Size = new System.Drawing.Size(87, 17);
            this.upfrontCostLabel.TabIndex = 5;
            this.upfrontCostLabel.Text = "Upfront Cost";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(46, 278);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(90, 17);
            this.termLabel.TabIndex = 6;
            this.termLabel.Text = "Term (years)";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(188, 354);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(113, 50);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "The annual fee to recoup costs should be...";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(360, 225);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(434, 46);
            this.answer.TabIndex = 9;
            this.answer.Text = "Currently undetermined";
            this.answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(64, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(567, 69);
            this.Title.TabIndex = 12;
            this.Title.Text = "Cap Rate Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.upfrontCostLabel);
            this.Controls.Add(this.upfrontCost);
            this.Controls.Add(this.term);
            this.Controls.Add(this.baseRateLabel);
            this.Controls.Add(this.baseRate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baseRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.term)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upfrontCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown baseRate;
        private System.Windows.Forms.Label baseRateLabel;
        private System.Windows.Forms.NumericUpDown term;
        private System.Windows.Forms.NumericUpDown upfrontCost;
        private System.Windows.Forms.Label upfrontCostLabel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
    }
}

