using System.Collections.ObjectModel;

public class Question
{
    public string Text { get; set; }
    public string[] Answers { get; set; }
    public int CorrectAnswerIndex { get; set; }
}

public class QuizViewModel
{
    public ObservableCollection<Question> Questions { get; set; }
    public Question CurrentQuestion { get; set; }

    private int currentQuestionIndex;
    public int SelectedAnswerIndex { get; set; }

    public QuizViewModel()
    {
        Questions = new ObservableCollection<Question>
        {
            new Question
            {
                Text = "What is 2 + 2?",
                Answers = new[] { "1", "2", "4", "5" },
                CorrectAnswerIndex = 2
            },
            new Question
            {
                Text = "What is the capital of France?",
                Answers = new[] { "Berlin", "Paris", "London", "Madrid" },
                CorrectAnswerIndex = 1
            },
            new Question
            {
                Text = "Which planet is closest to the sun?",
                Answers = new[] { "Earth", "Mars", "Mercury", "Venus" },
                CorrectAnswerIndex = 2
            },
            new Question
            {
                Text = "How many continents are there?",
                Answers = new[] { "5", "6", "7", "8" },
                CorrectAnswerIndex = 2
            },
            new Question
            {
                Text = "What is the largest ocean on Earth?",
                Answers = new[] { "Atlantic", "Indian", "Pacific", "Arctic" },
                CorrectAnswerIndex = 2
            }
        };

        currentQuestionIndex = 0;
        CurrentQuestion = Questions[currentQuestionIndex];
    }

    public void NextQuestion()
    {
        if (currentQuestionIndex < Questions.Count - 1)
        {
            currentQuestionIndex++;
            CurrentQuestion = Questions[currentQuestionIndex];
        }
    }

    public void PreviousQuestion()
    {
        if (currentQuestionIndex > 0)
        {
            currentQuestionIndex--;
            CurrentQuestion = Questions[currentQuestionIndex];
        }
    }

    public void ResetQuiz()
    {
        currentQuestionIndex = 0;
        CurrentQuestion = Questions[currentQuestionIndex];
    }

    public bool CheckAnswer()
    {
        return SelectedAnswerIndex == CurrentQuestion.CorrectAnswerIndex;
    }
}