using Assignment__1_DataSecurity_Encoding.Models;

Console.WriteLine("Assignment 1- Data Security, Encoding, Encryption and Privacy ");



Console.WriteLine("\nEnter your Full name =   ");



String fullName= Console.ReadLine();
//Task 2: Binary Converter

Console.WriteLine("\n\n ========== Task 2: Binary Converter ========== \n\n");

BinaryConverter base2 = new BinaryConverter();

string binaryData = base2.StringToBinary(fullName); //Encodig: convert string to binary base2.BinaryToString(binaryData); //Decoding : Convert Binary to string
string stringdata = base2.BinaryToString(binaryData);
///Task 3: Hexadecimal Converter

Console.WriteLine("\n\n ============= Task 3: Hexadecimal Converter ============= \n\n");

HexadecimalConverter base16 = new HexadecimalConverter();
string hexadecimalData = base16.StringToHexadecimal(fullName); //Encodig: convert string to hexadecimal
base16.HexadecimalToString(hexadecimalData); //Decoding : Convert back to string

//Task 4: Base64Converter

Console.WriteLine("\n\n ============= Task 4: Base64Converter Converter ========== \n\n");

Base64Converter base64 = new Base64Converter();

base64.StringToBase64(fullName);

//Task 5

Console.WriteLine("\n ========== Task 5 - EncryptDecrypt : Shift Chipher ========== \n");
//console.urite("Enter key (int value for shift cipher) =
//int key = Convert.ToInt32(Console.ReadLine());
EncryptDecrypt ed = new EncryptDecrypt();

string encrypedMessage = ed.EncryptMessage(fullName, 2);
ed.DecryptMessage(encrypedMessage, 2);

