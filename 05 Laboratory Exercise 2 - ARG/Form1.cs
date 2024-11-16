using System.IO;
using System.Windows.Forms;

// Paala, James P.          BSIT - 501

namespace FrmReadingFiles
{
    public partial class Form1 : Form
    {
        public static string path;
        public Form1()
        {
            InitializeComponent();
        }
        private void find_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            path_link.Text = openFileDialog1.FileName;

        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
        }
    }
}
