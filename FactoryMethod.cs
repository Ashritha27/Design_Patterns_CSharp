using System;

namespace DesignPatterns
{
    public interface Interviewer
    {
        public void askQuestions();
    }

    public class Developer : Interviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking DP questions!!!");
        }
    }

    public class QALead : Interviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking QA questions!!");
        }
    }

    abstract public class HiringManager
    {
        abstract protected Interviewer ChooseInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.ChooseInterviewer();
            interviewer.askQuestions();
        }
    }

    public class DevelopmentManager : HiringManager
    {
        protected override Interviewer ChooseInterviewer()
        {
            return new Developer();
        }
    }

    public class QAManager : HiringManager
    {
        protected override Interviewer ChooseInterviewer()
        {
            return new QALead();
        }
    }
    class FactoryMethod
    {
        static void Main(string[] args)
        {
            var devInterview = new DevelopmentManager();
            devInterview.TakeInterview();

            var QAInterview = new QAManager();
            QAInterview.TakeInterview();

        }
    }
}
