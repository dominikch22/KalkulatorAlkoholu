
namespace KalkulatorAlkoholu
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
            this.alkoholComboBox = new System.Windows.Forms.ComboBox();
            this.capacityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alkoholScoreTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.capacityScoreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alkoholComboBox
            // 
            this.alkoholComboBox.FormattingEnabled = true;
            this.alkoholComboBox.Location = new System.Drawing.Point(32, 69);
            this.alkoholComboBox.Name = "alkoholComboBox";
            this.alkoholComboBox.Size = new System.Drawing.Size(260, 24);
            this.alkoholComboBox.TabIndex = 0;
            this.alkoholComboBox.SelectedIndexChanged += new System.EventHandler(this.alkoholComboBox_SelectedIndexChanged);
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.FormattingEnabled = true;
            this.capacityComboBox.Location = new System.Drawing.Point(32, 151);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(260, 24);
            this.capacityComboBox.TabIndex = 1;
            this.capacityComboBox.SelectedIndexChanged += new System.EventHandler(this.capacityComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of alkohol or caston percent:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alkoholScoreTextBox
            // 
            this.alkoholScoreTextBox.Location = new System.Drawing.Point(32, 289);
            this.alkoholScoreTextBox.Name = "alkoholScoreTextBox";
            this.alkoholScoreTextBox.Size = new System.Drawing.Size(125, 22);
            this.alkoholScoreTextBox.TabIndex = 6;
            this.alkoholScoreTextBox.TextChanged += new System.EventHandler(this.alkoholScoreTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateButton.Location = new System.Drawing.Point(109, 216);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 44);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // capacityScoreTextBox
            // 
            this.capacityScoreTextBox.Location = new System.Drawing.Point(167, 289);
            this.capacityScoreTextBox.Name = "capacityScoreTextBox";
            this.capacityScoreTextBox.Size = new System.Drawing.Size(125, 22);
            this.capacityScoreTextBox.TabIndex = 8;
            this.capacityScoreTextBox.TextChanged += new System.EventHandler(this.capacityScoreTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type of glassware or custom capacity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(298, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "(ml)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(31, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Amount of spirit:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(163, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total capacity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(298, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "(%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capacityScoreTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.alkoholScoreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capacityComboBox);
            this.Controls.Add(this.alkoholComboBox);
            this.Name = "Form1";
            this.Text = "Kalkulator Alkoholu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox alkoholComboBox;
        private System.Windows.Forms.ComboBox capacityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alkoholScoreTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox capacityScoreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

