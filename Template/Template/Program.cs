using System;

namespace Template
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //sätter ett värde så att man är säker på att enum inte bara kan läggas till utan också ändras
            EnumConfirmation enumConfirmation = EnumConfirmation.unconfirmed;
            //skapar klassen filetester
            FileTester f = new FileTester();
            //skriver "Du har startat spelet men har inte gått igenom enumtestet.s" i filen "testfile" genom att använda funktionen "WriteFile" så att man kan se att man kommit igenom det här steget
            f.WriteFile();
            //gör så att spelet körs när datorn läst filen den nyss skapat rätt och klarat nästa steg, så man vet att den kan läsa filer rätt genom att spela mitt spel
            if (f.ReadFile() == "Du har startat spelet men har inte gått igenom enumtestet.")
            {
                enumConfirmation = EnumConfirmation.confirmed;
            }
            //gör så att spelet körs när datorn visat att den kan ändra enum så att man ser om det är det steget den misslyckas med
            if (enumConfirmation == EnumConfirmation.confirmed)
            {
                using (var game = new Game1())
                    game.Run();
            }
        }
    }
#endif
}
