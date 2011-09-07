namespace TextFileSearchAndReplace
{
  partial class frmMainForm
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
      this.lblFolder = new System.Windows.Forms.Label();
      this.tbFolder = new System.Windows.Forms.TextBox();
      this.btnFolderPicker = new System.Windows.Forms.Button();
      this.lblExtensions = new System.Windows.Forms.Label();
      this.tbFilePatterns = new System.Windows.Forms.TextBox();
      this.lblSearchPatternHelp = new System.Windows.Forms.Label();
      this.gbxReplaceText = new System.Windows.Forms.GroupBox();
      this.tbReplaceStrings = new System.Windows.Forms.TextBox();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnLoadSettings = new System.Windows.Forms.Button();
      this.btnSaveSettings = new System.Windows.Forms.Button();
      this.fbdSearchFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.lblOutputFolder = new System.Windows.Forms.Label();
      this.tbOutputFolder = new System.Windows.Forms.TextBox();
      this.btnOutputFolder = new System.Windows.Forms.Button();
      this.fbdOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.gbxReplaceText.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblFolder
      // 
      this.lblFolder.AutoSize = true;
      this.lblFolder.Location = new System.Drawing.Point(24, 52);
      this.lblFolder.Name = "lblFolder";
      this.lblFolder.Size = new System.Drawing.Size(76, 13);
      this.lblFolder.TabIndex = 0;
      this.lblFolder.Text = "Search Folder:";
      this.lblFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // tbFolder
      // 
      this.tbFolder.Location = new System.Drawing.Point(106, 49);
      this.tbFolder.Name = "tbFolder";
      this.tbFolder.Size = new System.Drawing.Size(549, 20);
      this.tbFolder.TabIndex = 1;
      // 
      // btnFolderPicker
      // 
      this.btnFolderPicker.Location = new System.Drawing.Point(661, 47);
      this.btnFolderPicker.Name = "btnFolderPicker";
      this.btnFolderPicker.Size = new System.Drawing.Size(29, 23);
      this.btnFolderPicker.TabIndex = 2;
      this.btnFolderPicker.Text = "...";
      this.btnFolderPicker.UseVisualStyleBackColor = true;
      this.btnFolderPicker.Click += new System.EventHandler(this.btnFolderPicker_Click);
      // 
      // lblExtensions
      // 
      this.lblExtensions.AutoSize = true;
      this.lblExtensions.Location = new System.Drawing.Point(8, 76);
      this.lblExtensions.Name = "lblExtensions";
      this.lblExtensions.Size = new System.Drawing.Size(80, 13);
      this.lblExtensions.TabIndex = 3;
      this.lblExtensions.Text = "File Extensions:";
      this.lblExtensions.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // tbFilePatterns
      // 
      this.tbFilePatterns.Location = new System.Drawing.Point(106, 73);
      this.tbFilePatterns.Name = "tbFilePatterns";
      this.tbFilePatterns.Size = new System.Drawing.Size(584, 20);
      this.tbFilePatterns.TabIndex = 4;
      this.tbFilePatterns.Leave += new System.EventHandler(this.tbFileExtensions_Leave);
      // 
      // lblSearchPatternHelp
      // 
      this.lblSearchPatternHelp.AutoSize = true;
      this.lblSearchPatternHelp.Location = new System.Drawing.Point(103, 104);
      this.lblSearchPatternHelp.Name = "lblSearchPatternHelp";
      this.lblSearchPatternHelp.Size = new System.Drawing.Size(380, 13);
      this.lblSearchPatternHelp.TabIndex = 5;
      this.lblSearchPatternHelp.Text = "NOTE: Use \"|\" to specify multiple file extensions. Matching is not case sensitive" +
          "";
      // 
      // gbxReplaceText
      // 
      this.gbxReplaceText.Controls.Add(this.tbReplaceStrings);
      this.gbxReplaceText.Location = new System.Drawing.Point(11, 127);
      this.gbxReplaceText.Name = "gbxReplaceText";
      this.gbxReplaceText.Size = new System.Drawing.Size(679, 216);
      this.gbxReplaceText.TabIndex = 6;
      this.gbxReplaceText.TabStop = false;
      this.gbxReplaceText.Text = "Replace Strings";
      // 
      // tbReplaceStrings
      // 
      this.tbReplaceStrings.Location = new System.Drawing.Point(6, 19);
      this.tbReplaceStrings.Multiline = true;
      this.tbReplaceStrings.Name = "tbReplaceStrings";
      this.tbReplaceStrings.Size = new System.Drawing.Size(667, 191);
      this.tbReplaceStrings.TabIndex = 0;
      this.tbReplaceStrings.WordWrap = false;
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(12, 381);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 23);
      this.btnExecute.TabIndex = 7;
      this.btnExecute.Text = "E&xecute";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnLoadSettings
      // 
      this.btnLoadSettings.Location = new System.Drawing.Point(13, 13);
      this.btnLoadSettings.Name = "btnLoadSettings";
      this.btnLoadSettings.Size = new System.Drawing.Size(104, 23);
      this.btnLoadSettings.TabIndex = 8;
      this.btnLoadSettings.Text = "&Load Settings";
      this.btnLoadSettings.UseVisualStyleBackColor = true;
      this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
      // 
      // btnSaveSettings
      // 
      this.btnSaveSettings.Location = new System.Drawing.Point(123, 13);
      this.btnSaveSettings.Name = "btnSaveSettings";
      this.btnSaveSettings.Size = new System.Drawing.Size(104, 23);
      this.btnSaveSettings.TabIndex = 9;
      this.btnSaveSettings.Text = "&Save Settings";
      this.btnSaveSettings.UseVisualStyleBackColor = true;
      this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
      // 
      // lblOutputFolder
      // 
      this.lblOutputFolder.AutoSize = true;
      this.lblOutputFolder.Location = new System.Drawing.Point(24, 352);
      this.lblOutputFolder.Name = "lblOutputFolder";
      this.lblOutputFolder.Size = new System.Drawing.Size(74, 13);
      this.lblOutputFolder.TabIndex = 10;
      this.lblOutputFolder.Text = "Output Folder:";
      this.lblOutputFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // tbOutputFolder
      // 
      this.tbOutputFolder.Location = new System.Drawing.Point(106, 349);
      this.tbOutputFolder.Name = "tbOutputFolder";
      this.tbOutputFolder.Size = new System.Drawing.Size(549, 20);
      this.tbOutputFolder.TabIndex = 11;
      // 
      // btnOutputFolder
      // 
      this.btnOutputFolder.Location = new System.Drawing.Point(661, 347);
      this.btnOutputFolder.Name = "btnOutputFolder";
      this.btnOutputFolder.Size = new System.Drawing.Size(29, 23);
      this.btnOutputFolder.TabIndex = 12;
      this.btnOutputFolder.Text = "...";
      this.btnOutputFolder.UseVisualStyleBackColor = true;
      this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
      // 
      // frmMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(702, 419);
      this.Controls.Add(this.btnOutputFolder);
      this.Controls.Add(this.tbOutputFolder);
      this.Controls.Add(this.lblOutputFolder);
      this.Controls.Add(this.btnSaveSettings);
      this.Controls.Add(this.btnLoadSettings);
      this.Controls.Add(this.btnExecute);
      this.Controls.Add(this.gbxReplaceText);
      this.Controls.Add(this.lblSearchPatternHelp);
      this.Controls.Add(this.tbFilePatterns);
      this.Controls.Add(this.lblExtensions);
      this.Controls.Add(this.btnFolderPicker);
      this.Controls.Add(this.tbFolder);
      this.Controls.Add(this.lblFolder);
      this.Name = "frmMainForm";
      this.Text = "Text File Search and Replace V0.01";
      this.Load += new System.EventHandler(this.frmMainForm_Load);
      this.gbxReplaceText.ResumeLayout(false);
      this.gbxReplaceText.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFolder;
    private System.Windows.Forms.TextBox tbFolder;
    private System.Windows.Forms.Button btnFolderPicker;
    private System.Windows.Forms.Label lblExtensions;
    private System.Windows.Forms.TextBox tbFilePatterns;
    private System.Windows.Forms.Label lblSearchPatternHelp;
    private System.Windows.Forms.GroupBox gbxReplaceText;
    private System.Windows.Forms.TextBox tbReplaceStrings;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnLoadSettings;
    private System.Windows.Forms.Button btnSaveSettings;
    private System.Windows.Forms.FolderBrowserDialog fbdSearchFolder;
    private System.Windows.Forms.Label lblOutputFolder;
    private System.Windows.Forms.TextBox tbOutputFolder;
    private System.Windows.Forms.Button btnOutputFolder;
    private System.Windows.Forms.FolderBrowserDialog fbdOutputFolder;
  }
}

