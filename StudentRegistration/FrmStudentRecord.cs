using System;
using System.IO;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(FrmRegistration.RecordsPath);
            openFileDialog1.Title = "Find Student Records";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                lvRecords.Items.Clear();
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        lvRecords.Items.Add(line);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read the file: " + ex.Message, "Error");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to open this file.", "Error");
            }
        }

        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvRecords.Items.Clear();
        }
    }
}
