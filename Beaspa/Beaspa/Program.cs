using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Beaspa
{
    static class Program
    {
        private static string LockerFileFolder { get; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Loaderon";
        private static string LockerFilePath { get; } = LockerFileFolder + "\\loaderon";
        private static string LockerPassword { get; } = "c1341157-da30-4851-b2e0-32ee9119099c";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            executeSecurityCheckingAndActAccordingly();
        }

        private static void executeSecurityCheckingAndActAccordingly()
        {
            if (File.Exists(LockerFilePath))
                checkPasswordAndActAccordingly();
            else
                createFileAskAndSavePasswordAndRetry();
        }

        private static void checkPasswordAndActAccordingly()
        {
            string passwordInFile = File.ReadAllText(LockerFilePath);
            comparePasswordsAndActAccordingly(passwordInFile, LockerPassword);
        }

        private static void comparePasswordsAndActAccordingly(string hashedPasswordInFile, string hashedLockerPassword)
        {
            bool areSame = hashedPasswordInFile.Equals(hashedLockerPassword, StringComparison.Ordinal);
            if (areSame)
                Application.Run(new MainForm());
            else
                MessageBox.Show("Programa Inválido, solicite validación a: alvaroscelza@gmail.com");
        }

        private static void createFileAskAndSavePasswordAndRetry()
        {
            Directory.CreateDirectory(LockerFileFolder);
            string password = Interaction.InputBox("Ingresa la contraseña para activar el programa", "Activar Programa", "");
            File.WriteAllText(LockerFilePath, password);
            checkPasswordAndActAccordingly();
        }
    }
}
