int num1;
int num2;
int rsuma;
int rresta;
int rmult;
float rdiv;

    //Solicitud de valores al usuario
    Console.WriteLine("Introduzca el primer número");
        num1= int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca el segundo número");
        num2= int.Parse(Console.ReadLine());
    
    // Operaciones
    
    rsuma= num1+num2;
    rresta=num1-num2;
    rmult=num1*num2;
    rdiv=num1/num2;

    
    //Impresion de resultados
    Console.WriteLine("La suma de los números proporcionados es:"  +rsuma );
    Console.WriteLine("La resta de los números proporcionados es:" +rresta );
    Console.WriteLine("La multiplicación de los números proporcionados es:" +rmult );
    Console.WriteLine("La cociente de la división de los números proporcionados es:" +rdiv );