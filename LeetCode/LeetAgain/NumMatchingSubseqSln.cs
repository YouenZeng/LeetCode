using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class NumMatchingSubseqSln : ISolution
    {
        HashSet<string> setCache = new HashSet<string>();

        public int NumMatchingSubseq(string S, string[] words)
        {
            int count = 0;
            foreach (string word in words)
            {
                if (IsSubseq(S, word)) count++;
            }

            return count;
        }


        private bool IsSubseq(string S, string word)
        {

            if (setCache.Contains(word)) return true;
            int start = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (start == word.Length)
                {
                    setCache.Add(word);
                    return true;
                }
                if (S[i] == word[start])
                {
                    start++;
                }
            }

            if (start == word.Length)
            {
                setCache.Add(word);
            }
            return start == word.Length;
        }

        public void Execute()
        {
            NumMatchingSubseq("rwpddkvbnnuglnagtvamxkqtwhqgwbqgfbvgkwyuqkdwhzudsxvjubjgloeofnpjqlkdsqvruvabjrikfwronbrdyyjnakstqjac", new[] { "wpddkvbnn", "lnagtva", "kvbnnuglnagtvamxkqtwhqgwbqgfbvgkwyuqkdwhzudsxvju", "rwpddkvbnnugln", "gloeofnpjqlkdsqvruvabjrikfwronbrdyyj", "vbgeinupkvgmgxeaaiuiyojmoqkahwvbpwugdainxciedbdkos", "mspuhbykmmumtveoighlcgpcapzczomshiblnvhjzqjlfkpina", "rgmliajkiknongrofpugfgajedxicdhxinzjakwnifvxwlokip", "fhepktaipapyrbylskxddypwmuuxyoivcewzrdwwlrlhqwzikq", "qatithxifaaiwyszlkgoljzkkweqkjjzvymedvclfxwcezqebx" });
        }
    }
}
