//  Task 5 - to encrypt and decrypt your fullname. 
namespace Assignment__1_DataSecurity_Encoding.Models
{
    internal class EncryptDecrypt
    {
        //Decryption


        public void DecryptMessage(string encryptedMessage, int key)

        {
            string decryptedMessage = "";

            foreach (char c in encryptedMessage)

            {
                if (char.IsLetter(c))
                {
                    int ascii = (int)c;
                    ascii -= key;
                    char decryptedChar = (char)(ascii);
                    decryptedMessage += decryptedChar;
                }
                else
                {
                    decryptedMessage += c;
                }
            }

            Console.WriteLine($"decryptedMessage = {decryptedMessage}");

        }

        //Encryption



        public string EncryptMessage(string message, int key)
        {

            string encryptedMessage = "";

            foreach (char c in message)

            {
                //The char.IsLetter(c) is used to determine whether a given character c is a letter of the alphabet.
                if (char.IsLetter(c))
                {
                    int ascii = (int)c;
                    ascii += key;
                    char encryptedChar = (char)(ascii);
                    encryptedMessage += encryptedChar;
                }
                else
                {
                    encryptedMessage += c;
                }
            }

            Console.WriteLine($"encryptedMessage = {encryptedMessage}");
            return encryptedMessage;

        }
    }
}
