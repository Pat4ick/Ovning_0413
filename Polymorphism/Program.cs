using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var errors = new List<UserError>()
            {
                new TextInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NullInputError(),
                new SlowResponseError(),
                new WrongChoiseError(),

                // 11. F: Varför är polymorfism viktigt att behärska?
                // Det är ett flexibelt sätt att utöka en klass. Vitruella metoder kan överladdas (override) och få annat beteende. 


                // 12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?  
                // Genom att polymorfism kan man skapa en mer flexibel klasstruktur då arbetsuppgifterna kan fördelas mer logiskt mellan klasserna
                // Man kan få olika beteende med "samma" metoder.
                
                // 13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
                // Ett interface är lite som en abstrakt klass där alla medlemmar är abstrakta och
                // där det dessutom är krav på att alla metoder och fält ska konkretiseras i den implementerade klassen.
                // Man kan implementera fler interface, men bara en abstrakt klass. En abstrakt klass kan innehålla konstruktorer.



            };

            foreach(UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }



        }
    }
}
