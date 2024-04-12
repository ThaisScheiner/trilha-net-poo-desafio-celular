using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"modelo A", imei:"1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"567890", modelo:"modelo X", imei:"222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");