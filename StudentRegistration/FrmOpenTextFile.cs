using System;
using System.IO;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class FrmOpenTextFile : Form
    {
        private string path;

        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return; 

            path = openFileDialog1.FileName;

            try
            {
                lvShowText.Items.Clear();

                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }

                if (lvShowText.Items.Count == 0)
                    throw new EmptyFileException();
            }
            catch (EmptyFileException ex)
            {
                MessageBox.Show(ex.Message, "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to open this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
