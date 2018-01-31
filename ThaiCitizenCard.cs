using System;

namespace ThaiCitizenCard
{
    public class ThaiCitizenCard
    {
        internal bool CheckPattern(string inputCitizenCard)
        {
            if(inputCitizenCard.Length == 13) {
                char[] citizenCard = inputCitizenCard.ToCharArray();
                for(int inputChar = 0; inputChar < citizenCard.Length; inputChar++) {
                    if(Char.IsNumber(citizenCard[inputChar]) == false) {
                        return false;
                    }
                }

                if(citizenCard[0] == '0' || citizenCard[0] == '9') {
                    return false;
                }

                return true;

            }
            return false;
        }
    }
}
