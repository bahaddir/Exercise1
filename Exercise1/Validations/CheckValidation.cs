using Exercise1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Validations
{
    public static class CheckValidation
    {

        /// <summary>
        /// girilen stringin bos olup olmadigini kontrol eder
        /// </summary>
        /// <param name="value">girilen metin </param>
        /// <returns>girilen metin bos degilse girilen metni geri verir</returns>
        /// <exception cref="ValidationException"></exception>
        public static string CheckValue(string value)
        {
            if (!string.IsNullOrEmpty(value))
                return value;
            else
                throw new ValidationException("Giriş alanı boş geçilemez!");
        }
    

        /// <summary>
        /// girilen verinin uzunlugunu kontrol eder. verilen degerden azsa exception firlatir
        /// </summary>
        /// <param name="value"> girilen metin </param>
        /// <param name="minLength">metin uzunlugu alt siniri</param>
        /// <returns> girilen string alt sinirdan uzunsa girilen stringi geri verir </returns>
        /// <exception cref="ValidationException"></exception>
    public static string CheckLength(string value,int minLength)
        {
            if (value.Length >= minLength)
                return value;
            else
                throw new ValidationException($"icerik {minLength}den uzun olmak zorundadir");
        }
    }
}
