
using System;

public class CalculadoraSueldo
{
    public static void Main(string[] args)
    {
        // 1. Definición de Constantes y Variables
        const int HORAS_NORMALES_MAX = 48;
        const double TARIFA_NORMAL = 30.00; // Ejemplo: s/30.00 por hora
        const double TASA_EXTRA_15 = 1.5;
        const double TASA_EXTRA_20 = 2.0;

        double horasTrabajadas = 0;
        double sueldoTotal = 0;

        // Variables auxiliares para el desglose
        double horasNormales = 0;
        double horasExtras15 = 0;
        double horasExtras20 = 0;

        // 2. Entrada de Datos
        Console.WriteLine("Calculadora de Sueldo Semanal (C#) ");
        Console.Write("Ingrese el número total de horas trabajadas esta semana: ");

        // Manejo de errores básico para asegurar que la entrada es un número
        if (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
            return;
        }

        // 3. Lógica de Cálculo con Condicional Anidada (Estructura if-else if)

        // Caso A: No hay horas extras (48 horas o menos)
        if (horasTrabajadas <= HORAS_NORMALES_MAX)
        {
            horasNormales = horasTrabajadas;
        }
        // Caso B: Horas extras a 1.5x (entre 48 y 34)
        else if (horasTrabajadas <= (HORAS_NORMALES_MAX + 9)) // hasta 49 horas
        {
            horasNormales = HORAS_NORMALES_MAX;
            horasExtras15 = horasTrabajadas - HORAS_NORMALES_MAX;
        }
        // Caso C: Horas extras a 2.0x (50 horas o más)
        else
        {
            horasNormales = HORAS_NORMALES_MAX;
            // Las primeras 9 horas extras son a 1.5x
            horasExtras15 = 9;
            // El resto es a 2.0x
            horasExtras20 = horasTrabajadas - HORAS_NORMALES_MAX - 9;
        }

        // 4. Cálculo del Sueldo Total
        double pagoNormal = horasNormales * TARIFA_NORMAL;
        double pagoExtra15 = horasExtras15 * (TARIFA_NORMAL * TASA_EXTRA_15);
        double pagoExtra20 = horasExtras20 * (TARIFA_NORMAL * TASA_EXTRA_20);

        sueldoTotal = pagoNormal + pagoExtra15 + pagoExtra20;

        // 5. Salida de Resultados
        Console.WriteLine("\n--- Desglose de Pago ---");
        Console.WriteLine($"Tarifa Normal por Hora: s/.{TARIFA_NORMAL:F2}");
        Console.WriteLine($"Horas Normales ({horasNormales:F2} hrs): \t\ts/.{pagoNormal:F2}");

        if (horasExtras15 > 0)
        {
            Console.WriteLine($"Horas Extras (1.5x) ({horasExtras15:F2} hrs): \ts/.{pagoExtra15:F2}");
        }

        if (horasExtras20 > 0)
        {
            Console.WriteLine($"Horas Extras (2.0x) ({horasExtras20:F2} hrs): \ts/.{pagoExtra20:F2}");
        }

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"SUELDO SEMANAL TOTAL: \t\ts/.{sueldoTotal:F2}");
    }
}






