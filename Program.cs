using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "999999", modelo: "Modelo 1", imei: "33990", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("/n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "999999", modelo: "Modelo 1", imei: "33990", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

