using PingPong;

var ping = new Ping();
var pong = new Pong();
ping.AnswerAction += pong.AnswerToPing;
pong.AnswerAction += ping.AnswerToPong;
ping.Start();
Console.ReadLine();