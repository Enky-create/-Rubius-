using Counter;

var counter = new MyCounter();
var hadler1 = new Handler1();
var hadler2 = new Handler2();
counter.NumberFoundAction += hadler1.NumberFound;
counter.NumberFoundAction += hadler2.NumberFound;
counter.Start();
