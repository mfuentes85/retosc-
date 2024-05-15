
float IMC;

    Console.WriteLine("Introduzca su peso en kilogramos");
       float pesokg= float.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca su altura en metros");
        float alturam= float.Parse(Console.ReadLine());



IMC= pesokg / (alturam*alturam);

    Console.WriteLine("Tu IMC es:" +IMC ,"kg/m2");

if(IMC < 18.5){
    Console.WriteLine("Tu índice de masa corporal se encuentra por debajo del peso ideal");
}
else{
    if (IMC>= 18.5 && IMC<25){
       Console.WriteLine("Tu índice de masa corporal se encuentra dentro de los valores de tu peso ideal"); 
    }
    else {
         if (IMC>=25 && IMC<30){
       Console.WriteLine("De acuerdo con tu índice de masa corporal, actualmente tienes sobrepeso"); 
    }
        else {
             if (IMC>=30 && IMC<35){
       Console.WriteLine("De acuerdo con tu índice de masa corporal, actualmente tienes obesidad"); 
    }
        }

    }
}