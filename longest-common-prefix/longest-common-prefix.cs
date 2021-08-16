public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            string result = "";
            strs.ToList();
            if (strs.Length == 1)
                return strs[0];
            for(var index = 0; index <= strs[0].Length - 1; index++)
            {
                var c = strs[0].ToCharArray()[index];
                bool isEqual = true;

                for (var strsIndex = 1; strsIndex <= strs.Length - 1; strsIndex++)
                {
                if(strs[strsIndex].Length-1 < index || strs[strsIndex].ToCharArray()[index] != c)
                    {
                        isEqual = false;
                        break;
                    }

                }
                if (isEqual)
                    result += c;
                else
                    break;
            }
            return result;
    }
}