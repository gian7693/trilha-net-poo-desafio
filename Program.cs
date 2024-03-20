using System;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "15991165528", modelo: "14 Pro Max", imei: "111111111", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "15991256847", modelo: "C01 Plus", imei: "222222222", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

