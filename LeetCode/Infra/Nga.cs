using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Infra
{
    class Nga
    {
        NetSpell.SpellChecker.Spelling oSpell;

        public Nga()
        {
            oSpell = Go();
        }

        public NetSpell.SpellChecker.Spelling Go()
        {
            NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();

            oDict.DictionaryFile = "en-US.dic";
            oDict.Initialize();
            string wordToCheck = "door";

            var oSpell = new NetSpell.SpellChecker.Spelling();
            oSpell.Dictionary = oDict;
            return oSpell;
        }
        public void TryGenerate()
        {
            List<string> result = new List<string>();
            Dfs(0, string.Empty, result);
        }

        private void Dfs(int current, string currentString, List<string> result)
        {
            if (current == 3)
            {
                int temp = 0;
                foreach (var cItem in currentString)
                {
                    temp += cItem - 'a' + 1;
                }
                if (temp < 40)
                {
                    return;
                }
                if (oSpell.TestWord(currentString))
                {
                    result.Add(currentString);
                }
                return;
            }

            for (int i = 0; i < 26; i++)
            {
                currentString += (char)(0x41 + i);
                Dfs(current + 1, currentString, result);
                currentString = currentString.Substring(0, currentString.Length - 1);
            }
        }

    }
}
