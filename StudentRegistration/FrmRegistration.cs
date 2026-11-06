using System;
using System.IO;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class FrmRegistration : Form
    {
        
        internal static readonly string RecordsPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StudentRecords.txt");

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int age;
            if (txtStudentNo.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in Student No., Last Name and First Name.", "Registration");
                return;
            }
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Age must be a number.", "Registration");
                return;
            }

            
            string record =
                "Student No.: " + txtStudentNo.Text.Trim() + Environment.NewLine +
                "Full Name: " + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() + ", " + txtMI.Text.Trim() + Environment.NewLine +
                "Program: " + cboProgram.Text + Environment.NewLine +
                "Gender: " + cboGender.Text + Environment.NewLine +
                "Age: " + age + Environment.NewLine +
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd") + Environment.NewLine +
                "Contact No.: " + txtContactNo.Text.Trim() + Environment.NewLine;

            try
            {
                File.AppendAllText(RecordsPath, record + Environment.NewLine);
                MessageBox.Show("Student registered!", "Registration");
                ClearFields();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not save the record: " + ex.Message, "Error");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to write to " + RecordsPath, "Error");
            }
        }

       
        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord records = new FrmStudentRecord();
            records.FormClosed += (s, args) => this.Show();   
            this.Hide();
            records.Show();
        }

        private void ClearFields()
        {
            txtStudentNo.Clear(); txtLastName.Clear(); txtFirstName.Clear();
            txtMI.Clear(); txtAge.Clear(); txtContactNo.Clear();
            cboProgram.SelectedIndex = -1; cboGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Today;
            txtStudentNo.Focus();
        }
    }
}
