using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCEasyPFX
{
    public partial class Main : Form
    {

        PFXGenerator pfxGenerator;
        public Main()
        {
            InitializeComponent();
            lblUrlCert.Text = "";
            lblUrlPrivateKey.Text = "";
            pfxGenerator = new PFXGenerator();
        }

        public void ClearFields()
        {

            lblUrlCert.Text = "";
            lblUrlPrivateKey.Text = "";
            txbPassword.Text = "";
            Utils.FileUtils.DeleteFiles(Application.StartupPath + "/temp");

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
   
        }

        private void btnGeneratePFX_Click(object sender, EventArgs e)
        {
            //Clear files
            Utils.FileUtils.DeleteFiles(Application.StartupPath + "/temp");
            pfxGenerator.GeneratePFX(lblUrlCert.Text, lblUrlPrivateKey.Text, txbPassword.Text, txbPasswordPFX.Text);

            if (File.Exists(Application.StartupPath + "\\temp\\temp.pfx"))
            {
                SavePFX();
                ClearFields();
                
            }
            else
            {
                MessageBox.Show("No se pudo generar el archivo PFX :(\nVerifica que el certificado (.cer), la llave privada (.key) y la contraseña sea correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SavePFX()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos PFX (*.pfx)|*.pfx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    string path = Application.StartupPath + "\\temp\\temp.pfx";

                    var bytes = File.ReadAllBytes(path);

                    myStream.Write(bytes, 0, bytes.Length);

                    myStream.Close();

                    MessageBox.Show("El PFX se ha guardado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUploadCer_Click(object sender, EventArgs e)
        {
     
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Certificados (*.cer)|*.cer";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    lblUrlCert.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    
                }
            }
        }

        private void btnUploadPrivateKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Certificados (*.key)|*.key";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    lblUrlPrivateKey.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream

                }
            }
        }
    }
}
