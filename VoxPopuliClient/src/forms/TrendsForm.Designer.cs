namespace VoxPopuliClient.src.forms
{
  partial class TrendsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendsForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.TrendsView = new System.Windows.Forms.ListView();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.TrendsView, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 432);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // TrendsView
      // 
      this.TrendsView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TrendsView.Location = new System.Drawing.Point(3, 3);
      this.TrendsView.Name = "TrendsView";
      this.TrendsView.Size = new System.Drawing.Size(343, 381);
      this.TrendsView.TabIndex = 0;
      this.TrendsView.UseCompatibleStateImageBehavior = false;
      this.TrendsView.View = System.Windows.Forms.View.List;
      this.TrendsView.DoubleClick += new System.EventHandler(this.TrendsView_DoubleClick);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.RefreshButton, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 390);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 39);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // RefreshButton
      // 
      this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RefreshButton.FlatAppearance.BorderSize = 0;
      this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.RefreshButton.Location = new System.Drawing.Point(174, 3);
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(166, 33);
      this.RefreshButton.TabIndex = 0;
      this.RefreshButton.Text = "Refresh";
      this.RefreshButton.UseVisualStyleBackColor = false;
      this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
      // 
      // TrendsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 432);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "TrendsForm";
      this.Text = "Current Trends";
      this.Shown += new System.EventHandler(this.TrendsForm_Shown);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ListView TrendsView;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button RefreshButton;
  }
}