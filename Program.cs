using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia(numero :"(71)99998-9999", modelo: "Nokia G60", imei: "123456", memoria: 128);
nokia.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"Meu número é {nokia.Numero} \n \n \n");

Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone(numero: "(71)9999-7777", modelo: "iPhone 15 Pro Max", imei: "12345678", memoria: 256);
iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine($"Meu número é {iphone.Numero}");