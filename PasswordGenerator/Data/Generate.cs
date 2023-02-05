namespace PasswordGenerator_UI.Data
{
    public class Generate
    {
        public string GenerateAndStorePassword(string path)
        {
            Random random = new Random();

            string lowerCaseLetters = "bcafafbiuwbfaifjbnowfhwnff";

            string upperCaseLetters = "ASYTFHBCOFMGHRUNDMVHDKMCVND";

            string symbols = "|!@#$%^&*@!#$^&*$%!^$*@#!#$*&$@|";

            int startIndex = random.Next(1, 12);

            int secondStartIndex = random.Next(5, 18);

            string generateRandomSymbol = symbols.Substring(startIndex, 1);

            string generateRandomSymbol2 = symbols.Substring(secondStartIndex, 1);

            string generateUpperLetter = upperCaseLetters.Substring(startIndex, 1);

            string generateUpperLetter2 = upperCaseLetters.Substring(secondStartIndex, 1);

            string generateLowerLetter = lowerCaseLetters.Substring(startIndex, 1);

            string generateLowerLetter2 = lowerCaseLetters.Substring(secondStartIndex, 1);

            int generateNum = random.Next(1, 10);

            int generateNum2 = random.Next(5, 10);

            string generatePassword = generateNum.ToString() + generateUpperLetter + generateRandomSymbol + generateLowerLetter
                  + generateUpperLetter2 + generateRandomSymbol2 + generateNum2.ToString() + generateLowerLetter2;

            DateTime localDate = DateTime.Now;

            File.AppendAllText(path, $"\nLast Password Generated: {generatePassword} (Password generated on: {localDate})");

            return generatePassword;

        }



    }
}
