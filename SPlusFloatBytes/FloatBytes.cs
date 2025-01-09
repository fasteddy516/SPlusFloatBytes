using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes

namespace SPlusFloatBytes
{
    public class FloatBytes
    {
        /// <summary>
        /// SIMPL+ can only execute the default constructor. 
        /// </summary>
        public FloatBytes()
        {
        }

        public static SimplSharpString GetBytes(ushort splusInput)
        {
            byte[] bytes = BitConverter.GetBytes((float)splusInput / 100);
            string floatBytes = Encoding.GetEncoding(28591).GetString(bytes, 0, bytes.Length);
            return new SimplSharpString(floatBytes, CrestronStringEncoding.eEncodingASCII);
        }
    }
}
