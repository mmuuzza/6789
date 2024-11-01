namespace ConsoleApp13.NewDirectory1;

public class QuestionService
{
    
        private static List<Question> Questions { get; set; } = new List<Question>();

        public static int AddQuestion(Question question)
        {
            Questions.Add(question);
            return question.Id;
        }

       

        public static Question? GetQuestionsById(int questionId)
        {
            foreach (Question question in Questions)
            {
                if (question.Id == questionId)
                    return question;
            }
            return null;
        }

        public static List<Question> GetAllQuestions()
        {
            return Questions;
        }



    }
