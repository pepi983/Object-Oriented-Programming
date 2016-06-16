namespace ExtensionMethodsDelegatesLambda.Timer
{
    using System;
    using System.Threading;
    public delegate void DoSomething(string param);

    public class Timer
    {
        public DoSomething Deleg { get; set; }

        public Timer(string foodToEat, int executePerMiliseconds, int stopAfterMiliseconds)
        {
            this.Deleg += Eat;
            this.Deleg += Vomit;
            StartTimer(foodToEat, executePerMiliseconds, stopAfterMiliseconds);
        }

        public static void Eat(string food)
        {
            Console.WriteLine("I Eated {0}", food);
        }

        public static void Vomit(string food)
        {
            Console.WriteLine("I Vomited {0}", food);
        }

        private void StartTimer(string food, int executePerMiliseconds, int endAfter)
        {
            int timeDelegExecuted = 0;
            while (true)
            {
                Console.WriteLine("The delegate executed {0} times", timeDelegExecuted);
                Deleg(food);
                Thread.Sleep(executePerMiliseconds);
                endAfter -= executePerMiliseconds;
                if (endAfter < 0)
                {
                    break;
                }
                timeDelegExecuted++;
            }
        }
    }
}
