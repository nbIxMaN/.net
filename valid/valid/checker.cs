using System.Text.RegularExpressions;
using valid;

namespace DataValidator
{
    public static class Checker
    {
        public static DataEnum CheckData(string str)
        {
            return IsValidEmail(str)
                ? DataEnum.Email
                : IsRussianPostIndex(str)
                    ? DataEnum.RussianPostIndex
                    : IsUSAPostIndex(str)
                        ? DataEnum.USAPostIndex
                        : IsTelephonNumber(str) ? DataEnum.TelephonNumber : DataEnum.UnknownData;
        }
        private static bool IsValidEmail(string str)
            =>
                Regex.IsMatch(str,
                    @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                    RegexOptions.IgnoreCase);
        private static bool IsRussianPostIndex(string str)
            => Regex.IsMatch(str, @"\b[0-9]{6}\b");
        private static bool IsUSAPostIndex(string str)
            => Regex.IsMatch(str, @"^\d{5}(?:[-\s]\d{4})?$");
        private static bool IsTelephonNumber(string str)
            => Regex.IsMatch(str, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{3,10}$");
    }
}