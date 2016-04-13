public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var array = s.ToCharArray();

        string temp = "";
        int longest = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (!temp.Contains(array[i]))
            {
                temp += array[i];
            }
            else
            {
                temp = temp.Substring(temp.IndexOf(array[i])+1) + array[i];
            }

            longest = Math.Max(temp.Length, longest);
        }

        return longest;
    }
}