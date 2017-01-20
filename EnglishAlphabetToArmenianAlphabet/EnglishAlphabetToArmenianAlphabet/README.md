# English Alphabet To Armenian Alphabet
This Extension method allows you to convert latin letters into armenian letters.
# How to use
For this letter's: <br />
"e_"->"է" <br />
"@"->"ը" <br />
"th"->"թ" <br />
"jh"->"ժ" <br />
"kh"->"խ" <br />
"ts"->"ծ" <br />
"dz"->"ձ" <br />
"gh"->"ղ" <br />
"tch"->"ճ" <br />
"sh"->"շ" <br />
"vo"->"ո" <br />
"ch"->"չ" <br />
"ph"->"փ" <br />
"ev"->"և" <br />
```C#
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Write your Armenian text in English keyword\nfor է use e_\n");
string text = Console.ReadLine();
Console.WriteLine(text.ToArmenianAlphabet());
```
# Result
