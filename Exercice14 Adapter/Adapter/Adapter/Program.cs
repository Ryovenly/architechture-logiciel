// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");

Usbc usbc = new Usbc("UsbC",false,"test");
ITarget usba = new Usba(usbc);

Console.WriteLine(usba.GetRequest());

MicroSd microSd = new MicroSd("MicroSd", true, "test");
ITarget sd = new Sd(microSd);

Console.WriteLine(sd.GetRequest());

