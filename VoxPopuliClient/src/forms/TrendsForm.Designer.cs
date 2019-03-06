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
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.trendsControl1 = new VoxPopuliClient.src.controls.TrendsControl();
      this.SuspendLayout();
      // 
      // trendsControl1
      // 
      this.trendsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trendsControl1.Location = new System.Drawing.Point(0, 0);
      this.trendsControl1.Name = "trendsControl1";
      this.trendsControl1.Size = new System.Drawing.Size(534, 432);
      this.trendsControl1.TabIndex = 0;
      // 
      // TrendsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 432);
      this.Controls.Add(this.trendsControl1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "TrendsForm";
      this.Text = "Current Trends";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrendsForm_FormClosing);
      this.Shown += new System.EventHandler(this.TrendsForm_Shown);
      this.ResumeLayout(false);

    }

    #endregion
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private controls.TrendsControl trendsControl1;
  }
}