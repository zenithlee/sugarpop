namespace VoxPopuliClient.src.controls
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
      this.label1 = new System.Windows.Forms.Label();
      this.ServerText = new System.Windows.Forms.TextBox();
      this.OKButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.StartCompactCheck = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.ServerText, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.OKButton, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.StartCompactCheck, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.388206F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61179F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 407);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(235, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "SugarPop Server";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ServerText
      // 
      this.ServerText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ServerText.Location = new System.Drawing.Point(244, 3);
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
      this.OKButton.Location = new System.Drawing.Point(242, 381);
      this.OKButton.Margin = new System.Windows.Forms.Padding(1);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(240, 25);
      this.OKButton.TabIndex = 2;
      this.OKButton.Text = "Save Settings";
      this.OKButton.UseVisualStyleBackColor = false;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 22);
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
      this.StartCompactCheck.Location = new System.Drawing.Point(244, 25);
      this.StartCompactCheck.Name = "StartCompactCheck";
      this.StartCompactCheck.Size = new System.Drawing.Size(236, 26);
      this.StartCompactCheck.TabIndex = 6;
      this.StartCompactCheck.Text = "Start In Compact Mode";
      this.StartCompactCheck.UseVisualStyleBackColor = true;
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
  }
}