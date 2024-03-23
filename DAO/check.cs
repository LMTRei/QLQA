using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class check
    {
        private StringBuilder errorBuilder = new StringBuilder();
        private string TieuDe = "";
        private string rawString = "";
        public bool HasError => !string.IsNullOrWhiteSpace(errorBuilder.ToString());

        public check SetTieuDe(string customerTieuDe)
        {
            this.TieuDe = customerTieuDe;
            return this;
        }

        public check SetInputString(string inputString)
        {
            this.rawString = inputString;
            return this;
        }

        public string GetErrorMessage()
        {
            return errorBuilder.ToString();
        }

        public check SanLocInPut()
        {
            if (rawString.Length == 0)
                return this;
            else
            {
                string StringKetQua = rawString[0].ToString();
                foreach (var letter in rawString.ToCharArray())
                {
                    if (letter != ' ')
                        StringKetQua += letter.ToString();
                    else
                        if (StringKetQua.Length > 0 && StringKetQua[StringKetQua.Length - 1] != ' ')
                        StringKetQua += letter.ToString();
                }

                rawString = StringKetQua;

                return this;

            }
        }

        public check Require()
        {
            if (rawString.Length == 0)
                errorBuilder.AppendLine(TieuDe + " Chưa Nhập Kìa Má !!! ");
            return this;
        }

        public check MustBeValidString()
        {
            string invalidChar = "~!@#$%^&*()+`-=,./<>?;':[]{}\\|";
            foreach (var symbol in invalidChar.ToCharArray())
            {
                if (rawString.Contains(symbol.ToString()))
                {
                    errorBuilder.AppendLine(TieuDe + " không được chứa các ký tự không hợp lệ");
                    break;
                }
            }
            return this;
        }

        public check DoesNotContains(params char[] invalidLetters)
        {


            foreach (var symbol in invalidLetters)
            {
                if (rawString.Contains(symbol.ToString()))
                {
                    errorBuilder.AppendLine(TieuDe + " không được chứa các ký tự không hợp lệ: " + symbol.ToString());
                    break;
                }
            }
            return this;
        }

        public check DoesNotContains(params string[] phrases)
        {
            foreach (var phrase in phrases)
            {
                if (rawString.ToLower().Contains(phrase.ToLower()))
                {
                    errorBuilder.AppendLine(TieuDe + " không được chứa các cụm từ không hợp lệ: " + phrase);
                    break;
                }
            }

            return this;
        }

        public check HasLengthEqualOrGreaterThan(int min)
        {
            if (rawString.Length < min)
                errorBuilder.AppendLine(TieuDe + " phải ít nhất " + min + " kí tự nhé !!!");
            return this;
        }

        public check HasLengthGreaterThan(int min)
        {
            if (rawString.Length <= min)
                errorBuilder.AppendLine(TieuDe + " phải nhiều hơn " + min + " kí tự nhé !!!");
            return this;
        }

        public check HasLengthEqualOrLessThan(int max)
        {
            if (rawString.Length > max)
                errorBuilder.AppendLine(TieuDe + " phải ít hơn hoặc bằng " + max + " kí tự nhé !!!");
            return this;
        }

        public check HasLengthLessThan(int max)
        {
            if (rawString.Length >= max)
                errorBuilder.AppendLine(TieuDe + " phải ít hơn " + max + " kí tự nhé !!!");
            return this;
        }

        public check HasLengthEqualTo(int length)
        {
            if (rawString.Length != length)
                errorBuilder.AppendLine(TieuDe + " phải có đủ " + length + " kí tự nhé !!!");
            return this;
        }

        public check IsNumber()
        {
            bool isDouble = double.TryParse(rawString, out _);
            if (!isDouble)
                errorBuilder.AppendLine(TieuDe
                    + " phải là số nhé !!! ");
            return this;
        }
    }
}
