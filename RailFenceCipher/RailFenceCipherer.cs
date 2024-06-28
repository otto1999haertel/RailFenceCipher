namespace RailFenceCipher
{
    public class RailFenceCipherer
    {
        public string Encode(string StringToEncode, int numberOfRails)
        {
            int currentVericalPosition=0;
            //Array kann zwei Demensional deterministisch von Anfang an vorbelegt werden
            //Jedes Array muss so groß sein, wie die länge des Strings

            List<string[]> reuslt = new List<string[]>();
            for(int i=0; i< numberOfRails; i++)
            {
                string[]temp = new string[StringToEncode.Length];
                reuslt.Add(temp);
            }
            //currentVericalPosition = stringToEncode[index]
            do
            {
                currentVericalPosition++;
            } while(currentVericalPosition<StringToEncode.Length);
            return "";
        }
    }
}
