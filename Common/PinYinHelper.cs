using System;
using System.Globalization;
using System.Text;
using NPinyin;

namespace Common
{
    public class PinYinHelper
    {
        public static string GetPinyin(string input)
        {
            return Pinyin.GetPinyin(input);
        }
        public static string GetPinYinInitials(string input)
        {
            return Pinyin.GetInitials(input);
        }
        
    }
}