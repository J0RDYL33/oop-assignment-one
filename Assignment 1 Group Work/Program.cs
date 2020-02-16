using System;

namespace Assignment_1_Group_Work
{
    class Program
    {
        //Create variables that'll update as the program runs
        public static double total_population = 100.00;
        public static int total_states = 27;
        public static bool all_countries_participating = true;
        public static bool austria = true; public static bool belgium = true; public static bool bulgaria = true; public static bool croatia = true; public static bool cyprus = true;
        public static bool czech_republic = true; public static bool denmark = true; public static bool estonia = true; public static bool finland = true; public static bool germany = true;
        public static bool greece = true; public static bool hungary = true; public static bool ireland = true; public static bool italy = true; public static bool latvia = true;
        public static bool lithuania = true; public static bool luxembourg = true; public static bool malta = true; public static bool netherlands = true; public static bool poland = true;
        public static bool france = true; public static bool portugal = true; public static bool romania = true; public static bool slovakia = true; public static bool slovenia = true;
        public static bool spain = true; public static bool sweden = true;
        static void Main(string[] args)
        {
            //Call the function that lets the user choose if all countries are participating
            participating();

            passed_or_not();

            voting();
        }

        static void participating()
        {
            Console.WriteLine("Are all countries participating? (yes/no):");
            string participating_choice = Console.ReadLine();
            participating_choice.ToLower();
            if (participating_choice == "yes")
            {
                all_countries_participating = true;
            }
            else if (participating_choice == "no")
            {
                all_countries_participating = false;
            }
            else
            {
                participating();
            }
        }

        static void passed_or_not()
        {
            total_population = Math.Round(total_population, 2);
            Console.WriteLine($"Total population in favour: {total_population}%");
            Console.WriteLine($"Total states in favour: {total_states}");

            if (total_states >= 15 && total_population >= 65.00)
            {
                Console.WriteLine("The vote has passed");
            }
            else
            {
                Console.WriteLine("The vote failed to pass");
            }
        }

        static void continuing()
        {
            passed_or_not();
            Console.WriteLine("Would you like to keep changing votes? (yes/no):");
            string user_continue = Console.ReadLine();
            user_continue.ToLower();
            if (user_continue == "yes")
            {
                voting();
            }
            else if (user_continue == "no")
            {
                passed_or_not();
            }
            else
            {
                Console.WriteLine("Invalid response, try again");
                continuing();
            }
        }

        static void voting()
        {
            Console.WriteLine("Please enter a state to change the choice of:");
            string state_to_change = Console.ReadLine();
            state_to_change = state_to_change.ToLower();
            state_to_change = state_to_change.Replace(" ", String.Empty);
            Console.WriteLine(state_to_change);

            if (state_to_change == "austria")
            {
                change_austria();
            }
            else if (state_to_change == "belgium")
            {
                change_belgium();
            }
            else if (state_to_change == "bulgaria")
            {
                change_bulgaria();
            }
            else if (state_to_change == "croatia")
            {
                change_croatia();
            }
            else if (state_to_change == "cyprus")
            {
                change_cyprus();
            }
            else if (state_to_change == "czechrepublic")
            {
                change_czech_repuplic();
            }
            else if (state_to_change == "denmark")
            {
                change_denmark();
            }
            else if (state_to_change == "estonia")
            {
                change_estonia();
            }
            else if (state_to_change == "finland")
            {
                change_finland();
            }
            else if (state_to_change == "france")
            {
                change_france();
            }
            else if (state_to_change == "germany")
            {
                change_germany();
            }
            else if (state_to_change == "greece")
            {
                change_greece();
            }
            else if (state_to_change == "hungary")
            {
                change_hungary();
            }
            else if (state_to_change == "ireland")
            {
                change_ireland();
            }
            else if (state_to_change == "italy")
            {
                change_italy();
            }
            else if (state_to_change == "latvia")
            {
                change_latvia();
            }
            else if (state_to_change == "lithuania")
            {
                change_lithuania();
            }
            else if (state_to_change == "luxembourg")
            {
                change_luxembourg();
            }
            else if (state_to_change == "malta")
            {
                change_malta();
            }
            else if (state_to_change == "netherlands")
            {
                change_netherlands();
            }
            else if (state_to_change == "poland")
            {
                change_poland();
            }
            else if (state_to_change == "portugal")
            {
                change_portugal();
            }
            else if (state_to_change == "romania")
            {
                change_romania();
            }
            else if (state_to_change == "slovakia")
            {
                change_slovakia();
            }
            else if (state_to_change == "slovenia")
            {
                change_slovenia();
            }
            else if (state_to_change == "spain")
            {
                change_spain();
            }
            else if (state_to_change == "sweden")
            {
                change_sweden();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                voting();
            }
        }

