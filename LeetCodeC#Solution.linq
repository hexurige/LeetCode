<Query Kind="Program" />

void Main()
{
	Solution s = new Solution();
	
	s.ReverseString("Hello").Dump();
}

// 344. Reverse String 132ms
public class Solution {
    public string ReverseString(string s) {
        char[] array = s.ToCharArray();
        int len = array.Length;
        for(int i = 0; i < len/2; i++) {
            char temp = array[i];
            array[i] = array[len-1-i];
            array[len-1-i] = temp;
        }
        return new string(array);
    }
}