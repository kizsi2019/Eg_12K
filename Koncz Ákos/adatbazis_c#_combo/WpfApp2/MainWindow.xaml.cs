using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OOPQuiz
{
    public partial class MainWindow : Window
    {
        private QuizQuestion _currentQuestion;
        private ObservableCollection<QuizQuestion> _questions;

        public MainWindow()
        {
            InitializeComponent();
            _questions = new ObservableCollection<QuizQuestion>
            {
                new QuizQuestion { Question = "What is encapsulation in OOP?", Answers = new ObservableCollection<string> {"Data hiding", "Inheritance", "Polymorphism", "Abstraction"}, CorrectAnswer = 0, Answer = "Encapsulation is the practice of keeping the fields within a class private, then providing access to them via public methods. It’s a protective barrier that keeps the data and code safe within the class itself." },
                new QuizQuestion { Question = "What is inheritance in OOP?", Answers = new ObservableCollection<string> {"Data hiding", "Inheritance", "Polymorphism", "Abstraction"}, CorrectAnswer = 1, Answer = "Inheritance is a process where you can derive a class from another class for a hierarchy of classes that share a set of attributes and methods." },
                // Add more questions here
            };

            DataContext = this;
            CurrentQuestion = _questions[0];
            QuestionTextBlock.DataContext = CurrentQuestion;
        }

        public QuizQuestion CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;
                Answers = new ObservableCollection<string>(_currentQuestion.Answers);
            }
        }

        public ObservableCollection<string> Answers { get; set; }

        public string Answer { get { return _currentQuestion.Answer; } }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ((ListBox)sender).SelectedItem as string;
            if (selectedItem != null)
            {
                var correctAnswerIndex = _currentQuestion.CorrectAnswer;
                var selectedAnswerIndex = _currentQuestion.Answers.IndexOf(selectedItem);
                if (correctAnswerIndex == selectedAnswerIndex)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Incorrect. The correct answer is: " + _currentQuestion.Answers[correctAnswerIndex]);
                }
                var textBlock = FindName("AnswerTextBlock") as TextBlock;
                if (textBlock != null)
                {
                    textBlock.Visibility = Visibility.Visible;
                }
                CurrentQuestion = _questions.FirstOrDefault(q => !q.IsAnswered);
                if (CurrentQuestion == null)
                {
                    MessageBox.Show("Quiz completed!");
                    CurrentQuestion = _questions[0];
                }
            }
        }
    }

    public class QuizQuestion
    {
        public string Question { get; set; }
        public ObservableCollection<string> Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public string Answer { get; set; }
        public bool IsAnswered { get; set; }
    }
}