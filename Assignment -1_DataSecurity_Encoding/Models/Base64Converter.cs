// Task 4 - Convert full name into Base64
namespace Assignment__1_DataSecurity_Encoding.Models
{

    internal class Base64Converter
    {
    

        //Base 64 look up table

        private static readonly char[] Base64Letters = new[]


          { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'D', 'K', 'L', 'M',

            'N', '0', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'w', 'x', 'Y', 'Z',

            'a', 'b', 'c', 'd', 'e', 'f','g', 'h', 'i', 'j','k', '1', 'm',


            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z',

            '0', '1', '2', '3', '4', '5', '6', '7','8', '9', '+','/' };

        public string StringToBase64(string fullName)
        {

            string binaryString = "";

            //Get Binary data of Input string
            foreach (char c in fullName)

            {

                binaryString += Convert.ToString(c, 2).PadLeft(8, '0');


            }
            //check for padding
            string space_padding = "";
            if ((binaryString.Length % 3) != 0) //if not a multiple of 3s
            {

                int remainder = binaryString.Length % 3;
                //check for padding char : if reminder is 1 then 00 or if 2 then 000
                if (remainder == 1)
                {
                    binaryString += "00";
                    space_padding = "=";

                }

                if (remainder == 2)

                {



                    binaryString += "0000";
                    space_padding = "==";
                }

            }

            Console.WriteLine($"Binary of = {fullName} = {binaryString}");
            string base64 = string.Empty;

            //create groups of 6 bits


            for (int i = 0; i < binaryString.Length; i += 6) //read binary data
            {
                //divide binary data into groups of 6 bits
                string first6_bits = binaryString.Substring(i, 6);
                Console.Write(first6_bits);
                Console.Write("\t");

                int decimal_no = Convert.ToInt32(first6_bits, 2);
                Console.WriteLine(decimal_no);

                //get Base64 from look up table
                base64 += Base64Letters[decimal_no];
            }
            base64 += space_padding; //add space @ end of string
            Console.WriteLine();
            Console.Write($"base64 = {base64}");
            return binaryString;
        }
    }
}

