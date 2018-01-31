using System;

namespace ThaiCitizenCard
{
    public class ThaiCitizenCard
    {
        internal bool CheckPattern(string inputCitizenCard)
        {
            if(inputCitizenCard.Length == 13) {
                char[] citizenCard = inputCitizenCard.ToCharArray();
                int sumPosition = 0;
                string expectedCitizenNumber = "";

                if(citizenCard[0] == '0' || citizenCard[0] == '9') {
                    return false;
                }

                for(int inputChar = 0; inputChar < 13; inputChar++) {
                    if(Char.IsNumber(citizenCard[inputChar]) == false) {
                        return false;
                    }
                    
                    sumPosition += citizenCard[inputChar] * (citizenCard.Length-inputChar);
                    expectedCitizenNumber = expectedCitizenNumber + citizenCard[inputChar];
                }

                string lastDigit = (11-(sumPosition % 11)).ToString().Remove(0);
                expectedCitizenNumber = expectedCitizenNumber + lastDigit;

                if(expectedCitizenNumber == inputCitizenCard) {
                    return true;
                }

            }

            return false;
        }
    }
}
