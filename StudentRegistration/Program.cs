using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistration
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmRegistration registration = new FrmRegistration();
            FrmOpenTextFile openFile = new FrmOpenTextFile();

            
            registration.StartPosition = FormStartPosition.Manual;
            openFile.StartPosition = FormStartPosition.Manual;
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            int gap = 20;
            int left = area.Left + (area.Width - (registration.Width + gap + openFile.Width)) / 2;
            int top = area.Top + (area.Height - Math.Max(registration.Height, openFile.Height)) / 2;
            registration.Location = new Point(Math.Max(area.Left, left), top);
            openFile.Location = new Point(registration.Right + gap, top);

            openFile.Show();                 
            Application.Run(registration);   
        }
    }
}
