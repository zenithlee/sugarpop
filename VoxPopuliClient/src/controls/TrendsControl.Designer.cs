namespace VoxPopuliClient.src.controls
{
  partial class TrendsControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendsControl));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.TrendsView = new System.Windows.Forms.ListView();
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.PopOutButton = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
      this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 462);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // TrendsView
      // 
      this.TrendsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
      this.TrendsView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TrendsView.FullRowSelect = true;
      this.TrendsView.HideSelection = false;
      this.TrendsView.Location = new System.Drawing.Point(3, 3);
      this.TrendsView.Name = "TrendsView";
      this.TrendsView.Size = new System.Drawing.Size(309, 411);
      this.TrendsView.TabIndex = 0;
      this.TrendsView.UseCompatibleStateImageBehavior = false;
      this.TrendsView.View = System.Windows.Forms.View.Details;
      this.TrendsView.DoubleClick += new System.EventHandler(this.TrendsView_DoubleClick);
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Date";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader3.Width = 45;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "URL";
      this.columnHeader1.Width = 2;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Description";
      this.columnHeader2.Width = 400;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.13667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.86333F));
      this.tableLayoutPanel2.Controls.Add(this.RefreshButton, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.PopOutButton, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 420);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 39);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // RefreshButton
      // 
      this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RefreshButton.FlatAppearance.BorderSize = 0;
      this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
      this.RefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RefreshButton.Location = new System.Drawing.Point(206, 3);
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(100, 33);
      this.RefreshButton.TabIndex = 0;
      this.RefreshButton.Text = "Refresh";
      this.toolTip1.SetToolTip(this.RefreshButton, "Refresh the trends");
      this.RefreshButton.UseVisualStyleBackColor = false;
      this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click_1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(48, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(152, 39);
      this.label1.TabIndex = 1;
      this.label1.Text = "Double-Click a link to Pop";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PopOutButton
      // 
      this.PopOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PopOutButton.Image = ((System.Drawing.Image)(resources.GetObject("PopOutButton.Image")));
      this.PopOutButton.Location = new System.Drawing.Point(1, 1);
      this.PopOutButton.Margin = new System.Windows.Forms.Padding(1);
      this.PopOutButton.Name = "PopOutButton";
      this.PopOutButton.Size = new System.Drawing.Size(43, 37);
      this.PopOutButton.TabIndex = 2;
      this.toolTip1.SetToolTip(this.PopOutButton, "Pop this panel out");
      this.PopOutButton.UseVisualStyleBackColor = true;
      this.PopOutButton.Click += new System.EventHandler(this.PopOutButton_Click);
      // 
      // TrendsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "TrendsControl";
      this.Size = new System.Drawing.Size(315, 462);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ListView TrendsView;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button RefreshButton;
    private System.Windows.Forms.Label label1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Button PopOutButton;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}
