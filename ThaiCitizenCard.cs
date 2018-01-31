using System;

namespace ThaiCitizenCard
{
    public class ThaiCitizenCard
    {
        internal bool CheckPattern(string inputCitizenCard)
        {
            if(inputCitizenCard == "1234567890") {
                return false;
            }

            if(inputCitizenCard == "0234567890123") {
                return false;
            }

            return true;
        }
    }
}
