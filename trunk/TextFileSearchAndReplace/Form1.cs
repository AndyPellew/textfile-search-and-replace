using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TextFileSearchAndReplace
{
  public partial class frmMainForm : Form
  {
    public frmMainForm()
    {
      InitializeComponent();
    }

    private void LogText(string Text)
    {
      StreamWriter sw = File.AppendText(tbOutputFolder.Text + "!Log.txt");
      sw.WriteLine(String.Format("{0:yyyy-MM-dd HH:mm:ss.ffff}", DateTime.Now) + ": " + Text);
      sw.Close();
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
      LogText("- START ".PadRight(30, '-'));
      
      // Remove the existing logfile
      if (File.Exists(tbOutputFolder.Text + "!Log.txt"))
        File.Delete(tbOutputFolder.Text + "!Log.txt");
      
      // Save settings to the Config file 
      Properties.Settings.Default.Folder = tbFolder.Text;
      Properties.Settings.Default.FileExtensions = tbFilePatterns.Text;
      Properties.Settings.Default.ReplaceStrings = tbReplaceStrings.Text;
      Properties.Settings.Default.OutputFolder = tbOutputFolder.Text;
      Properties.Settings.Default.Save();

      LogText("Properties.Settings.Default.Folder = " + tbFolder.Text);
      LogText("Properties.Settings.Default.FileExtensions = " + tbFilePatterns.Text);
      LogText("Properties.Settings.Default.ReplaceStrings = " + tbReplaceStrings.Text);
      LogText("Properties.Settings.Default.OutputFolder = " + tbOutputFolder.Text);

      // If the output directory doesn't exist then create it
      if (!Directory.Exists(tbOutputFolder.Text))
        Directory.CreateDirectory(tbOutputFolder.Text);

      foreach (string sFile in Directory.GetFiles(tbFolder.Text, "*", SearchOption.TopDirectoryOnly).Where(
        s => tbFilePatterns.Text.ToLower().Contains(Path.GetExtension(s) + "|")))
      {
        LogText("Processing File - START : " + Path.GetFileName(sFile));

        bool bFileChanged = false;
        string sLine;
        int iLineNo = 0;
        TextWriter twOutput = new StreamWriter(tbOutputFolder.Text + Path.GetFileName(sFile));
        TextReader trInput = new StreamReader(sFile);
        while ((sLine = trInput.ReadLine()) != null)
        {
          iLineNo = iLineNo + 1;

          string sNewLine = sLine;
          foreach (string sReplace in Regex.Split(tbReplaceStrings.Text, "\r\n"))
          {
            string[] sOptions = sReplace.Split('|');
            sNewLine = sNewLine.Replace(sOptions[0], sOptions[1]);
          }
          if (sLine != sNewLine)
          {
            bFileChanged = true;
            LogText("Line " + iLineNo.ToString().PadLeft(7, '0') + ", Old Line '" + sLine + "', New Line '" + sNewLine + "'");
          }
          twOutput.WriteLine(sNewLine);
        }
        trInput.Close();
        twOutput.Close();
        LogText("Processing File - END : " + Path.GetFileName(sFile));
        LogText("Processing File - Changed? : " + bFileChanged.ToString());

        if (!bFileChanged) // Delete the file if nothing has been changed
          File.Delete(tbOutputFolder.Text + Path.GetFileName(sFile));
      };
      LogText("- END ".PadRight(30, '-'));
    }

    private void frmMainForm_Load(object sender, EventArgs e)
    {
      // Restore settings saved into the Config file from the last successful run
      tbFolder.Text = Properties.Settings.Default.Folder;
      tbFilePatterns.Text = Properties.Settings.Default.FileExtensions;
      tbReplaceStrings.Text = Properties.Settings.Default.ReplaceStrings;
      tbOutputFolder.Text = Properties.Settings.Default.OutputFolder;
    }

    private void tbFileExtensions_Leave(object sender, EventArgs e)
    {
      tbFilePatterns.Text = tbFilePatterns.Text.ToLower();
      if (tbFilePatterns.Text.Length > 0)
      {
        if (tbFilePatterns.Text.Substring(0,1) != "|")
          tbFilePatterns.Text = "|" + tbFilePatterns.Text;
        if (tbFilePatterns.Text.Substring(tbFilePatterns.Text.Length-1,1) != "|")
          tbFilePatterns.Text = tbFilePatterns.Text + "|";
      }
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfdSaveSettings = new SaveFileDialog();
      sfdSaveSettings.InitialDirectory = Directory.GetCurrentDirectory() + @"\SavedSettings";
      sfdSaveSettings.Filter = "Text Files|*.txt";
      sfdSaveSettings.Title = "Save Settings";
      sfdSaveSettings.ShowDialog();
      if (sfdSaveSettings.FileName != "")
      {
        TextWriter twSettings = new StreamWriter(sfdSaveSettings.FileName);
        twSettings.WriteLine(tbFolder.Text);
        twSettings.WriteLine(tbFilePatterns.Text);
        twSettings.WriteLine(tbOutputFolder.Text);
        twSettings.WriteLine(tbReplaceStrings.Text);
        twSettings.Close();
      }
    }

    private void btnLoadSettings_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofdLoadSettings = new OpenFileDialog();
      ofdLoadSettings.InitialDirectory = Directory.GetCurrentDirectory() + @"\SavedSettings";
      ofdLoadSettings.Filter = "Text Files|*.txt";
      ofdLoadSettings.Title = "Load Settings";
      ofdLoadSettings.ShowDialog();
      if (ofdLoadSettings.FileName != "")
      {
        TextReader trSettings = new StreamReader(ofdLoadSettings.FileName);
        tbFolder.Text = trSettings.ReadLine();
        tbFilePatterns.Text = trSettings.ReadLine();
        tbOutputFolder.Text = trSettings.ReadLine();
        tbReplaceStrings.Text = "";
        string sLine;
        while ((sLine = trSettings.ReadLine()) != null)
        {
          tbReplaceStrings.Text = tbReplaceStrings.Text + sLine + "\r\n" + sLine;
        }
        tbReplaceStrings.Text = tbReplaceStrings.Text.Replace("\r\n\r\n", "\r\n");
        trSettings.Close();
      }
    }

    private void btnFolderPicker_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbdOpenFolder = new FolderBrowserDialog();
      fbdOpenFolder.SelectedPath = tbFolder.Text;
      fbdOpenFolder.ShowDialog();
      if (fbdOpenFolder.SelectedPath != "")
        tbFolder.Text = fbdOpenFolder.SelectedPath;
    }

    private void btnOutputFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbdOpenFolder = new FolderBrowserDialog();
      fbdOpenFolder.SelectedPath = tbOutputFolder.Text;
      fbdOpenFolder.ShowDialog();
      if (fbdOpenFolder.SelectedPath != "")
        tbOutputFolder.Text = fbdOpenFolder.SelectedPath;
    }
  }
}
