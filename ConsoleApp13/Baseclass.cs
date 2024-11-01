namespace ConsoleApp13;

public class Baseclass
{
    public  class BaseClass
    {
        private static int _idCounter = 0;

        public int Id { get; private set; }

        protected BaseClass() 
        {
            Id = +_idCounter++;
        }
    }
}