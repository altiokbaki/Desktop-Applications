using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nesne2Lab_1
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }
        //rot exception handling
        //cipher algorithms 
        //button clicks /exceptions.

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblError.Text = "";                                                                         //To catch textbox updates.
            txtBox_Result.Text = "";
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',       //Char array[26].
                        'l', 'm', 'n','o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] message = new char[txtBox_String.Text.Length];
            message = txtBox_String.Text.ToLower().ToCharArray();                                       //Create an char array of message given [Ceaser Cipher].
            char[] encryptedMessage = new char[message.Length];                                         //Created to store encrypted version of given letter(char array[m.length])Ceaser.
            
            char[] key = txtBox_Key.Text.ToLower().ToCharArray();                                       //Create an char array of key given [Vigenére Cipher].
            int[] VKey = new int[key.Length];                                                           //Created to store key in int array(findindexofArray(alphabet,letter)).
            char[] _joinparsedMessages = new char[message.Length];                                      //Created to store Vigenére result.
            for (int p = 0; p < key.Length; p++)
                VKey[p] = Array.IndexOf(alphabet, key[p]);
            //Start of Ceaser Cipher
            if (int.TryParse((txtBox_Rot.Text.ToString()), out int rot) && rbtnCeaser.Checked)
            {                                                                                           //Check if txtBox_Rot isInteger?       
                string result;                                                                          //To print out result->txtBox_Result(string).
                rot %= 26;
                if (rbtnCeaser.Checked && rbtnEncryption.Checked)                                       //RadioButton for Ceaser Cipher (Encryption).
                {
                    result = Ceaser(message, rot, alphabet, encryptedMessage);                          //Send to the Ceaser function that returns string.
                    txtBox_Result.Text = result;                                                        //Show results at txtBox_Result.
                }
                if (rbtnCeaser.Checked && rbtnDecryption.Checked)                                       //RadioButton for Ceaser Cipher (Decryption).
                {
                    result = Ceaser(message, -rot, alphabet, encryptedMessage);                         //Send to the Ceaser function as minus rot.
                    txtBox_Result.Text = result;                                                        //Show results at txtBox_Result.
                }
            }
            else if (true == rbtnCeaser.Checked)                                                        //Else return Error to lblError.
            {
                lblError.Text = "Rot Value should be an integer";
                rot = 0;
            }
            //End of Ceaser Cipher.
            //Start of Vigenére Cipher.
            if (rbtnVigenére.Checked && rbtnEncryption.Checked)                                     //RadioButton for Vigenére Cipher (Encryption).
            {    //Assume that message is aaaaaaaaaaa and key is bbb. We should parse the message to 3 char arrays and send to the ceaser function.
                double a = message.Length, b = VKey.Length;
                double lengthparadox = (a / b);                                                       //To find how many char array we need to create. 3.67 for this example
                int ceiledLength = (int)Math.Ceiling(lengthparadox);                                 //Ceiled to smallest integer that is bigger then message.length/Vkey.length. 4 for this example
                int k = 0;
                string finalResult = "";
                for (int i = 0; i <= VKey.Length; i++)
                {
                    int y = 0;
                    int Vrot = 0;
                    char[] parsedMessage = new char[ceiledLength];
                    if (VKey.Length <= i)
                        goto result;
                    else
                    {
                        Vrot = VKey[i];
                    }
                    int z = k;
                    for (int j = 0; j <= ceiledLength + k; j++)
                    {
                        if (z >= message.Length || message[z] == 0)
                            goto function;
                        else
                        {
                            parsedMessage[j] = message[z];
                        }
                        z += VKey.Length;
                    }
                    string parsedResult;
                function: parsedResult = Ceaser(parsedMessage, Vrot, alphabet, encryptedMessage);
                    char[] parsedResultarray = new char[parsedResult.ToCharArray().Length];
                    parsedResultarray = parsedResult.ToCharArray();

                    for (int x = k; x <= _joinparsedMessages.Length; x += VKey.Length)
                    {
                        if (x >= _joinparsedMessages.Length)
                            break;
                        else
                        {
                            _joinparsedMessages[x] = parsedResultarray[y];
                            y++;
                        }
                    }
                    k++;
                    if (k == VKey.Length)
                    {
                        for (int r = 0; r < _joinparsedMessages.Length; r++)
                        {
                            finalResult += _joinparsedMessages[r].ToString();
                        }
                        goto result;
                    }
                }

                for (int r = 0; r < _joinparsedMessages.Length; r++)
                {
                    finalResult += _joinparsedMessages[r].ToString();
                }
            result: textBox1.Text = finalResult;
            }
            if (rbtnVigenére.Checked && rbtnDecryption.Checked)
            {
                double a = message.Length, b = VKey.Length;
                double lengthparadox = (a / b);                                                       //To find how many char array we need to create. 3.67 for this example
                int ceiledLength = (int)Math.Ceiling(lengthparadox);                                 //Ceiled to smallest integer that is bigger then message.length/Vkey.length. 4 for this example
                int k = 0;
                string finalResult = "";
                for (int i = 0; i <= VKey.Length; i++)
                {
                    int y = 0;
                    int Vrot = 0;
                    char[] parsedMessage = new char[ceiledLength];
                    if (VKey.Length <= i)
                        goto result;
                    else
                    {
                        Vrot = VKey[i];
                    }
                    int z = k;
                    for (int j = 0; j <= ceiledLength + k; j++)
                    {
                        if (z >= message.Length || message[z] == 0)
                            goto function;
                        else
                        {
                            parsedMessage[j] = message[z];
                        }
                        z += VKey.Length;
                    }
                    string parsedResult;
                function: parsedResult = Ceaser(parsedMessage, -Vrot, alphabet, encryptedMessage);
                    char[] parsedResultarray = new char[parsedResult.ToCharArray().Length];
                    parsedResultarray = parsedResult.ToCharArray();

                    for (int x = k; x <= _joinparsedMessages.Length; x += VKey.Length)
                    {
                        if (x >= _joinparsedMessages.Length)
                            break;
                        else
                        {
                            _joinparsedMessages[x] = parsedResultarray[y];
                            y++;
                        }
                    }
                    k++;
                    if (k == VKey.Length)
                    {
                        for (int r = 0; r < _joinparsedMessages.Length; r++)
                        {
                            finalResult += _joinparsedMessages[r].ToString();
                        }
                        goto result;
                    }
                }

                for (int r = 0; r < _joinparsedMessages.Length; r++)
                {
                    finalResult += _joinparsedMessages[r].ToString();
                }
            result: textBox1.Text = finalResult;
            }
           
        }
        //Start of Ceaser function.
        string Ceaser(char[] _message,int _rot,char[] _alphabet,char[] _encryptedMessage)                 //This function takes a string letter, rotvalue as integer
        {                                                                                                 //And 2 char array 1 to get accepted and find index alphabet and
                                                                                                          //1 to Return encrypted letter into string.
            int pos = 0, newpos = 0;
            for (int i = 0; i < _message.Length; i++)
            {
                char letter = _message[i];
                if (_message[i] == '\0')
                {
                    letter = ' ';
                    _encryptedMessage[i] = letter;

                }
                else if (0 > Array.BinarySearch(_alphabet, letter)) {                                         //If value is not found in alphabet it return negatvie and Error shown.
                    lblError.Text = "Message cannot contain of range characters.";                
                    }     
                else                                                                                     //Else binarysearch returns postive value and function continues.
                {
                    pos = Array.IndexOf(_alphabet, letter);
                    if ((pos + _rot) <= 0)
                    {
                        newpos = ((pos + _rot) + 26) % 26;
                    }
                    else
                    {
                        newpos = (pos + _rot) % 26;
                    }
                    char encryptedchar = _alphabet[newpos];
                    _encryptedMessage[i] = encryptedchar;

                }
            }
            return string.Join("", _encryptedMessage);
        }
        //End of Ceaser function.
        //Start of isNumeric function.
        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox_Key.Text = "";
            txtBox_Result.Text = "";
            txtBox_Rot.Text = "";
            txtBox_String.Text = "";
            textBox1.Text = "";
            rbtnCeaser.Checked = false;
            rbtnDecryption.Checked = false;
            rbtnEncryption.Checked = false;
            rbtnVigenére.Checked = false;
        }

        private void Encryption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Applications ap2 = new Applications();
            ap2.Show();
            this.Hide();
        }

        private void rbtnCeaser_CheckedChanged(object sender, EventArgs e)
        {

        }
        //End of isNumeric function.
    }
}
