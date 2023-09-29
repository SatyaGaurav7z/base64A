// Task 2 - BinaryConverter to Convert your name to Binary

namespace Assignment__1_DataSecurity_Encoding.Models
{
    internal class BinaryConverter
    {

        public string StringToBinary(string inputStr) //Apple  - update void to string
        {
            string binaryverion = ""; //will store resule i.e. binary data 
            foreach (char c in inputStr) //read each char of inputStr 
            {

                string binary = "";

                int asciiValue = (int)c; //take ascii value

                while (asciiValue > 1) // 65 > 1

                {

                    int remainder = asciiValue % 2; //65 % 2 = 1
                    binary = Convert.ToString(remainder) + binary;
                    asciiValue /= 2; //65 /2 32
                }

                binary = Convert.ToString(asciiValue) + binary;

                binaryverion = binaryverion + binary.PadLeft(8, '0');
                Console.WriteLine("8 bit ASCII for {0} = {1} Binary = {2}", c, (int)c, binary.PadLeft(8, '0'));
                //// Console.WriteLine("7 bit ASCII for (0) = (1) Binary = {2}", c, (int)c, binary.PadLeft(7, '0')); 
                //Console.WriteLine();
            }
            Console.WriteLine($"Length of Binary string = {binaryverion.Length} databits "); ; Console.WriteLine($"Binary string {binaryverion}");
            return binaryverion; //add this line
        }
        //Decoding
        public string BinaryToString(string binaryData) // 010011100010000001010011: N S: 24 
        {

            string result = "";

            for (int i = 0; i < binaryData.Length; i += 8)
            {

                string first8_bits = binaryData.Substring(i, 8); // read 8 bits 
                int number = Convert.ToInt32(first8_bits, 2); // (01001110,2) = ascii value 
                result += (char)number;
            }

            Console.WriteLine("Binary to string = " + result.ToString());
            return result;
        }

            

    }



    
}