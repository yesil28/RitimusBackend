﻿using System;

namespace quiz_app
{
    class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }

    }

    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        public Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"soru {this.QuestionIndex + 1}: {question.Text}");
         
            foreach (var c in question.Choices)
            {
                Console.WriteLine($"{c}");
            }
            Console.Write("Cevabunuz nerdir: ");
            var cevap = Console.ReadLine();
            this.Guess(cevap);
        }

        private void Guess(string answer)
        {
            var question = this.GetQuestion();

            if (question.checkAnswer(answer))
                this.Score++;
            this.QuestionIndex++;

            if (this.Questions.Length == this.QuestionIndex)
            {
                this.DisplayScore();
            }
            else
            {
                this.DisplayQuestion();

            }

        }

        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;

            if (totalQuestion>=questionNumber)
            {
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {


            var q1 = new Question("En iyi prgoramlama dili nedir", new string[] { "c#", "python", "java", "c++" }, "c#");
            var q2 = new Question("En populer prgoramlama dili nedir", new string[] { "c#", "python", "java", "c++" }, "c#");
            var q3 = new Question("En cok kazandıran prgoramlama dili nedir", new string[] { "c#", "python", "java", "c++" }, "c#");


            var questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);

            quiz.DisplayQuestion();




            Console.ReadLine();
        }
    }
}
