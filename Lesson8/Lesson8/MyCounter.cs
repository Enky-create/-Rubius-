namespace Counter
{
    internal class MyCounter
    {
        const int SEARCH_NUMBER = 77;
        public Action NumberFoundAction;
        public void Start()
        {
            for (int i = 0; i < 100; i++) 
            {
                if (i == SEARCH_NUMBER)
                {
                    NumberFoundAction.Invoke();
                }
            }
        }
    }
}
