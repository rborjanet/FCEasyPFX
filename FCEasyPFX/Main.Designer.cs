
namespace FCEasyPFX
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnUploadCer = new System.Windows.Forms.Button();
            this.lblCert = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnUploadPrivateKey = new System.Windows.Forms.Button();
            this.gpbCertificados = new System.Windows.Forms.GroupBox();
            this.gpbPFX = new System.Windows.Forms.GroupBox();
            this.txbPasswordPFX = new System.Windows.Forms.TextBox();
            this.lblPasswordPFX = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnGeneratePFX = new System.Windows.Forms.Button();
            this.lblUrlCert = new System.Windows.Forms.Label();
            this.lblUrlPrivateKey = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.gpbCertificados.SuspendLayout();
            this.gpbPFX.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadCer
            // 
            this.btnUploadCer.Location = new System.Drawing.Point(587, 24);
            this.btnUploadCer.Name = "btnUploadCer";
            this.btnUploadCer.Size = new System.Drawing.Size(165, 23);
            this.btnUploadCer.TabIndex = 0;
            this.btnUploadCer.Text = "Cargar certificado";
            this.btnUploadCer.UseVisualStyleBackColor = true;
            this.btnUploadCer.Click += new System.EventHandler(this.btnUploadCer_Click);
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.Location = new System.Drawing.Point(32, 29);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(84, 13);
            this.lblCert.TabIndex = 1;
            this.lblCert.Text = "Certiicado (.cer):";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(12, 78);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(104, 13);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Llave Privada (.key):";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(52, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(125, 119);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(330, 20);
            this.txbPassword.TabIndex = 4;
            // 
            // btnUploadPrivateKey
            // 
            this.btnUploadPrivateKey.Location = new System.Drawing.Point(587, 68);
            this.btnUploadPrivateKey.Name = "btnUploadPrivateKey";
            this.btnUploadPrivateKey.Size = new System.Drawing.Size(165, 23);
            this.btnUploadPrivateKey.TabIndex = 5;
            this.btnUploadPrivateKey.Text = "Cargar llave privada";
            this.btnUploadPrivateKey.UseVisualStyleBackColor = true;
            this.btnUploadPrivateKey.Click += new System.EventHandler(this.btnUploadPrivateKey_Click);
            // 
            // gpbCertificados
            // 
            this.gpbCertificados.Controls.Add(this.lblUrlPrivateKey);
            this.gpbCertificados.Controls.Add(this.lblUrlCert);
            this.gpbCertificados.Controls.Add(this.lblCert);
            this.gpbCertificados.Controls.Add(this.btnUploadPrivateKey);
            this.gpbCertificados.Controls.Add(this.btnUploadCer);
            this.gpbCertificados.Controls.Add(this.txbPassword);
            this.gpbCertificados.Controls.Add(this.lblPrivateKey);
            this.gpbCertificados.Controls.Add(this.lblPassword);
            this.gpbCertificados.Location = new System.Drawing.Point(3, 12);
            this.gpbCertificados.Name = "gpbCertificados";
            this.gpbCertificados.Size = new System.Drawing.Size(776, 168);
            this.gpbCertificados.TabIndex = 6;
            this.gpbCertificados.TabStop = false;
            this.gpbCertificados.Text = "Certificados";
            // 
            // gpbPFX
            // 
            this.gpbPFX.Controls.Add(this.txbPasswordPFX);
            this.gpbPFX.Controls.Add(this.lblPasswordPFX);
            this.gpbPFX.Controls.Add(this.checkedListBox2);
            this.gpbPFX.Location = new System.Drawing.Point(3, 187);
            this.gpbPFX.Name = "gpbPFX";
            this.gpbPFX.Size = new System.Drawing.Size(776, 100);
            this.gpbPFX.TabIndex = 7;
            this.gpbPFX.TabStop = false;
            this.gpbPFX.Text = "PFX";
            // 
            // txbPasswordPFX
            // 
            this.txbPasswordPFX.Location = new System.Drawing.Point(125, 44);
            this.txbPasswordPFX.Name = "txbPasswordPFX";
            this.txbPasswordPFX.Size = new System.Drawing.Size(330, 20);
            this.txbPasswordPFX.TabIndex = 10;
            this.txbPasswordPFX.Text = "123456";
            // 
            // lblPasswordPFX
            // 
            this.lblPasswordPFX.AutoSize = true;
            this.lblPasswordPFX.Location = new System.Drawing.Point(52, 47);
            this.lblPasswordPFX.Name = "lblPasswordPFX";
            this.lblPasswordPFX.Size = new System.Drawing.Size(64, 13);
            this.lblPasswordPFX.TabIndex = 9;
            this.lblPasswordPFX.Text = "Contraseña:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(424, 274);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox2.TabIndex = 11;
            // 
            // btnGeneratePFX
            // 
            this.btnGeneratePFX.Location = new System.Drawing.Point(607, 301);
            this.btnGeneratePFX.Name = "btnGeneratePFX";
            this.btnGeneratePFX.Size = new System.Drawing.Size(165, 23);
            this.btnGeneratePFX.TabIndex = 6;
            this.btnGeneratePFX.Text = "Generar PFX";
            this.btnGeneratePFX.UseVisualStyleBackColor = true;
            this.btnGeneratePFX.Click += new System.EventHandler(this.btnGeneratePFX_Click);
            // 
            // lblUrlCert
            // 
            this.lblUrlCert.AutoSize = true;
            this.lblUrlCert.Location = new System.Drawing.Point(125, 33);
            this.lblUrlCert.Name = "lblUrlCert";
            this.lblUrlCert.Size = new System.Drawing.Size(193, 13);
            this.lblUrlCert.TabIndex = 6;
            this.lblUrlCert.Text = "_______________________________";
            // 
            // lblUrlPrivateKey
            // 
            this.lblUrlPrivateKey.AutoSize = true;
            this.lblUrlPrivateKey.Location = new System.Drawing.Point(125, 78);
            this.lblUrlPrivateKey.Name = "lblUrlPrivateKey";
            this.lblUrlPrivateKey.Size = new System.Drawing.Size(193, 13);
            this.lblUrlPrivateKey.TabIndex = 7;
            this.lblUrlPrivateKey.Text = "_______________________________";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(12, 301);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(165, 23);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Limpiar campos";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnGeneratePFX);
            this.Controls.Add(this.gpbPFX);
            this.Controls.Add(this.gpbCertificados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Factura Center PFX 1.0.2";
            this.gpbCertificados.ResumeLayout(false);
            this.gpbCertificados.PerformLayout();
            this.gpbPFX.ResumeLayout(false);
            this.gpbPFX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadCer;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnUploadPrivateKey;
        private System.Windows.Forms.GroupBox gpbCertificados;
        private System.Windows.Forms.GroupBox gpbPFX;
        private System.Windows.Forms.TextBox txbPasswordPFX;
        private System.Windows.Forms.Label lblPasswordPFX;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnGeneratePFX;
        private System.Windows.Forms.Label lblUrlPrivateKey;
        private System.Windows.Forms.Label lblUrlCert;
        private System.Windows.Forms.Button btnClearFields;
    }
}

