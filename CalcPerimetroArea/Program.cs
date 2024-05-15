int perimetro;
int area;

Console.WriteLine ("Escriba el valor de la base del rectángulo");
    int brectang= int.Parse(Console.ReadLine ());

Console.WriteLine ("Escriba el valor de la altura del rectángulo");
    int hrectang= int.Parse(Console.ReadLine ());

perimetro= (2*brectang)+(2*hrectang);

Console.WriteLine ("El perímetro del rectangulo con las medidas proporcionadas es: " +perimetro +" cm");

area= brectang*hrectang;
Console.WriteLine ("El área del rectangulo con las medidas proporcionadas es: " +area + " cm2");

