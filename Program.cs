using System;
using System.Collections.Generic;

namespace QuizTimeStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Question
    {
        //have a list of questions and answers for each
        private static List<Dictionary<string, string>> QuizTime = new List<Dictionary<string, string>>();
        
        static 
        static void AskQuestion(List<Dictionary<string, string>>)
        {
            foreach (Dictionary<string, string> quiz in QuizTime)
            {
                foreach (KeyValuePair<string, string> line in quiz)
                {
                    string question = line.Key;

                    Console.WriteLine(question);

                }

            }
        }
    }
}

