using System;
using static System.Console;
using System.Collections;

/* 
In your own words, describe how linear probing resolves collision:

Linear probing resolves collisions by placing the key into the next available empty space if the target one is already occupied by another key. 
*/
class Program
    {
        static void Main()
        {
            Task9();
        }
        static void Task9()
        {
            var dict = GetDictionary();
            ProcessWords(dict);
        }
        static void ProcessWords(Dictionary<string,int> dict)
        {
            // print words and their frequencies
            foreach(var (k,v) in dict)
            {
                WriteLine($"{k} {v}");
            }
             // calculate and display the most words along with the frequency.
            int most = int.MinValue; //initialise the variable with the lowest possible value. In this case 0 is the lowest possible value.
            var mostWords = new List<string>(); //used to collect the most frequent words. There may be more than one word with the highest frequency
            foreach(var (k,v) in dict)
            {
                if(v > most) most = v;
            }
            foreach(var (k,v) in dict)
            {
                if(v == most) mostWords.Add(k); // add the most frequent word in the list.
            }
            //calculate and display the least words along with the frequency.
            int least = int.MaxValue;
            var leastWords = new List<string>();
            foreach(var (k,v) in dict)
            {
                if(v < least) least = v;
            }
            foreach(var (k,v) in dict)
            {
                if(v == least) leastWords.Add(k);
            }
            WriteLine("Most and least frequent words with frequency: ");
            mostWords.ForEach(w => Write(w + " ")); //print all words in one line with a space between each word.
            WriteLine(most);
            leastWords.ForEach(w => Write(w + " "));
            WriteLine(least);
        }
        static void FindLongShortWords(Dictionary<string,int> dict)
        {
            //complete function here
        }
        static Dictionary<string, int> GetDictionary(){
            string content = "data structures and algorithms is about data structures and algorithms. data structures is about data structures. algorithms is the about algorithms. there are good algorithms and not so good algorithms. good algorithms are good good, not so good ones are not so good.";
            //storing words
            //create dictionary variable called dict.
            var dict = new Dictionary<string, int>();
            //split the string using , or space and . = delilmiter
            char[] delimiterChars = {',', '.', ' '};
            string[] words = content.Split(delimiterChars);
            foreach(var wd in words){
                if(wd.Trim().Length == 0) continue;
                string w = wd.ToLower();
                if(dict.ContainsKey(w) == false)
                    dict.Add(w, 1); //insert w into hashtable, assign frequency as 1
                else
                    dict[w]++; //incremement the frequency
            }
            return dict;
        }
    }