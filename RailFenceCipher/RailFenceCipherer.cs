namespace RailFenceCipher
{
    public class RailFenceCipherer
    {
        public string Encode(string StringToEncode, int numberOfRails)
        {
           
            List<string[]> reuslt = CreateEmptyResultArray(StringToEncode, numberOfRails);
            FillResultArray(StringToEncode, numberOfRails, reuslt);
            return FormatResultArrayToString(reuslt);
        }

        private void  FillResultArray(string StringToEncode, int numberOfRails, List<string[]> reuslt)
        {
            int currentVericalPosition = 0;
            bool increment = true;
            for (int i = 0; i < StringToEncode.Length; i++)
            {
                reuslt[currentVericalPosition][i] = StringToEncode[i].ToString();
                if (currentVericalPosition <= numberOfRails && increment)
                {
                    currentVericalPosition++;
                }
                if (currentVericalPosition == numberOfRails)
                {
                    increment = false;
                }
                if (currentVericalPosition >= 0 && !increment)
                {
                    if (currentVericalPosition == numberOfRails)
                    {
                        currentVericalPosition--;
                    }
                    currentVericalPosition--;
                }
                if (currentVericalPosition == 0)
                {
                    increment = true;
                }
            }
        }

        private List<string[]> CreateEmptyResultArray(string StringToEncode, int numberOfRails)
        {
            List<string[]> reuslt = new List<string[]>();
            for (int i = 0; i < numberOfRails; i++)
            {
                string[] temp = new string[StringToEncode.Length];
                reuslt.Add(temp);
            }

            return reuslt;
        }

        private string FormatResultArrayToString(List<string[]> result)
        {
            string resultString = "";
            foreach (string[] strArray in result)
            {
                foreach(string str in strArray)
                {
                    if (str != null)
                    {
                        resultString += str;
                    }
                }
            }
            return resultString;
        }
    }
}
