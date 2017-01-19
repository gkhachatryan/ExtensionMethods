using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAlphabetToArmenianAlphabet
{
    public static class Translate
    {
        public static string ToArmenianAlphabet(this string value)
        {
            value = value.ToLower();
            Dictionary<string, string> alphabet = new Dictionary<string, string>();
            alphabet.Add("a", "ա");
            alphabet.Add("b", "բ");
            alphabet.Add("g", "գ");
            alphabet.Add("d", "դ");
            alphabet.Add("e", "ե");
            alphabet.Add("z", "զ");
            alphabet.Add("e_", "է");
            alphabet.Add("@", "ը");
            alphabet.Add("th", "թ");
            alphabet.Add("jh", "ժ");
            alphabet.Add("i", "ի");
            alphabet.Add("l", "լ");
            alphabet.Add("kh", "խ");
            alphabet.Add("ts", "ծ");
            alphabet.Add("k", "կ");
            alphabet.Add("h", "հ");
            alphabet.Add("dz", "ձ");
            alphabet.Add("gh", "ղ");
            alphabet.Add("tch", "ճ");
            alphabet.Add("m", "մ");
            alphabet.Add("y", "յ");
            alphabet.Add("n", "ն");
            alphabet.Add("sh", "շ");
            alphabet.Add("vo", "ո");
            alphabet.Add("ch", "չ");
            alphabet.Add("p", "պ");
            alphabet.Add("j", "ջ");
            alphabet.Add("s", "ս");
            alphabet.Add("v", "վ");
            alphabet.Add("t", "տ");
            alphabet.Add("r", "ր");
            alphabet.Add("c", "ց");
            alphabet.Add("u", "ու");
            alphabet.Add("ph", "փ");
            alphabet.Add("q", "ք");
            alphabet.Add("ev", "և");
            alphabet.Add("o", "օ");
            alphabet.Add("f", "ֆ");
            alphabet.Add(" ", " ");
            alphabet.Add(":", ":");
            alphabet.Add(",", ",");
            alphabet.Add("!", "!");
            alphabet.Add("?", "?");
            alphabet.Add("-", "-");

            string text = string.Empty;
            int count = 0;

            while (count < value.Length)
            {
                if (value[count] == 't' && value[count + 1] == 's')
                {
                    text += alphabet["ts"];
                    count += 2;
                    continue;
                }
                if (value[count] == 'd' && value[count + 1] == 'z')
                {
                    text += alphabet["dz"];
                    count += 2;
                    continue;
                }
                if (value[count] == 'g' && value[count + 1] == 'h')
                {
                    text += alphabet["gh"];
                    count += 2;
                    continue;
                }
                if (value[count] == 't' && value[count + 1] == 'h')
                {
                    text += alphabet["th"];
                    count += 2;
                    continue;
                }
                if (value[count] == 's' && value[count + 1] == 'h')
                {
                    text += alphabet["sh"];
                    count += 2;
                    continue;
                }
                if (value[count] == 'c' && value[count + 1] == 'h')
                {
                    text += alphabet["ch"];
                    count += 2;
                    continue;
                }
                if (value[count] == 'p' && value[count + 1] == 'h')
                {
                    text += alphabet["ph"];
                    count += 2;
                    continue;
                }
                if (value[count] == 'e' && value[count + 1] == 'v')
                {
                    text += alphabet["ev"];
                    count += 2;
                    continue;

                }
                if (value[count] == 'v' && value[count + 1] == 'o')
                {
                    text += alphabet["vo"];
                    count += 2;
                    continue;

                }
                if (value[count] == 'j' && value[count + 1] == 'h')
                {
                    text += alphabet["jh"];
                    count += 2;
                    continue;

                }
                if (value[count] == 'e' && value[count + 1] == '_')
                {
                    text += alphabet["e_"];
                    count += 2;
                    continue;

                }
                if (value[count] == 't' && value[count + 1] == 'c' && value[count + 2] == 'h')
                {
                    text += alphabet["tch"];
                    count += 3;
                    continue;
                }

                text += alphabet[value[count].ToString()];
                count++;
            }
            return text;
        }
    }
}
