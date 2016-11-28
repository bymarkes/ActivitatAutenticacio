using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ActivitatAutenticacio
{
    public partial class Form1 : Form
    {
        const String filepath = @"C:\Users\DAM05\Desktop\usersLog.txt"; //Ruta especifica de l'arxiu on es guarden usuari, salt i hash de la contrasenya.

        public Form1()
        {
            InitializeComponent();

            //Comprovem que l'arxiu existeixi, sino el creem
            if (!(File.Exists(filepath)))
            {
                using (File.Create(filepath)) ; //Creem l'arxiu
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (signName.Text == "" || signPass.Text == "" || signPass2.Text == "") //Comprovem que els camps no estiguin buits
            {
                MessageBox.Show("Has d'omplir tots els camps");
            }
            else if (signPass.Text != signPass2.Text) //Comprovem que els camps de les contrasenyes coincideixin
            {
                MessageBox.Show("Les contrasenyes han de coincidir");
            }
            else
            {
                String username;
                String password;
                //Asignem cada camp a una variable
                username = signName.Text;  

                password = signPass.Text;

                signIn(username, password);

            }
        }

        private void signIn(String username, String password)
        {
            //Generem un salt
            byte[] salt = doSalt();
            //Generem un hash de la contrassenya
            string hash = doHash(password, salt);

            String saltConverted = Convert.ToBase64String(salt);

            String newUser = username + "," + saltConverted + "," + hash; //Conquetenem tota la info
            
            //Guardem tota la informació al arxiu
            System.IO.File.AppendAllText(filepath, newUser);
            MessageBox.Show("Usuari creat correctament.");

        }

        private static byte[] doSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        private static string doHash(string password, byte[] salt)
        {
            var hsh = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = hsh.GetBytes(32);
            return Convert.ToBase64String(hash);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (logName.Text == "" || logPass.Text == "") //Comprovem que els camps no es trobin buits
            {
                MessageBox.Show("Has d'omplir tots els camps");
            }
            else
            {
                LogIn(logName.Text, logPass.Text);
            }
        }

        private void LogIn(string nomUsuari, string passUsuari)
        {
            string usuari = buscarUsuari(nomUsuari); //Busquem si l'usuari introduït existeix
            string msgbox = verificarLogIn(usuari, passUsuari);
            MessageBox.Show(msgbox);
        }

        private string buscarUsuari(string nomUsuari)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string linia;
                    string[] usuario;

                    while ((linia = sr.ReadLine()) != null)//While que llegeix linia per linia l'arxiu
                    {
                        //Llegeix fins trobar una ',' (El nom d'usuari), (Salt), (Hash)
                        usuario = linia.Split(',');

                        if (usuario[0] == nomUsuari)
                        {
                            return usuario[0] + ',' + usuario[1] + ',' + usuario[2];
                        }
                    }
                }
                return "No s'ha trobat l'usuari.";
            }
            catch
            {
                return "ErrorAlLlegir";
            }
        }
        public static string verificarLogIn(string usuariArxiu, string passUsuari)
        {
            string[] usuari;

            byte[] saltArxiu;

            if (usuariArxiu == "No s'ha trobat l'usuari.")
            {
                return "No s'ha trobat l'usuari.";
            }
            else if (usuariArxiu == "No s'ha trobat l'usuari.")
            {
                return "Hi ha hagut un error i no s'ha pogut llegir l'arxiu";
            }
            else
            {
                usuari = usuariArxiu.Split(',');

                saltArxiu = Convert.FromBase64String(usuari[1]);

                //Calculem el hash amb la salt guardada i la contrasenya entrada
                string hash = doHash(passUsuari, saltArxiu);

                //Comparem el hash guardat amb el generat
                if (hash == usuari[2])
                {
                    return "Usuari identificat correctament.";
                }
                else
                {
                    return "La contrasenya no coincideix.";
                }

            }
        }
    }
}
