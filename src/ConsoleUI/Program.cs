double radio = 5;
double altura = 10;
double pi= 3.1416;
double perimetro = Application.Circulo.Perimetro(pi, radio);
double area = Application.Circulo.Area(pi, radio);
double volumen = Application.Cilindro.Volumen(area, altura);

Console.WriteLine($"El Perímetro de la base de un cilindro con un radio de {radio}cm es de {perimetro}cm");
Console.WriteLine($"El Area de la base de un cilindro con un radio de {radio}cm es de {area}cm2");
Console.WriteLine($"El Volumen de un cilindro con un area de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");

