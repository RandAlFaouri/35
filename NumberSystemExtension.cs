using Metigator.NumberSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metigator.NumberSystem
{
    public static class NumberSystemExtensions
    {
        public static void Guard(this string source, string allowedCharacters, NumberBase numberBase)
        {
            foreach (var ch in source)
            {
                if (!allowedCharacters.Contains(ch))

                    throw new InvalidOperationException($"'{source}' is Invalid {numberBase} format");
            }
            }
            public static string To<T>(this T source, NumberBase toBase) where T : Base
            {
#if DEBUG
            Console.WriteLine("This message will appear in debug model only");
#endif   
            NumberBase fromBase;
                switch (source)

                {
                    case BinarySystem: fromBase = NumberBase.BINARY; break;
                    case OctalSystem: fromBase = NumberBase.OCTAL; break;
                    case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
                    case HexaDecimalSystem: fromBase = NumberBase.HEXADECIMAL; break;
                    default: fromBase = NumberBase.DECIMAL; break;

                }
                return Convert.ToString(Convert.ToInt32(source.Value, (int)fromBase), (int)toBase);

            }
        } 
    }

