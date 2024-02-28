namespace PingPong
{
    internal class Pong
    {
        public Action AnswerAction;
        public void AnswerToPing()
        {
            var randomNumber = new Random().Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("\nPong recieved Ping");
                    AnswerAction.Invoke();
                    break;
                case 2:
                    Console.WriteLine("\nPing missed! Pong win");
                    break;
                case 3:
                    Console.WriteLine("\nPing recieved Pong");
                    AnswerAction.Invoke();
                    break;
            }
        }
        public void Start()
        {
            AnswerAction.Invoke();
        }
    }
}
