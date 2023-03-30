
namespace ООП_4._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.trackA = new System.Windows.Forms.TrackBar();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.trackC = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).BeginInit();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(113, 186);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(150, 20);
            this.textA.TabIndex = 0;
            this.textA.Text = "0";
            this.textA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textA_KeyDown);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(312, 186);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(150, 20);
            this.textB.TabIndex = 1;
            this.textB.Text = "50";
            this.textB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textB_KeyDown);
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(521, 186);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(150, 20);
            this.textC.TabIndex = 2;
            this.textC.Text = "100";
            this.textC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textC_KeyDown);
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(113, 223);
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(150, 20);
            this.numericA.TabIndex = 3;
            this.numericA.ValueChanged += new System.EventHandler(this.numericA_ValueChanged);
            // 
            // numericC
            // 
            this.numericC.Location = new System.Drawing.Point(521, 223);
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(150, 20);
            this.numericC.TabIndex = 4;
            this.numericC.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericC.ValueChanged += new System.EventHandler(this.numericC_ValueChanged);
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(312, 223);
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(150, 20);
            this.numericB.TabIndex = 5;
            this.numericB.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericB.ValueChanged += new System.EventHandler(this.numericB_ValueChanged);
            // 
            // trackA
            // 
            this.trackA.Location = new System.Drawing.Point(113, 261);
            this.trackA.Maximum = 100;
            this.trackA.Name = "trackA";
            this.trackA.Size = new System.Drawing.Size(150, 45);
            this.trackA.TabIndex = 6;
            this.trackA.Scroll += new System.EventHandler(this.trackA_Scroll);
            // 
            // trackB
            // 
            this.trackB.Location = new System.Drawing.Point(312, 261);
            this.trackB.Maximum = 100;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(150, 45);
            this.trackB.TabIndex = 7;
            this.trackB.Value = 50;
            this.trackB.Scroll += new System.EventHandler(this.trackB_Scroll);
            // 
            // trackC
            // 
            this.trackC.Location = new System.Drawing.Point(521, 261);
            this.trackC.Maximum = 100;
            this.trackC.Name = "trackC";
            this.trackC.Size = new System.Drawing.Size(150, 45);
            this.trackC.TabIndex = 8;
            this.trackC.Value = 100;
            this.trackC.Scroll += new System.EventHandler(this.trackC_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.label1.Location = new System.Drawing.Point(112, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 107);
            this.label1.TabIndex = 10;
            this.label1.Text = "A <= B <= C";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(361, 364);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackC);
            this.Controls.Add(this.trackB);
            this.Controls.Add(this.trackA);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericC);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.TrackBar trackA;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.TrackBar trackC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}

