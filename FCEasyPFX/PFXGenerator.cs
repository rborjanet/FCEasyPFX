using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FCEasyPFX
{
    public class PFXGenerator
    {


            public void GeneratePFX(string certURL, string keyURL, string keyPassword, string pfxPassword)
        {


            Process process1 = new Process();
            Process process2 = new Process();
            Process process3 = new Process();


            string Command1 = Application.StartupPath + "\\openssl\\openssl.exe pkcs8 -inform der -in " + keyURL + " -passin pass:" + keyPassword + " -out key.pem";
            string Command2 = Application.StartupPath + "\\openssl\\openssl.exe x509 -inform der -in "+certURL+" -out cer.pem";
            string Command3 = Application.StartupPath + "\\openssl\\openssl.exe pkcs12 -export -in cer.pem -inkey key.pem -out temp.pfx -passout pass:" + pfxPassword;


            //First Process
            
            process1.StartInfo.UseShellExecute = true;
            process1.StartInfo.WorkingDirectory = Application.StartupPath + "\\temp";
            process1.StartInfo.FileName = "cmd.exe";
            process1.StartInfo.Arguments = "/c " + Command1;
            process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process1.Start();
            process1.WaitForExit(10000);


            //Second Process

            process2.StartInfo.UseShellExecute = true;
            process2.StartInfo.WorkingDirectory = Application.StartupPath + "\\temp";
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.Arguments = "/c " + Command2;
            process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process2.Start();
            process2.WaitForExit(10000);

            //Third Process

            process3.StartInfo.UseShellExecute = true;
            process3.StartInfo.WorkingDirectory = Application.StartupPath + "\\temp";
            process3.StartInfo.FileName = "cmd.exe";
            process3.StartInfo.Arguments = "/c " + Command3;
            process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process3.Start();
            process3.WaitForExit(10000);

            Thread.Sleep(1500);


        }

    }
}
