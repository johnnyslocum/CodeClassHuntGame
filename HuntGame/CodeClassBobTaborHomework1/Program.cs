using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeClassBobTaborHomework1
{
    class Program
    {
        static string weaponOfChoice;
        static string gameOfChoice;
        static string weapon;
        static string animal;

        static void Main(string[] args)
        {

            

            //Homework = create a program that does if statements, works with variables and user inputs.
            Console.WriteLine("Welcome to Come Get Some Hunting Ranch!\n" + 
                "We have a great host of beasts for you to test your hunting prowess.\n\n" +
                "Please select from the following game animals:\n\n" +
                "Enter 1 to try and take down a bear.\nEnter 2 to attempt to bag a deer.\nEnter 3 to pit yourself" +
                " against a wild hog and press Enter.");
            gameOfChoice = Console.ReadLine().ToString();
            Console.Clear();
                           
            Console.WriteLine("Now, please choose your weapon, but choose carefully\nas some weapons are better at killing your animal\n" +
                "and other weapons may only anger or frighten your prey away.\n\n" +
                "Enter 1 to try your hand with a rifle.\nEnter 2 to stalk with a bow and arrow.\nEnter 3 to head out with just a knife" +
                " and press Enter.");
            weaponOfChoice = Console.ReadLine().ToString();
            Console.Clear();
            
            if (weaponOfChoice == "1" || weaponOfChoice == "2" || weaponOfChoice == "3")
            {
                Console.WriteLine("Please press Enter to start your hunt. Good luck!!!");
                Console.ReadKey();
                Console.Clear();

                if (gameOfChoice == "1")
                {
                    HuntBear();
                }
                else if (gameOfChoice == "2")
                {
                    HuntDeer();
                }
                else if (gameOfChoice == "3")
                {
                    HuntWildHog();
                }
                else
                {
                    Console.WriteLine("Sorry, you did not enter a valid choice.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter a valid choice.");
                Console.ReadKey();
               
            }
            
        }

        static void HuntBear()
        {
            if (weaponOfChoice == "1")
            {
                Console.WriteLine("*BANG*\n\n\n\n*THUD*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your time at the range has paid of in a big way!\nThe 1100 lb monster grizzly you" +
                    " took down\nis known to the locals as Manfred the Man-Eater.\nHe is going to look great mounted in your" +
                    " man-cave. Great job hunter!");
                Console.ReadKey();
            }
            else if (weaponOfChoice == "2")
            {
                Console.WriteLine("*THWAP*\n\n\n\n*DOINK*\n\n\n AHHHHHHHHH No WAY!!!! *Gasp* *Huff* *Huff* *Huff*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your shot went low, and the grizzly (known locally as Manfred the Man-Eater)\n" +
                    "took an arrow to the knee. Good thing your running skills\n" +
                    "are better than your shooting ability! Now at least you were able to run far\n" +
                    "enough away to take the walk-of-shame back to base camp\nwhile 'Manny' reconfigures your truck!");
                Console.ReadKey();
            }
            else if (weaponOfChoice == "3")
            {
                Console.WriteLine("*ROOOOAAAAAAR*\n\n\n\nMother of God...\n\n\n\nAAAAAARRRRRRGGGGasflkjads;lfkajsfl!!!!!!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You dumbass! Who takes a knife to a bear fight?\nDid you think you were Davy friggin Crockett?\n" +
                    "The grizzly, known locally as Manfred the Man-eater,\nsmelled you coming up behind him and\n" +
                    "waited in hungry anticipation to rip you into bear-kibble!\nNow who do you think has to clean up the mess!\n" +
                    "You are banned for life!!! Oh wait...");
                Console.ReadKey();
            }
        }

        static void HuntDeer()
        {
            if (weaponOfChoice == "1")
            {
                Console.WriteLine("*sniff* *sniff*\n\n\n\n*tuddata tuddata tuddata*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("In a rookie mistake you tried to approach the deer from upwind\n" +
                    "and as soon as it caught a whiff of your stupidity it took off.\nWhat a shame. It looked to be an 8 pointer too!");
                Console.ReadKey();
            }
            else if (weaponOfChoice == "2")
            {
                Console.WriteLine("*THWIP*\n\n\n\n\n*schhwaff*\n\n\n\n*THUNK*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Wow!!! They will be telling stories about that shot for years to come!\n" +
                    "That bow was like an extension of yourself.\nAll the ladies are waiting in line back at the lodge for 'hunting' " +
                    "lessons!");
                Console.ReadKey();
            }
            else if (weaponOfChoice == "3")
            {
                Console.WriteLine("*sneak*\n\n*sneak*\n\n*sneak*\n\n\n\n\n*SHUNK*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("I cannot believe that you were able to sneak up on that buck like that!\n" +
                    "It sucks that you didn't make a clean kill.\nNow you have to follow the blood trail to finish him off,\n" +
                    "that, and you have to live with knowing you suck at life...");
                Console.ReadKey();
            }
        }

        static void HuntWildHog()
        {
            if (weaponOfChoice == "1")
            {
                Console.WriteLine("Don't be a pussy. Go back and get the knife.");
                Console.ReadKey();                
            }
            else if (weaponOfChoice == "2") 
            {
                Console.WriteLine("*THUNG*\n\n\n\n*WHAP*\n\n\n\n\n\n*SCREEEEEEEEEE SCREEEEEEEEEEE SCREEEEEEEEEEEEEEEEE*" +
                    "\n\n\n\n\n\n\n\n*SPLUUOOCK* *squish*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You hit that boar right in the armor plating!\nIf you had not forgotten to bring a knife" +
                    " you might have gotten him\nbefore he spilled your guts open with his razor sharp tusks!\n" +
                    "Good thing I had you sign that waiver.\nHere is a roll of duck tape to put yourself back together.");
                Console.ReadKey();
            }
            else if (weaponOfChoice == "3") 
            {
                Console.WriteLine("BYAAAAAAAAAAAH\n\n\n*SCREEEEE SCREEE SCREEEEEEEEEE*\n\n\n\n*stab* *stab* *stab*\n*SCREEEEEE*\n" +
                    "Why won't this thing DIE!! *stab* *KICK* *stab* *WHEEZ* *HUFF* *HUFF* *GASP*");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Come get some!!! Now THAT is how you take down a trophy hog!\nHe must be 400 lbs or better!\n" +
                    "Your man-card is now maxed with points.\nTime to cash some in with the Swedish bikini models\n" +
                    "that are waiting back at the hunting lodge!");
                Console.ReadKey();
            }
        }
    }
}
