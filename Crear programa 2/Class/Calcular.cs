

namespace Crear_programa_2.Class
{
    public class Calcular
    {
        public void Calcualartarea() {
            try { 
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            


                Console.WriteLine("Incerte el primer numero:");
                num1= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Incerte el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("incerte el tercer numero:");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Incerte el cuarto numero:");
                num4 = Convert.ToInt32(Console.ReadLine());


               var suma = num1 + num2;
               var producto = num3 + num4 / 10;

                Console.WriteLine($"La suma de los dos primeros numero es: {suma}");
                Console.WriteLine($"El producto de los numero 3 y 4 es:{producto }");



            } catch (Exception ex) { Console.WriteLine($"Ocurrion un error en el calculo {ex}"); }
        
        }
    }
}
