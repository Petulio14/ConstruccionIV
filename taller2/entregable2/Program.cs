using ENTREGABLE2;


Carro vec = new Carro("McLaren", "2");
Carro asd = new Carro("Ferraria", "2");
Carro qda = new Carro("Redbull", "2");
Circuito cir = new Circuito(6, "Nascar");

cir.AñadirCarro(vec);
var dict = cir.RealizarPrueba();
