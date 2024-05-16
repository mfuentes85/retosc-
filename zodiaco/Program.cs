
Console.WriteLine("Introduzca su mes del nacimiento en 2 dígitos (ej. 01 enero, 02 feb ...)");
    int mnac= int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca su día del nacimiento en 2 dígitos (ej. 01, 02, 03, ...)");
    int dnac= int.Parse(Console.ReadLine());

if (mnac>=1 && mnac<=12 && dnac>=1 && dnac<=31 || mnac==02 && dnac>=1 && dnac<=29){
    //del 1 al 19 de enero: Capricornio
    if (mnac==01 && dnac<=19 || mnac==12 && dnac>=22 && dnac<=31){
      Console.WriteLine ("Tu signo zodiacal es Capricornio");
    }
    //del 20 ene al 18 feb: Acuario
        else{
            if (mnac==01 && dnac>=20 && dnac<=31 || mnac==02 && dnac<=18 ){
                Console.WriteLine ("Tu signo zodiacal es Acuario");
            } 
    //del 19 feb al 20 mar: Picis
        else{
            if (mnac==02 && dnac>18 && dnac<30 || mnac==03 && dnac<=18){
                Console.WriteLine ("Tu signo zodiacal es Picis");
            }
    //del 21 mar al 19 abr: Aries
        else{
            if (mnac==03 && dnac>20 && dnac<31 || mnac==04 && dnac<=19){
                Console.WriteLine ("Tu signo zodiacal es Aries");
             }
    //del 20 abr al 20 may: Tauro
        else{
            if (mnac==04 && dnac>=20 && dnac<30 || mnac==05 && dnac<=20){
                Console.WriteLine ("Tu signo zodiacal es Tauro");
            }
    //del 21 may al 20 jun: Geminis
        else{
            if (mnac==05 && dnac>=21 && dnac<31 || mnac==06 && dnac<=20){
                Console.WriteLine ("Tu signo zodiacal es Géminis");
            }
    //del 21 jun al 22 jul: Cancer
        else{
            if (mnac==06 && dnac<=21 && dnac<30||mnac==07 && dnac<=22){
                Console.WriteLine ("Tu signo zodiacal es Cáncer");
            }
    //del 23 jul al 22 ago: Leo
        else{
            if (mnac==07 && dnac>=23 && dnac<31 || mnac==08 && dnac<=22){
                Console.WriteLine ("Tu signo zodiacal es Leo");
            }   
    //del 23 ago al 22 sep: Virgo                            
        else{
        if (mnac==08 && dnac>=23 && dnac<31 || mnac==09 && dnac<=22){
            Console.WriteLine ("Tu signo zodiacal es Virgo");
        }
       
    //del 23 sep al 22 oct: Libra
        else{
            if (mnac==09 && dnac>=23 && dnac<30 || mnac==10 && dnac<=22){
            Console.WriteLine ("Tu signo zodiacal es Libra");
        }
    //del 23 oct al 21 nov: Escorpión
        else{
            if (mnac==10 && dnac>=23 && dnac<31 || mnac==11 && dnac<=21){
            Console.WriteLine ("Tu signo zodiacal es Escorpión");
        }
    //del 22 nov al 21 dic: Sagitario
        else{
            if (mnac==11 && dnac>=22 && dnac<31 || mnac==12 && dnac<=21){
            Console.WriteLine ("Tu signo zodiacal es Sagitario");
        }
        }
        }
        }
        }
        }
        }
        }
        } 
        }
        }
        } 
}
else{
    Console.WriteLine("Datos fuera de rango, favor de verificar las fechas");
}                    