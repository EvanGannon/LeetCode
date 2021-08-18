public class Solution {
    public int RomanToInt(string s) {
   //            Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

                //Symbol Value
                //I             1
                //V             5
                //X             10
                //L             50
                //C             100
                //D             500
                //M             1000
    //For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

    //Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII.Instead, the number four is written as IV.Because the one is before the five we subtract it making four.The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:


    //I can be placed before V(5) and X(10) to make 4 and 9.
    //X can be placed before L(50) and C(100) to make 40 and 90.
    //C can be placed before D(500) and M(1000) to make 400 and 900.

    //Given a roman numeral, convert it to an integer.

            //First, I chose to make a dictionary, with all roman numerals paired with their values as given by the problem
           Dictionary<char, int> dic =
    new Dictionary<char, int>();
           
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);

            //Next I make a total int to return
            int total = 0;

            //Convert the string to a char array, to iterate over
            s.ToCharArray();

            //Iterate over each char in the array. Added switch statement to account for special combos, i.e. 'IX = 9'
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (dic[c] != null)
                {
                    switch (c)
                    {
                        case 'I':
                            if (i <s.Length - 1 && s[i + 1] == 'V')
                            {
                                total += 4;
                                i++;
                            }
                            else if (i < s.Length - 1 && s[i + 1] == 'X')
                            {
                                total += 9;
                                i++;
                            }
                            else
                                total += dic[c];
                            break;
                        case 'X':
                            if (i < s.Length - 1 && s[i + 1] == 'L')
                            {
                                total += 40;
                                i++;
                            }
                            else if (i < s.Length - 1 && s[i + 1] == 'C')
                            {
                                total += 90;
                                i++;
                            }
                            else
                                total += dic[c];
                            break;
                        case 'C':
                            if (i < s.Length - 1 && s[i + 1] == 'D')
                            {
                                total += 400;
                                i++;
                            }
                            else if (i < s.Length - 1 && s[i + 1] == 'M')
                            {
                                total += 900;
                                i++;
                            }
                            else
                                total += dic[c];
                            break;

                        default:
                            total += dic[c];
                            break;
                    }
             
                }
            }

            //Return roman numeral as an int
            return total;
    }
}