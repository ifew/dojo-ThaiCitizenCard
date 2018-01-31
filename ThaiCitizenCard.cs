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

            return true;
        }
    }
}
