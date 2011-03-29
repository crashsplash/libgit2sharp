/*
 * The MIT License
 *
 * Copyright (c) 2011 Andrius Bentkus
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;

namespace LibGit2Sharp.Core.Generator
{
    public static class HelperExtensions
    {
        public static string Join(this string[] stringArray, char c)
        {
            return stringArray.Join(new string(new char[] { c }));
        }
    
        public static string Join(this string[] stringArray, string delimeter)
        {
            return stringArray.Join(0, delimeter);
        }
    
        public static string Join(this string[] stringArray, int startIndex, char c)
        {
            return stringArray.Join(startIndex, new string(new char[] { c }));
        }
    
        public static string Join(this string[] stringArray, int startIndex, string delimeter)
        {
            if (stringArray.Length < startIndex)
                return string.Empty;
    
            System.Text.StringBuilder sb = new System.Text.StringBuilder(stringArray[startIndex]);
    
            for (int i = startIndex + 1; i < stringArray.Length; i++) {
                sb.Append(delimeter);
                sb.Append(stringArray[i]);
            }
    
            return sb.ToString();
        }
    }
}