<Query Kind="Program" />

void Main()
{
	Solution s = new Solution();
	
	string test1 = "(1+(4+5+2)-3)+(6+8)";
	string test2 = "1 + 1";
	s.Calculate(test1).Dump();
	s.Calculate(test2).Dump();
}

public class Solution {
    public int Calculate(string s) {
		string postfix = PostFix(s); 
        return PostFixEval(postfix);
    }
	
	public string PostFix(string s) {
		Stack<Char> OperatorStack = new Stack<Char>();          
        string postfix = "";
		string number = "";
        
        for (int i = 0; i < s.Length; i++)
        {
		
			
            char c = s[i];
					
			if (c >= '0' && c <= '9') number += c;
			
			else {
				postfix += " "+ number+ " ";
				number = "";
			}
				
				
			if (c == '(') OperatorStack.Push(c);
			
			if (c == ')') {
                while(OperatorStack.Count > 0) {
                    var op = OperatorStack.Pop();
                    if (op == '(')
						break;
					postfix += op;
                }   
            }
            
            if (c == '+' || c == '-') {
				if (OperatorStack.Count > 0)
				{
					var op = OperatorStack.Pop();
					if (op == '+' || op == '-')
						postfix += op;
				}
				OperatorStack.Push(c);
			}
			
			
        }
        if(number.Length > 0) postfix += " "+ number+ " ";
		if(OperatorStack.Count > 0) postfix += OperatorStack.Pop();
		
		return postfix;
	}
	
	public int PostFixEval(string s)
	{
		Console.WriteLine(s);
		Stack<int> stack = new Stack<int>();    
	
		for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
			
			if (c >= '0' && c <= '9') stack.Push(Int32.Parse(c.ToString()));
			
			if (c == '+' || c == '-' && stack.Count >= 2 ) {
				var op2 = stack.Pop();
				var op1 = stack.Pop();
				var temp = 0;				
				if (c == '+') temp = op1+op2;
				if (c == '-') temp = op1-op2;
				
				stack.Push(temp);
			}
		}
	
		return stack.Pop();
	}
}