# SignalR
## WebSocket
 Tek bir TCP üzerinden client ile server arasında iki yönlü iletişimi sağlayan protokoldür.<br>
 Client lara mesajları hub dışarısından da göndermek için IHubContext ini controller içerisinde dependency injection  olarak gecersek istediğimiz yerden mesaj gönderebiliriz.<br>
Hub.Client.All metodu tüm client lar için çalışır.<br>
Hub.Clients.Caller metodu hangi client istek yapmışsa sadece onu çalıştırır.<br>
Strongly Type-->Bir dilin sizin objenizi bilmesi demektir.<br>
<strong>await Clients.All.SendAsync("ReceiveProduct",p);</strong> <br>
Mvc projesi içerisinde hub kurduğunuz zaman bu huba bağlanmak istediğinizde cors ayarı yapmanıza gerek yok. Direkt olarak huba bağlanabilirsiniz.
