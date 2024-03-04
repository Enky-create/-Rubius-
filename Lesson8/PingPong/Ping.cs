namespace PingPong
{
    internal class Ping
    {
        public Action AnswerAction;
        public void AnswerToPong()
        {
            var randomNumber = new Random().Next(1,4);
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("\nPing recieved Pong");
                    AnswerAction.Invoke();
                    break;
                case 2:
                    Console.WriteLine("\nPong missed! Ping win");
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
