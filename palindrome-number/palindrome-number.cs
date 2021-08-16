public class Solution {
    public bool IsPalindrome(int x) {
                    var arr = x.ToString().ToList();
            int end = arr.Count - 1;
            for(int start = 0; start < arr.Count-1; start++)
            {
                if (arr.ElementAt(start) != arr.ElementAt(end))
                    return false;
                end--;
            }
            return true;
    }
}