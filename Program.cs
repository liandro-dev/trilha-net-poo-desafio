using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "001122334455667", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();
Iphone iphone = new Iphone("987654321", "iPhone 13", "998877665544332", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();
Console.WriteLine($"Nokia - Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
Console.WriteLine($"iPhone - Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();