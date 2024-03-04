using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class HangmanWord
    {
        public static List<String> getWords() {
            var r = new List<String>();
            var result = new List<String>();
            string path = "words.txt";
            string readText = File.ReadAllText(path);
            r = readText.Split(',').ToList();
            foreach(var d in r) {
                result.Add(d.Trim());
            }
            return result;
        }
    }
}
