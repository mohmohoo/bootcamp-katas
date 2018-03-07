using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Class1
    {
        public static bool IsPalindrome(string value)
        {
            // If the input is empty it is not a palindrome
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            
            // If the string has a length of 1 character it is a palindrome
            if (value.Length == 1)
            {
                return true;
            }


            var rgx = new Regex("[^a-zA-Z0-9]");
            value = rgx.Replace(value, "").ToUpper();

            var stack = new Stack<char>();
            var len = value.Length;
            if (value.Length % 2 == 1)
            {
                var index = ((len + 1) / 2) - 1;
                value = value.Remove(index, 1);
            }

            len = value.Length;
            
            for (var i = 0; i < len; i++)
            {
                var charVal = value[i];
                if (stack.TryPeek(out char tempChar))
                {
                    if (tempChar.Equals(charVal))
                    {
                        stack.Pop();
                        continue;
                    }

                    stack.Push(charVal);
                    continue;
                }

                stack.Push(charVal);
            }

            return stack.Count == 0;
        }
    }
}
