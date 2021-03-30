namespace Empleados
{
    public class Bono
    {
        static public decimal calcBono(Empleado e)
        {
            
            decimal bono;
            calcBono(e.Antigüedad, e.Edad, out bono);
            return bono;

        }

        static public void calcBono(short antigüedad, short edad, out decimal bono)
        {
            bono = ((antigüedad - 2) * .02m);
            if (edad > 40) bono = bono +(( edad - 40 )*.02);

               
        }

    }
}
