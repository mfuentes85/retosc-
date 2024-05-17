float num1;
float num2;
float rsuma;
float rresta;
float rmult;
float rdiv;

    //Solicitud de valores al usuario
    Console.WriteLine("Introduzca el primer número");
        num1=float.Parse(Console.ReadLine());
        
    Console.WriteLine("Introduzca el segundo número");
        num2=float.Parse(Console.ReadLine());
    
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