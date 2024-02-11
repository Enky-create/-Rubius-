namespace Lesson4
{
    internal class Caffee
    {
        private List<Guest> guests;

        public Caffee()
        {
            guests = new List<Guest>();
        }

        public void AddGuest(Guest guest)
        {
            guests.Add(guest);
        }

        public void ServeOrder(string order, Guest guest)
        {
            Console.WriteLine($"Кафе получило заказ \"{order}\" от гостя {guest.Name}");
        }
    }
}
