namespace Vox
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.DataBox = new System.Windows.Forms.TextBox();
      this.TestButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.16185F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.83815F));
      this.tableLayoutPanel1.Controls.Add(this.DataBox, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.TestButton, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.762082F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.23792F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 538);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // DataBox
      // 
      this.DataBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataBox.Location = new System.Drawing.Point(3, 33);
      this.DataBox.Multiline = true;
      this.DataBox.Name = "DataBox";
      this.DataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DataBox.Size = new System.Drawing.Size(611, 502);
      this.DataBox.TabIndex = 0;
      // 
      // TestButton
      // 
      this.TestButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TestButton.Location = new System.Drawing.Point(618, 1);
      this.TestButton.Margin = new System.Windows.Forms.Padding(1);
      this.TestButton.Name = "TestButton";
      this.TestButton.Size = new System.Drawing.Size(73, 28);
      this.TestButton.TabIndex = 1;
      this.TestButton.Text = "Test";
      this.TestButton.UseVisualStyleBackColor = true;
      this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(692, 538);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox DataBox;
    private System.Windows.Forms.Button TestButton;
  }
}

