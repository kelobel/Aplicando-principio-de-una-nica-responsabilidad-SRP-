using SRP.Models;
using SRP.Printers;
using SRP.Service;

namespace SRP
{
    
    class Program
    {
        static void Main()
        {
            
            Persona persona = new Persona("Kelobel Tapia", 21, "42 la Loma", "Kelobel@gmail.com");

            
            CorreoElectronicoService correoService = new CorreoElectronicoService();
            correoService.EnviarCorreoElectronico(persona.CorreoElectronico, "Hola Mundo : )");

            
            PersonaPrinter printer = new PersonaPrinter();
            printer.ImprimirDatos(persona);
        }
    }
}