using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone Nokia = new Nokia(numero: "922223333", modelo:"Nokia001",imei:"1023210",memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Meeting");
Nokia.ReceberLigacao();


Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero:"988884444", modelo:"2432", imei:"30423", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Ifood");
iphone.ReceberLigacao();