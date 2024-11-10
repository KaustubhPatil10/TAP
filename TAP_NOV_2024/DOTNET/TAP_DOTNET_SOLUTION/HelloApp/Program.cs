


// Main EntryPoint Function
using HelloApp;

int count = 56;
count++;
bool status = false;
string company = "Transflower";
DateTime datetime = DateTime.Now;
Person prn  = new Person();
Person prn2 = new Person("Aditya", "Kharade", 27);


prn.show();
prn2.show();

// WriteLine is a static method of ready made class Console.
Console.WriteLine(company);
Console.WriteLine(count);
Console.WriteLine(datetime);
Console.WriteLine(status);
Console.WriteLine("Hello, World!");
