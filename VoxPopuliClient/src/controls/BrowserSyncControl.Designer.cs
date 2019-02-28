namespace VoxPopuliClient.src.controls
{
  partial class BrowserSyncControl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserSyncControl));
      this.SyncButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // SyncButton
      // 
      this.SyncButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SyncButton.FlatAppearance.BorderSize = 0;
      this.SyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SyncButton.Image = ((System.Drawing.Image)(resources.GetObject("SyncButton.Image")));
      this.SyncButton.Location = new System.Drawing.Point(0, 0);
      this.SyncButton.Name = "SyncButton";
      this.SyncButton.Size = new System.Drawing.Size(32, 30);
      this.SyncButton.TabIndex = 0;
      this.SyncButton.UseVisualStyleBackColor = true;
      this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
      // 
      // BrowserSyncControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.SyncButton);
      this.Name = "BrowserSyncControl";
      this.Size = new System.Drawing.Size(32, 30);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button SyncButton;
  }
}
