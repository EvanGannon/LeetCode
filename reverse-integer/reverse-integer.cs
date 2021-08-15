public class Solution {
    public int Reverse(int x) {
          if (x == 0 || x > Int32.MaxValue)
                return 0;
            bool isNegative = x < 0;
            long result = 0;
            var nums = x.ToString().ToList();
            if (isNegative)
                nums.RemoveAt(0);
 
            nums.Reverse();
            result = long.Parse(string.Join(",", nums).Replace(",", ""));
            if (result > Int32.MaxValue)
                return 0;
            if (isNegative)
                result = result - result - result;
            return (int)result;
    }
}