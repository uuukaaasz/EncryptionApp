using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region --- SZYFROWANIE SYMETRYCZNE ---
        #region Wykonaj operację
        private void buttonSym_Click(object sender, EventArgs e)
        {
            if (comboBoxSym.SelectedIndex < 0)                                              //walidacja comboBox
            {
                MessageBox.Show("Wybierz wartość dla pola comboBox 'Co chcesz zrobić?'");
            }
            else if (string.IsNullOrWhiteSpace(textBoxInputSym.Text))                       //walidacja textBox
            {
                MessageBox.Show("Wypełnij pole 'Wprowadź tekst'");
            }
            else
            {
                string textSym = textBoxInputSym.Text;                                      //wczytanie wartości z textBoxa
                string password = "zaq1@WSX";                                               //stworzenie hasła
                byte[] Salt = Symmetric.GenerateSalt();                                     //wygenerowanie soli
                byte[] IV = Symmetric.GenerateIV();                                         //wygenerowanie IV
                byte[] key = Symmetric.CreateKey(password, Salt);                           //stworzenie klucza

                string Encrypted = Symmetric.EncryptString(textSym, key, IV);               //funkcja szyfrowania
                string Decrypted = Symmetric.DecryptString(Encrypted, key, IV);             //funkcja deszyfrowania

                if (comboBoxSym.SelectedIndex == 1) { textBoxResultSym.Text = Decrypted; }  //odszyfrowywanie
                if (comboBoxSym.SelectedIndex == 0) { textBoxResultSym.Text = Encrypted; }  //zaszyfrowywanie
            }
        }
        #endregion

        #region Symetryczne szyfrowanie pliku
        private void buttonSymFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki textowe (txt)|*.txt";                        //połączenie z plikiem
            if (dialog.ShowDialog() == DialogResult.OK)                         //sprawdzenie połączenia 
            {
                textBoxInputSym.Text = File.ReadAllText(dialog.FileName);       //przypisanie wartości z pliku do textBoxa "Wprowadź tekst"
                string toEncrypt = File.ReadAllText(dialog.FileName);           //przypisanie wartości z pliku do zmiennej
                string password = "zaq1@WSX";                                   //stworznie hasła
                byte[] Salt = Symmetric.GenerateSalt();                         //wygenerowanie soli
                byte[] IV = Symmetric.GenerateIV();                             //wygenerowanie IV
                byte[] key = Symmetric.CreateKey(password, Salt);               //stworzenie klucza
                string Encrypted = Symmetric.EncryptString(toEncrypt, key, IV); //zaszyfrowanie treści
                textBoxResultSym.Text = Encrypted;                              //przypisanie wyniku
            }
        }
        #endregion

        #region Wyczyść formularz
        private void buttonSymClear_Click(object sender, EventArgs e)
        {
            textBoxInputSym.Clear();        //czyszczenie textBoxa "Wprowadź text"
            textBoxResultSym.Clear();       //czyszczenie textBoxa "Wynik"
            comboBoxSym.ResetText();        //czyszczenie wartości comboBoxa
        }
        #endregion
        #endregion
        
        #region --- SZYFROWANIE ASYMETRYCZNE ---
        #region Wykonaj operację
        private void buttonAsym_Click(object sender, EventArgs e)
        {
            if (comboBoxAsym.SelectedIndex < 0)                                             //walidacja textBox
            {
                MessageBox.Show("Wybierz wartość dla pola comboBox 'Co chcesz zrobić?'");
            }
            else if (string.IsNullOrWhiteSpace(textBoxInputAsym.Text))                      //walidacja comboBox
            {
                MessageBox.Show("Wypełnij pole 'Wprowadź tekst'");
            }
            else
            {
                var cryptoServiceProvider = new RSACryptoServiceProvider(2048);             //długość klucza
                var privateKey = cryptoServiceProvider.ExportParameters(true);              //klucz prywatny
                var publicKey = cryptoServiceProvider.ExportParameters(false);              //klucz publiczny

                string publicKeyString = Asymmetric.GetKeyString(publicKey);                //przypisanie klucza publicznego do stringa
                string privateKeyString = Asymmetric.GetKeyString(privateKey);              //przypisanie klucza prywatnego do stringa

                textBoxPublicKey.Text = publicKeyString;                                    //wypisanie klucza publicznego w textBoxie
                textBoxPrivateKey.Text = privateKeyString;                                  //wypisanie klucza prywatnego w textBoxie
                string inputText = textBoxInputAsym.Text;                                   //przypisanie zawartości textBoxa do zmiennej
                string encryptedText = Asymmetric.Encrypt(inputText, publicKeyString);      //funkcja szyfrowania
                string decryptedText = Asymmetric.Decrypt(encryptedText, privateKeyString); //funkcja deszyfrowania

                if (comboBoxAsym.SelectedIndex == 0) { textBoxResultAsym.Text = encryptedText; }
                if (comboBoxAsym.SelectedIndex == 1) { textBoxResultAsym.Text = decryptedText; }
            }
        }
        #endregion

        #region Asymetryczne szyfrowanie pliku
        private void buttonAsymFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki textowe (txt)|*.txt";                        //połączenie z plikiem
            if (dialog.ShowDialog() == DialogResult.OK)                         //sprawdzenie połączenia 
            {
                textBoxInputAsym.Text = File.ReadAllText(dialog.FileName);      //przypisanie wartości z pliku do textBoxa "Wprowadź tekst"
                string toEncrypt = File.ReadAllText(dialog.FileName);           //przypisanie wartości z pliku do zmiennej
                var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //długość klucza 
                var privateKey = cryptoServiceProvider.ExportParameters(true);  //klucz prywatny
                var publicKey = cryptoServiceProvider.ExportParameters(false);  //klucz publiczny

                string publicKeyString = Asymmetric.GetKeyString(publicKey);    //przypisanie klucza publicznego do stringa
                string privateKeyString = Asymmetric.GetKeyString(privateKey);  //przypisanie klucza prywatnego do stringa

                textBoxPublicKey.Text = publicKeyString;                        //wypisanie klucza publicznego w textBoxie
                textBoxPrivateKey.Text = privateKeyString;                      //wypisanie klucza prywatnego w textBoxie
                string encryptedText = Asymmetric.Encrypt(toEncrypt, publicKeyString);
                textBoxResultAsym.Text = encryptedText;                         //wypisywanie zaszyfrowanego wyniku w textBoxie
            }
        }
        #endregion

        #region Czyszczenie formularza
        private void buttonAsymClear_Click(object sender, EventArgs e)
        {
            textBoxInputAsym.Clear();                   //czyszczenie textBoxa "Wprowadź text"
            textBoxResultAsym.Clear();                  //czyszczenie textBoxa "Wynik"
            textBoxPublicKey.Clear();                   //czyszczenie textBoxa "Klucz publiczny"
            textBoxPrivateKey.Clear();                  //czyszczenie textBoxa "Klucz prywatny"
            comboBoxAsym.ResetText();                   //czyszczenie wartości comboBoxa
        }
        #endregion
        #endregion
    }
}
