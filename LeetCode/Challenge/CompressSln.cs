using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    internal class CompressSln : ISolution
    {
        public int Compress(char[] chars)
        {
            int left = 0;
            int size = 0;

            // 由于最后一个字符也需要判断，所以将右指针终点放到数组之外一格
            for (int right = 0; right <= chars.Length; right++)
            {
                // 当遍历完成，或右指针元素不等于左指针元素时，更新数组
                if (right == chars.Length || chars[right] != chars[left])
                {
                    chars[size++] = chars[left]; // 更新字符
                    if (right - left > 1)
                    {
                        // 更新计数，当个数大于 1 时才更新
                        foreach (char c in (right - left).ToString())
                        {
                            chars[size++] = c;
                        }
                    }

                    left = right;
                }
            }

            return size;
        }

        public void Execute()
        {
            Compress(new[] {'a', 'a', 'b', 'b', 'c', 'c', 'c', 'd'});
        }
    }
}