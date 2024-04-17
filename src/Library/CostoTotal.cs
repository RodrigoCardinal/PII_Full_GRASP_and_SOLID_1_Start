using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class CostoTotal
    {
        public static double Calcular(Step step)
        {
            double Insumos = step.Input.UnitCost * (step.Quantity / 1000);
            double Tiempo = step.Time;
            Tiempo = Tiempo / 3600;
            double Equipamiento = step.Equipment.HourlyCost * Tiempo;
            double Subtotal = Insumos + Equipamiento;
            return Subtotal;
        }
    }
    
}

// Utilizo SRP para asignar la responsabilidad.