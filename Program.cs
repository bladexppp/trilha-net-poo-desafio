using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"35894562", modelo:"Modelo 1", imei:"12356",memoria:60);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"35894562", modelo:"Modelo 1", imei:"12356",memoria:60);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");