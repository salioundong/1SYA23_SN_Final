using DndTool.Class;
using DndTool.Factory;

//-- Initialise les données génériques
GFactory gFactory = new GFactory();
String command = "";

//-- Boucle générale du programe : sortie = commande spécifique "exit"
while (command != "exit")
{
    String input = Console.ReadLine();
    command = gFactory.RequestCommand(input);

}
