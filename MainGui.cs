using System;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace PsVDecrypt
{
    public partial class MainGui : Form
    {
        List<string> _coursesList = new List<string>();
        ListBox.SelectedObjectCollection _coursesToConverted;

        public MainGui()
        {
            InitializeComponent();
        }

        private String SelectedPathFolder;
        private String InputPathFolder;
        private String OutPutPathFolder;
        private static SQLiteConnection _dbConn;
        private string dbdir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Pluralsight", "pluralsight.db");
 

        private void sameLocationCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (sameLocationCheck.Checked)
            {
                if (!Directory.Exists(InputPathFolder))
                {
                    sameLocationCheck.Text = "NO";
                    MessageBox.Show("Hey. Please provide an existing folder.");
                    OutPutPathButton.Enabled = true;
                    OutPutPathText.Enabled = true;
                    sameLocationCheck.Checked = false;
                } else
                {
                    if (SelectedPathFolder is null)
                        SelectedPathFolder = InputPathTextBox.Text;

                    OutPutPathFolder = Path.Combine(SelectedPathFolder, "Pluralsight", "converted");
                    OutPutPathText.Text = OutPutPathFolder;
                    sameLocationCheck.Text = "YES";
                    OutPutPathButton.Enabled = false;
                    OutPutPathText.Enabled = false;
                }
            } else
            {
                sameLocationCheck.Text = "NO";
                OutPutPathButton.Enabled = true;
                OutPutPathText.Enabled = true;
                sameLocationCheck.Checked = false;
            }
        }

        private void InputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description =
            "Select the directory that you specify to load courses.";

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                SelectedPathFolder = folderBrowserDialog1.SelectedPath;

                InputPathFolder = Path.Combine(SelectedPathFolder, "Pluralsight", "courses");
                InputPathTextBox.Text = InputPathFolder;

                if (!Directory.Exists(InputPathFolder))
                {
                    MessageBox.Show("Pluralsight courses directory not found!");
                    InputPathTextBox.Text = "";
                }
            }

        }

        private void OutPutPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description =
            "Select the directory that you specify to save converted courses.";

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var folderName = folderBrowserDialog1.SelectedPath;
                OutPutPathFolder = Path.Combine(folderName, "Plurasight", "converted");
                OutPutPathText.Text = OutPutPathFolder;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(dbdir))
            {
                MessageBox.Show("The db file could not be found!");
                InputPathTextBox.Text = "The db file could not be found! " +
                    "Please check. Then reopen the tool again.";
                InputPathButton.Enabled = false;
                OutPutPathButton.Enabled = false;
                sameLocationCheck.Enabled = false;
            } else
            {
                _dbConn = new SQLiteConnection("Data Source=" + dbdir + ";Version=3;");
                _dbConn.Open();
            }
            
        }

        private void listCousesButton_Click(object sender, EventArgs e)
        {
            _coursesList.Clear();

            var coursesdirs = Directory.GetDirectories(InputPathFolder);
            //MessageBox.Show("\nFound " + coursesdirs.Length + " course(s):");
            if (coursesdirs.Length > 0)
            {
                foreach (var dir in coursesdirs)
                {
                    _coursesList.Add(dir);
                }

                coursesListBox.Enabled = true;

                // Get the current selection mode
                SelectionMode selectionMode = coursesListBox.SelectionMode;

                // Set the selection mode to none
                coursesListBox.SelectionMode = SelectionMode.None;

                // Set a new DataSource
                coursesListBox.DataSource = _coursesList;

                // Set back the original selection mode
                coursesListBox.SelectionMode = selectionMode;

                searchBox.Enabled = true;
                convertButton.Enabled = true;
                LabelBak2.Text = "Total: " + coursesdirs.Length + " course(s)";
                dstOpenButton.Enabled = true;
                srcOpenButton.Enabled = true;

            }
            else
            {
                LabelBak2.Text = "Found no courses at the given path!";
            }
        }

        private void OutPutPathText_TextChanged(object sender, EventArgs e)
        {
            listCousesButton.Enabled = true;
            //var convertlist = coursesListBox.SelectedItems;
        }

        private void searchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (searchBox.Enabled)
            {
                searchBox.Text = "";
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            _coursesToConverted = coursesListBox.SelectedItems;
            
            if (_coursesToConverted.Count <= 0)
            {
                MessageBox.Show("Please select course(s) to convert.");
            } else
            {
                try
                {
                    if (!Directory.Exists(OutPutPathFolder))
                    {
                        Util.CreateDirectory(OutPutPathFolder);
                    }

                    foreach (var course in _coursesToConverted)
                    {

                        Thread convertThread = new Thread(() => Program.DecryptCourse(course.ToString(), OutPutPathFolder, _dbConn));

                        try
                        {
                            convertThread.Start();

                            do
                            {
                                LabelBak2.Text = "Converting... " + course.ToString();
                                LabelBak3.Text = "PLEASE WAIT!";
                            } while (convertThread.IsAlive);

                            LabelBak2.Text = course.ToString() + " converted.";
                            LabelBak3.Text = "";


                        } catch (Exception anException)
                        {
                            MessageBox.Show(anException.StackTrace);
                        }
                    

                    }

                    _coursesToConverted.Clear();

                } catch (Exception exceptionThis)
                {
                    MessageBox.Show("Some error occurred:\n " + exceptionThis.StackTrace);
                }
            }

        }

        private void srcOpenButton_Click(object sender, EventArgs e)
        {

            if (coursesListBox.SelectedItems.Count == 1)
            {
                try
                {
                    Process.Start(@coursesListBox.SelectedItem.ToString());
                } catch
                {
                    MessageBox.Show("Oop. There is something must be wrong! Please check.");
                }
                
            } else
            {
                LabelBak2.Text = "Please one item each time!";
                LabelBak3.Text = "ERROR!";
            }
        }

        private void dstOpenButton_Click(object sender, EventArgs e)
        {
            if (coursesListBox.SelectedItems.Count == 1)
            {
                String selectedCourseName = Path.GetFileNameWithoutExtension(coursesListBox.SelectedItem.ToString());
                try
                {
                    Process.Start(@Path.Combine(OutPutPathFolder, selectedCourseName));
                } catch
                {
                    MessageBox.Show("Please check if the course had been converted or not.");
                }
            }
            else
            {
                LabelBak2.Text = "Please one item each time!";
                LabelBak3.Text = "ERROR!";
            }
        }
    }
}
