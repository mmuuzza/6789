namespace ConsoleApp13;

public class Asnwer
{
    
        public Answer(string answerText, bool isCorrect, int questionId) : base()
        {
            AnswerText = answerText;
            IsCorrect = isCorrect;
            QuestionId = questionId;
        }
        public string AnswerText { get; set; }
        public bool IsCorrect {  get; set; }  
        public int QuestionId {  get; set; }    
    }
