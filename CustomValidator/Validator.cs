using System.Text.RegularExpressions;

namespace CustomValidator;

public static class Validator
{
    public static bool ValidateUserName(string username) =>
        !string.IsNullOrWhiteSpace(username) && username.Length >= 2;

    public static bool ValidateName(string name) =>
        !string.IsNullOrWhiteSpace(name) && name.Length >= 2;

    public static bool ValidateSurname(string surname) =>
        !string.IsNullOrWhiteSpace(surname) && surname.Length >= 2;

    public static bool ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        bool hasUpper = Regex.IsMatch(password, "[A-Z]");
        bool hasLower = Regex.IsMatch(password, "[a-z]");
        bool hasDigit = Regex.IsMatch(password, "[0-9]");
        bool hasSymbol = Regex.IsMatch(password, @"[\W_]");

        return hasUpper && hasLower && hasDigit && hasSymbol;
    }

    public static bool ValidateAge(int age) => age > 0;

    public static bool ValidateBirthday(DateTime birthday) => birthday.Year >= 1970;
}
