// See https://aka.ms/new-console-template for more information
using Lesson4;

Caffee caffee = new Caffee();

Guest guest1 = new Guest("Иван", caffee);
Guest guest2 = new Guest("Анна", caffee);

caffee.AddGuest(guest1);
caffee.AddGuest(guest2);

guest1.MakeOrder("Кофе и пирожное");
guest2.MakeOrder("Чай и сэндвич");