        static void change_austria()
        {
            if (austria == true)
            {
                Console.WriteLine($"What are Austria voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    austria = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    austria = false;
                    total_states--;
                    total_population = total_population - 1.98;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (austria == false)
            {
                Console.WriteLine($"What are Austria voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    austria = true;
                    total_states++;
                    total_population = total_population + 1.98;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    austria = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_belgium()
        {
            if (belgium == true)
            {
                Console.WriteLine($"What are Belgium voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    belgium = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    belgium = false;
                    total_states--;
                    total_population = total_population - 2.56;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (belgium == false)
            {
                Console.WriteLine($"What are Belgium voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    belgium = true;
                    total_states++;
                    total_population = total_population + 2.56;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    belgium = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_bulgaria()
        {
            if (bulgaria == true)
            {
                Console.WriteLine($"What are Bulgaria voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    bulgaria = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    bulgaria = false;
                    total_states--;
                    total_population = total_population - 1.56;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (bulgaria == false)
            {
                Console.WriteLine($"What are Bulgaria voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    bulgaria = true;
                    total_states++;
                    total_population = total_population + 1.56;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    bulgaria = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_croatia()
        {
            if (croatia == true)
            {
                Console.WriteLine($"What are Croatia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    croatia = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    croatia = false;
                    total_states--;
                    total_population = total_population - 0.91;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (croatia == false)
            {
                Console.WriteLine($"What are Croatia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    croatia = true;
                    total_states++;
                    total_population = total_population + 0.91;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    croatia = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_cyprus()
        {
            if (cyprus == true)
            {
                Console.WriteLine($"What are Cyprus voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    cyprus = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    cyprus = false;
                    total_states--;
                    total_population = total_population - 0.20;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (cyprus == false)
            {
                Console.WriteLine($"What are Cyprus voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    cyprus = true;
                    total_states++;
                    total_population = total_population + 0.20;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    cyprus = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_czech_repuplic()
        {
            if (czech_republic == true)
            {
                Console.WriteLine($"What are Czech Republic voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    czech_republic = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    czech_republic = false;
                    total_states--;
                    total_population = total_population - 2.35;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (czech_republic == false)
            {
                Console.WriteLine($"What are Czech Republic voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    czech_republic = true;
                    total_states++;
                    total_population = total_population + 2.35;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    czech_republic = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_denmark()
        {
            if (denmark == true)
            {
                Console.WriteLine($"What are Denmark voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    denmark = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    denmark = false;
                    total_states--;
                    total_population = total_population - 1.30;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (denmark == false)
            {
                Console.WriteLine($"What are Denmark voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    denmark = true;
                    total_states++;
                    total_population = total_population + 1.30;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    denmark = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_estonia()
        {
            if (estonia == true)
            {
                Console.WriteLine($"What are Estonia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    estonia = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    estonia = false;
                    total_states--;
                    total_population = total_population - 0.30;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (estonia == false)
            {
                Console.WriteLine($"What are Estonia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    estonia = true;
                    total_states++;
                    total_population = total_population + 0.30;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    estonia = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_finland()
        {
            if (finland == true)
            {
                Console.WriteLine($"What are Finland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    finland = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    finland = false;
                    total_states--;
                    total_population = total_population - 1.23;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (finland == false)
            {
                Console.WriteLine($"What are Finland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    finland = true;
                    total_states++;
                    total_population = total_population + 1.23;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    finland = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_france()
        {
            if (france == true)
            {
                Console.WriteLine($"What are France voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    france = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    france = false;
                    total_states--;
                    total_population = total_population - 14.98;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (france == false)
            {
                Console.WriteLine($"What are France voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    france = true;
                    total_states++;
                    total_population = total_population + 14.98;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    france = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_germany()
        {
            if (germany == true)
            {
                Console.WriteLine($"What are Germany voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    germany = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    germany = false;
                    total_states--;
                    total_population = total_population - 18.54;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (germany == false)
            {
                Console.WriteLine($"What are Germany voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    germany = true;
                    total_states++;
                    total_population = total_population + 18.54;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    germany = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_greece()
        {
            if (greece == true)
            {
                Console.WriteLine($"What are Greece voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    greece = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    greece = false;
                    total_states--;
                    total_population = total_population - 2.40;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (greece == false)
            {
                Console.WriteLine($"What are Greece voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    greece = true;
                    total_states++;
                    total_population = total_population + 2.40;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    greece = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_hungary()
        {
            if (hungary == true)
            {
                Console.WriteLine($"What are Hungary voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    hungary = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    hungary = false;
                    total_states--;
                    total_population = total_population - 2.18;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (hungary == false)
            {
                Console.WriteLine($"What are Hungary voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    hungary = true;
                    total_states++;
                    total_population = total_population - 2.18;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    hungary = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_ireland()
        {
            if (ireland == true)
            {
                Console.WriteLine($"What are Ireland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    ireland = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    ireland = false;
                    total_states--;
                    total_population = total_population - 1.10;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (ireland == false)
            {
                Console.WriteLine($"What are Ireland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    ireland = true;
                    total_states++;
                    total_population = total_population - 1.10;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    ireland = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_italy()
        {
            if (italy == true)
            {
                Console.WriteLine($"What are Italy voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    italy = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    italy = false;
                    total_states--;
                    total_population = total_population - 13.65;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (italy == false)
            {
                Console.WriteLine($"What are Italy voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    italy = true;
                    total_states++;
                    total_population = total_population + 13.65;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    italy = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_latvia()
        {
            if (latvia == true)
            {
                Console.WriteLine($"What are Latvia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    latvia = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    latvia = false;
                    total_states--;
                    total_population = total_population - 0.43;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (latvia == false)
            {
                Console.WriteLine($"What are Latvia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    latvia = true;
                    total_states++;
                    total_population = total_population + 0.43;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    latvia = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_lithuania()
        {
            if (lithuania == true)
            {
                Console.WriteLine($"What are Lithuania voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    lithuania = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    lithuania = false;
                    total_states--;
                    total_population = total_population - 0.62;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (lithuania == false)
            {
                Console.WriteLine($"What are Lithuania voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    lithuania = true;
                    total_states++;
                    total_population = total_population + 0.62;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    lithuania = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_luxembourg()
        {
            if (luxembourg == true)
            {
                Console.WriteLine($"What are Luxembourg voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    luxembourg = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    luxembourg = false;
                    total_states--;
                    total_population = total_population - 0.14;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (luxembourg == false)
            {
                Console.WriteLine($"What are Luxembourg voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    luxembourg = true;
                    total_states++;
                    total_population = total_population + 0.14;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    luxembourg = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_malta()
        {
            if (malta == true)
            {
                Console.WriteLine($"What are Malta voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    malta = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    malta = false;
                    total_states--;
                    total_population = total_population - 0.11;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (malta == false)
            {
                Console.WriteLine($"What are Malta voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    malta = true;
                    total_states++;
                    total_population = total_population - 0.11;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    malta = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_netherlands()
        {
            if (netherlands == true)
            {
                Console.WriteLine($"What are Netherlands voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    netherlands = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    netherlands = false;
                    total_states--;
                    total_population = total_population - 3.89;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (netherlands == false)
            {
                Console.WriteLine($"What are Netherlands voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    netherlands = true;
                    total_states++;
                    total_population = total_population - 3.89;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    netherlands = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_poland()
        {
            if (poland == true)
            {
                Console.WriteLine($"What are Poland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    poland = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    poland = false;
                    total_states--;
                    total_population = total_population - 8.49;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (poland == false)
            {
                Console.WriteLine($"What are Poland voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    poland = true;
                    total_states++;
                    total_population = total_population + 8.49;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    poland = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_portugal()
        {
            if (portugal == true)
            {
                Console.WriteLine($"What are Portugal voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    portugal = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    portugal = false;
                    total_states--;
                    total_population = total_population - 2.30;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (portugal == false)
            {
                Console.WriteLine($"What are Portugal voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    portugal = true;
                    total_states++;
                    total_population = total_population + 2.30;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    portugal = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_romania()
        {
            if (romania == true)
            {
                Console.WriteLine($"What are Romania voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    romania = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    romania = false;
                    total_states--;
                    total_population = total_population - 4.34;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (romania == false)
            {
                Console.WriteLine($"What are Romania voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    romania = true;
                    total_states++;
                    total_population = total_population - 4.34;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    romania = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_slovakia()
        {
            if (romania == true)
            {
                Console.WriteLine($"What are Slovakia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    slovakia = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    slovakia = false;
                    total_states--;
                    total_population = total_population - 1.22;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (slovakia == false)
            {
                Console.WriteLine($"What are Slovakia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    slovakia = true;
                    total_states++;
                    total_population = total_population + 1.22;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    slovakia = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_slovenia()
        {
            if (slovenia == true)
            {
                Console.WriteLine($"What are Slovenia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    slovenia = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    slovenia = false;
                    total_states--;
                    total_population = total_population - 0.47;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (slovenia == false)
            {
                Console.WriteLine($"What are Slovenia voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    slovenia = true;
                    total_states++;
                    total_population = total_population - 0.47;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    slovenia = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_spain()
        {
            if (spain == true)
            {
                Console.WriteLine($"What are Spain voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    spain = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    spain = false;
                    total_states--;
                    total_population = total_population - 10.49;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (spain == false)
            {
                Console.WriteLine($"What are Spain voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    spain = true;
                    total_states++;
                    total_population = total_population + 10.49;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    spain = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }

        static void change_sweden()
        {
            if (sweden == true)
            {
                Console.WriteLine($"What are Sweden voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    sweden = true;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    sweden = false;
                    total_states--;
                    total_population = total_population - 2.29;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
            else if (sweden == false)
            {
                Console.WriteLine($"What are Sweden voting? (yes/no)");
                string the_vote = Console.ReadLine();
                if (the_vote == "yes")
                {
                    sweden = true;
                    total_states++;
                    total_population = total_population + 2.29;
                    continuing();
                }
                else if (the_vote == "no")
                {
                    sweden = false;
                    continuing();
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    voting();
                }
            }
        }
    }
}

