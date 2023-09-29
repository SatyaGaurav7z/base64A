
// Task 3 - Hexadecimal Converter class to convert Full Name to hexadecimal and back to its original string
namespace Assignment__1_DataSecurity_Encoding.Models
{
    internal class HexadecimalConverter
    {

        public string StringToHexadecimal(string name)
        {
            string hexadecimalData = "";
            foreach (char c in name)
            {
                int asciival = (int)c;
                string result = "";

                while (asciival != 0)
                {
                    if ((asciival % 16) < 10)
                        result = asciival % 16 + result;
                    else
                    {
                        string temp = "";
                        switch (asciival % 16)
                        {
                            case 10: temp = "A"; break;
                            case 11: temp = "B"; break;
                            case 12: temp = "C"; break;
                            case 13: temp = "D"; break;
                            case 14: temp = "E"; break;
                            case 15: temp = "F"; break;

                        }
                        result = temp + result;
                    }
                    asciival = asciival / 16;
                }
                hexadecimalData = hexadecimalData + result;
                Console.WriteLine("\nASCII for  {0} = {1} Hexadecimal = {2}", c, (int)c, result);// print result
            }
            Console.WriteLine($"\n{name} = HexadecimalConverter =  {hexadecimalData}");
            return hexadecimalData;
        }
        public string HexadecimalToString(string hexadecimalData)
        {
            string result = "";

            for (int i = 0; i < hexadecimalData.Length; i = i + 2)

            {
                string first2_bits = hexadecimalData.Substring(i, 2);
                int number = Convert.ToInt32(first2_bits, 16);

                result = result + (char)number;
            }
            Console.WriteLine("hexadecimalData to String = " + result);
            return result;
        }
    
    }
}

