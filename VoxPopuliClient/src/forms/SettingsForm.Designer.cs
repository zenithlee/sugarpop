﻿namespace VoxPopuliClient.src.controls
{
  partial class SettingsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.CheckUpdatesButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.ServerText = new System.Windows.Forms.TextBox();
      this.OKButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.StartCompactCheck = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ScreenNameBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.StayOnTopCheck = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.BrowserCombo = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.EncryptionKeyBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.CheckUpdatesButton, 0, 8);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.ServerText, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.OKButton, 1, 8);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.StartCompactCheck, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.ScreenNameBox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.StayOnTopCheck, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.BrowserCombo, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.EncryptionKeyBox, 1, 5);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 9;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 407);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // CheckUpdatesButton
      // 
      this.CheckUpdatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.CheckUpdatesButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CheckUpdatesButton.FlatAppearance.BorderSize = 0;
      this.CheckUpdatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CheckUpdatesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CheckUpdatesButton.Location = new System.Drawing.Point(1, 382);
      this.CheckUpdatesButton.Margin = new System.Windows.Forms.Padding(1);
      this.CheckUpdatesButton.Name = "CheckUpdatesButton";
      this.CheckUpdatesButton.Size = new System.Drawing.Size(239, 24);
      this.CheckUpdatesButton.TabIndex = 15;
      this.CheckUpdatesButton.Text = "Check For Updates";
      this.CheckUpdatesButton.UseVisualStyleBackColor = false;
      this.CheckUpdatesButton.Click += new System.EventHandler(this.CheckUpdatesButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 192);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(235, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Vox Server";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ServerText
      // 
      this.ServerText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ServerText.Location = new System.Drawing.Point(244, 195);
      this.ServerText.Name = "ServerText";
      this.ServerText.Size = new System.Drawing.Size(236, 20);
      this.ServerText.TabIndex = 1;
      this.ServerText.Text = "http://bigfun.co.za/pop/";
      // 
      // OKButton
      // 
      this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OKButton.FlatAppearance.BorderSize = 0;
      this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.OKButton.Image = ((System.Drawing.Image)(resources.GetObject("OKButton.Image")));
      this.OKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.OKButton.Location = new System.Drawing.Point(242, 382);
      this.OKButton.Margin = new System.Windows.Forms.Padding(1);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(240, 24);
      this.OKButton.TabIndex = 2;
      this.OKButton.Text = "Save Settings";
      this.OKButton.UseVisualStyleBackColor = false;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(235, 32);
      this.label3.TabIndex = 5;
      this.label3.Text = "Start the app in Compact Mode";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // StartCompactCheck
      // 
      this.StartCompactCheck.AutoSize = true;
      this.StartCompactCheck.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StartCompactCheck.Location = new System.Drawing.Point(244, 3);
      this.StartCompactCheck.Name = "StartCompactCheck";
      this.StartCompactCheck.Size = new System.Drawing.Size(236, 26);
      this.StartCompactCheck.TabIndex = 6;
      this.StartCompactCheck.Text = "Start In Compact Mode";
      this.StartCompactCheck.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(3, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(235, 32);
      this.label2.TabIndex = 7;
      this.label2.Text = "Screen Name";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ScreenNameBox
      // 
      this.ScreenNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ScreenNameBox.Location = new System.Drawing.Point(244, 35);
      this.ScreenNameBox.Name = "ScreenNameBox";
      this.ScreenNameBox.Size = new System.Drawing.Size(236, 20);
      this.ScreenNameBox.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Location = new System.Drawing.Point(3, 64);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(235, 32);
      this.label4.TabIndex = 9;
      this.label4.Text = "Stay on Top of other windows";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // StayOnTopCheck
      // 
      this.StayOnTopCheck.AutoSize = true;
      this.StayOnTopCheck.Checked = true;
      this.StayOnTopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
      this.StayOnTopCheck.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StayOnTopCheck.Location = new System.Drawing.Point(244, 67);
      this.StayOnTopCheck.Name = "StayOnTopCheck";
      this.StayOnTopCheck.Size = new System.Drawing.Size(236, 26);
      this.StayOnTopCheck.TabIndex = 10;
      this.StayOnTopCheck.Text = "Stay On Top";
      this.StayOnTopCheck.UseVisualStyleBackColor = true;
      this.StayOnTopCheck.CheckedChanged += new System.EventHandler(this.StayOnTopCheck_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Location = new System.Drawing.Point(3, 96);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(235, 32);
      this.label5.TabIndex = 11;
      this.label5.Text = "Preferred Browser";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // BrowserCombo
      // 
      this.BrowserCombo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BrowserCombo.FormattingEnabled = true;
      this.BrowserCombo.Items.AddRange(new object[] {
            "FireFox",
            "Chrome",
            "Edge",
            "Default"});
      this.BrowserCombo.Location = new System.Drawing.Point(244, 99);
      this.BrowserCombo.Name = "BrowserCombo";
      this.BrowserCombo.Size = new System.Drawing.Size(236, 21);
      this.BrowserCombo.TabIndex = 12;
      this.BrowserCombo.Text = "System Default";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Location = new System.Drawing.Point(3, 160);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(235, 32);
      this.label6.TabIndex = 13;
      this.label6.Text = "Encryption Key";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // EncryptionKeyBox
      // 
      this.EncryptionKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EncryptionKeyBox.Location = new System.Drawing.Point(244, 163);
      this.EncryptionKeyBox.Name = "EncryptionKeyBox";
      this.EncryptionKeyBox.Size = new System.Drawing.Size(236, 20);
      this.EncryptionKeyBox.TabIndex = 14;
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 407);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SettingsForm";
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ServerText;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox StartCompactCheck;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ScreenNameBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox StayOnTopCheck;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox BrowserCombo;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox EncryptionKeyBox;
    private System.Windows.Forms.Button CheckUpdatesButton;
  }
}