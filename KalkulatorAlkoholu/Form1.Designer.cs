﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.errorInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.glasswareTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alkoholComboBox
            // 
            this.alkoholComboBox.FormattingEnabled = true;
            this.alkoholComboBox.Location = new System.Drawing.Point(31, 42);
            this.alkoholComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alkoholComboBox.Name = "alkoholComboBox";
            this.alkoholComboBox.Size = new System.Drawing.Size(218, 21);
            this.alkoholComboBox.TabIndex = 0;
            this.alkoholComboBox.SelectedIndexChanged += new System.EventHandler(this.alkoholComboBox_SelectedIndexChanged);
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.FormattingEnabled = true;
            this.capacityComboBox.Location = new System.Drawing.Point(31, 91);
            this.capacityComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(218, 21);
            this.capacityComboBox.TabIndex = 1;
            this.capacityComboBox.SelectedIndexChanged += new System.EventHandler(this.capacityComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of alkohol or custom percent:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alkoholScoreTextBox
            // 
            this.alkoholScoreTextBox.Location = new System.Drawing.Point(31, 231);
            this.alkoholScoreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alkoholScoreTextBox.Name = "alkoholScoreTextBox";
            this.alkoholScoreTextBox.ReadOnly = true;
            this.alkoholScoreTextBox.Size = new System.Drawing.Size(91, 20);
            this.alkoholScoreTextBox.TabIndex = 6;
            this.alkoholScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alkoholScoreTextBox.TextChanged += new System.EventHandler(this.alkoholScoreTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateButton.Location = new System.Drawing.Point(92, 167);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 37);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // capacityScoreTextBox
            // 
            this.capacityScoreTextBox.Location = new System.Drawing.Point(158, 231);
            this.capacityScoreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capacityScoreTextBox.Name = "capacityScoreTextBox";
            this.capacityScoreTextBox.ReadOnly = true;
            this.capacityScoreTextBox.Size = new System.Drawing.Size(91, 20);
            this.capacityScoreTextBox.TabIndex = 8;
            this.capacityScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.capacityScoreTextBox.TextChanged += new System.EventHandler(this.capacityScoreTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type of glassware or custom capacity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(250, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "(ml)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(28, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Amount of spirit:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total capacity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(250, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "(%)";
            // 
            // errorInfo
            // 
            this.errorInfo.AllowDrop = true;
            this.errorInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.errorInfo.Location = new System.Drawing.Point(45, 271);
            this.errorInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorInfo.Name = "errorInfo";
            this.errorInfo.ReadOnly = true;
            this.errorInfo.Size = new System.Drawing.Size(197, 20);
            this.errorInfo.TabIndex = 18;
            this.errorInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(118, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Errors:";
            // 
            // glasswareTextBox
            // 
            this.glasswareTextBox.Location = new System.Drawing.Point(31, 140);
            this.glasswareTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.glasswareTextBox.Name = "glasswareTextBox";
            this.glasswareTextBox.Size = new System.Drawing.Size(218, 20);
            this.glasswareTextBox.TabIndex = 20;
            this.glasswareTextBox.TextChanged += new System.EventHandler(this.glasswareTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Amount of glassware:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(122, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "(ml)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(250, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "(ml)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(288, 314);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.glasswareTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.errorInfo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(304, 353);
            this.MinimumSize = new System.Drawing.Size(304, 353);
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
        private System.Windows.Forms.TextBox errorInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox glasswareTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

