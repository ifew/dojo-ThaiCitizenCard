using System;
using System.Diagnostics;

namespace ThaiCitizenCard
{
    public class ThaiCitizenCard
    {
        internal bool CheckPattern(string inputCitizenCard)
        {
            if(inputCitizenCard.Length == 13) {
                char[] citizenCard = inputCitizenCard.ToCharArray();

                if(citizenCard[0] == '0' || citizenCard[0] == '9') {
                    return false;
                }

                for(int inputChar = 0; inputChar < 13; inputChar++) {
                    if(Char.IsNumber(citizenCard[inputChar]) == false) {
                        return false;
                    }
                }

                if(inputCitizenCard == GetCitizenCardNumber(inputCitizenCard)) {
                    return true;
                }
            }

            return false;
        }

        public string GetCitizenCardNumber(string inputCitizenCard) {
            char[] citizenCard = inputCitizenCard.ToCharArray();
            double sumPosition = 0;
            string expectedCitizenNumber = "";

            for(int inputChar = 0; inputChar < 12; inputChar++) {
                sumPosition += int.Parse(citizenCard[inputChar].ToString()) * (13-inputChar);
            }

            double sumMod = Math.Round(sumPosition % 11, 0);
            string lastDigit = (11-sumMod).ToString();

            if(lastDigit.Length == 2) {
                lastDigit =lastDigit.Substring(1,1);
            }

            expectedCitizenNumber = inputCitizenCard.Substring(0,12) + lastDigit;

            return expectedCitizenNumber;
        }
    }
}
