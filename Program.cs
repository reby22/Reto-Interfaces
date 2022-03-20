using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                              ARRAY-LIST                            ");
            Console.WriteLine("--------------------------------------------------------------------");
            mein(new ArrayList<string>(), new ArrayList<string>(), new ArrayList<string>());
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                              LINKED-LIST                           ");
            Console.WriteLine("--------------------------------------------------------------------");
            mein(new LinkedList<string>(), new LinkedList<string>(), new LinkedList<string>());
            
            
        }

        static void mein(List<string> team1, List<string> team2, List<string> team3)
        {
            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            Iterator<string> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Jesús
            // Salomón
            // Yael
            Console.WriteLine();
            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Cristian

            Console.WriteLine();
            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Rebeca
            // Salomón
            // Yael
            Console.WriteLine();
            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

            Console.WriteLine();
            team3.remove(0);
            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Tadeo
            // Isai

            if (team1.getAt(1).Equals("Salomón"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }
        }
    }
}
