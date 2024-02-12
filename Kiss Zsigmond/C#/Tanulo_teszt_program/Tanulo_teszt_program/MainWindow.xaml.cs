using System;
using System.Collections.Generic;
using System.Windows;

namespace QuizApp
{
    public partial class MainWindow : Window
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayCurrentQuestion();
        }

        private void InitializeQuestions()
        {
            questions = new List<Question>
            {
                new Question("Mi a fővárosa Magyarországnak?", "Budapest", "Prága", "Bécs"),
                new Question("Mi a legmagasabb hegycsúcs a világon?", "Mount Everest", "K2", "Kangchenjunga"),
                // Folytasd a kérdések hozzáadását
                // Például:
                // new Question("Melyik évben tört ki az első világháború?", "1914", "1918", "1939"),
                // new Question("Ki írta a 'Harry Potter' könyveket?", "J.K. Rowling", "Stephen King", "George R.R. Martin"),
            };
        }

        private void DisplayCurrentQuestion()
        {
            Question currentQuestion = questions[currentQuestionIndex];
            questionTextBlock.Text = currentQuestion.Text;
            option1RadioButton.Content = currentQuestion.Options[0];
            option2RadioButton.Content = currentQuestion.Options[1];
            option3RadioButton.Content = currentQuestion.Options[2];
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            if (option1RadioButton.IsChecked == true && option1RadioButton.Content.ToString() == currentQuestion.CorrectAnswer
                || option2RadioButton.IsChecked == true && option2RadioButton.Content.ToString() == currentQuestion.CorrectAnswer
                || option3RadioButton.IsChecked == true && option3RadioButton.Content.ToString() == currentQuestion.CorrectAnswer)
            {
                resultTextBlock.Text = "Helyes válasz!";
            }
            else
            {
                resultTextBlock.Text = "Rossz válasz. A helyes válasz: " + currentQuestion.CorrectAnswer;
            }

            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show("A teszt véget ért!");
                // Ide lehet tenni további műveleteket a teszt befejezése után
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, string correctAnswer, string option2, string option3)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            Options = new string[] { correctAnswer, option2, option3 };
            ShuffleOptions();
        }

        private void ShuffleOptions()
        {
            Random rng = new Random();
            int n = Options.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = Options[k];
                Options[k] = Options[n];
                Options[n] = value;
            }
        }
    }
}
