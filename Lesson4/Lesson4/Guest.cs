namespace Lesson4
{
    internal class Guest
    {
        public string Name { get; }
        private Caffee _caffee;

        public Guest(string name, Caffee caffee)
        {
            Name = name;
            _caffee = caffee;
        }

        public void MakeOrder(string order)
        {
            _caffee.ServeOrder(order, this);
        }
    }
}
