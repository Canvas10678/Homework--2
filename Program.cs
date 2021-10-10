using System;
enum Menu { Login = 1, Registeratation }
enum Artist { LeonardoDaVinci = 1, VanGogh, Michelangelo, Exit }

namespace App_for_Digital_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHead();
        }
        static void PrintHead()
        {
            Console.WriteLine("Welcome to Gallery");
            Console.WriteLine("---------------------------");
            PrintMenuInputMenuFormKeyborad();
        }
        static void PrintMenuInputMenuFormKeyborad()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("---------------------------");
            Console.Write("Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            PresentMenu(menu);
        }
        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.Login)
            {
                ShowYourInputLogin();
            }
            else if (menu == Menu.Registeratation)
            {
                ShowYourInputRegisterScreen();
            }
            else
            {
                ShowYourInCorrectMassage();
            }
        }
        static void ShowYourInputLogin()
        {
            Console.Clear();
            PrintLoginScreen();
        }
        static void ShowYourInputRegisterScreen()
        {
            Console.Clear();
            PrintListRegisterMenu();
        }
        static void ShowYourInCorrectMassage()
        {
            Console.Clear();
            Console.WriteLine("Menu is Incorrect Please try again");
            PrintMenuInputMenuFormKeyborad();
        }
        static string InputYourName()
        {
            Console.Write("Input Name: ");
            return Console.ReadLine();
        }
        static string InputYourPassword()
        {
            Console.Write("Input Password : ");
            return Console.ReadLine();
        }
        static string InputyourType()
        {
            InputYourName();
            InputYourPassword();
            Console.Write("Input Type : ");

            int Number_Choose = int.Parse(Console.ReadLine());
            if (Number_Choose == 1)
            {
                InputYourStudentID();
                Console.Clear();
                PrintHead();
            }
            else
            {
                InputEmployeeID();
                Console.Clear();
                PrintHead();
            }
            return Console.ReadLine();
        }
        static string InputYourStudentID()
        {
            Console.Write("Student ID : ");
            return Console.ReadLine();
        }
        static string InputEmployeeID()
        {
            Console.Write("Employee ID : ");
            return Console.ReadLine();
        }
        static void PrintListRegisterMenu()
        {
            Console.WriteLine("Register new Person.");
            Console.WriteLine("--------------------");
            InputyourType();
            PrintMenuInputMenuFormKeyborad();
            Console.Clear();
        }
        static void PrintLoginScreen()
        {
            Console.WriteLine("Login Screen.");
            Console.WriteLine("-------------");
            InputYourName();
            InputYourPassword();
            Console.Clear();
            WelcomeToGallery();
        }
        static void WelcomeToGallery()
        {
            Console.WriteLine("Invite to watching.");
            Console.WriteLine("--------------------");
            Console.WriteLine("Choose your Artist.");
            Console.WriteLine("--------------------");
            ChooseYourArtist();
        }
        static void ChooseYourArtist()
        {
            Console.WriteLine("1. LeonardoDaVinci");
            Console.WriteLine("2. VanGogh ");
            Console.WriteLine("3. Michelangelo");
            Console.WriteLine("4. Exit");
            Console.WriteLine("---------------------------");
            Console.Write("Select your Artist : ");
            Artist artist = (Artist)(int.Parse(Console.ReadLine()));
            ShowYourWork(artist);
        }
        static void ShowYourWork(Artist artist)
        {
            if (artist == Artist.LeonardoDaVinci)
            {
                InputYourLeonardoDaVinci();
            }
            else if (artist == Artist.VanGogh)
            {
                InputYourVanGogh();
            }
            else if (artist == Artist.Michelangelo)
            {
                InputYourMichelangelo();
            }
            else
            {
                WantToExits();
            }
            Console.WriteLine("--------------------------------------------------------");
            ChooseYourArtist();
        }
        //DaVinci
        static void InputYourLeonardoDaVinci()
        {
            Console.Write("Choose your Drawing Picture : ");
            int picture = int.Parse(Console.ReadLine());
            if (picture == 1)
            {
                Mona_Lisa();
            }
            else if (picture == 2)
            {
                TheLastSupper();
            }
            else if (picture == 3)
            {
                VitruvianMan();
            }
            else
            {
                Console.WriteLine("Please Input again : ");
                InputYourVanGogh();
            }
            CommentForArtWork();
        }
        //DaVinci
        static void Mona_Lisa()
        {
            Console.WriteLine("Mona Lisa : The Mona Lisa painting is one of the most emblematic portraits in the history of art," + "\n" +
                                          " where is located at the Louvre." + " Painted by Leonardo da Vinci in the 16th century," + "\n" +
                                         "It joined the collections of the court of France before being added to the works on display at the Louvre Museum.");
        }
        static void TheLastSupper()
        {
            Console.WriteLine("The Last Supper :  It depicts the dramatic scene described in several closely connected moments in the Gospels," +
                                         "\n" + "In which Jesus declares that one of the Apostles will betray him and later institutes the Eucharist.");
        }
        static void VitruvianMan()
        {
            Console.WriteLine("Vitruvian Man :  the image is commonly known as the Vitruvian Man." + "\n" +
                                              "It's a study of the ideal proportions of the human form." + "\n" + " It is part of a book written by Luca Pacioli known as the ''Divine Proportion.''");
        }
        //Vangogh
        static void InputYourVanGogh()
        {
            Console.Write("Choose your Drawing Picture : ");
            int picture = int.Parse(Console.ReadLine());
            if (picture == 1)
            {
                CaféTerraceAtNight();
            }
            else if (picture == 2)
            {
                TheStarryNight();
            }
            else if (picture == 3)
            {
                Sunflowers();
            }
            else 
            {
                Console.WriteLine("Please Input again : ");
                InputYourVanGogh();
            }
            CommentForArtWork();
        }
        //Vangogh
        static void CaféTerraceAtNight()
        {
            Console.WriteLine("Café Terrace at Night was one of the first nocturnal scenes painted by Van Gogh at the time of his stay in Arles.");
        }
        static void TheStarryNight()
        {
            Console.WriteLine("Vincent van Gogh painted Starry Night in 1889 while he was at the hospital." +
                "\n" + " Saint-Paul-de-Mausole thus there was a tonal change in his work. He's reverted to dark since the beginning of his career, " +
                "\n" +  "and Starry Night is a good example of that transition. Blue dominates the painting." +
                "\n" +  "Mix of hills and skies, a small village The bases in the painting are brown, gray and blue," +
                "\n" +  "although each building is clearly marked with black. But the yellow and white of the stars and moon stood out above the sky. "+
               "\n" +   "attracting the eyes to look up at the sky They are the great attractors of paintings.");
        }
        static void Sunflowers()
        {
            Console.WriteLine("Sunflowers form a unique connection between van Gogh and Paul Gauguin. " + "\n" +
                "It was van Gogh’s dream to start an art colony in Arles, based initially at the place known as The Yellow House.");
        }
        //Michelangelo
        static void InputYourMichelangelo()
        {
            Console.Write("Choose your Drawing Picture : ");
            int picture = int.Parse(Console.ReadLine());
            if (picture == 1)
            {
                Pietà();
            }
            else if (picture == 2)
            {
                CreationofAdam();
            }
            else if (picture == 3)
            {
                TheLibyanSibyl();
            }
            else
            {
                Console.WriteLine("Please Input again : ");
                InputYourVanGogh();
            }
            CommentForArtWork();
        }
        //Michelangelo
        static void Pietà()
        {
            Console.WriteLine("Pietà is a popular subject among Northern European artists. It means pity or sympathy. " + "\n" +
                "and represented Mary contemplating the corpse of her son she carried on her lap mournfully. " + "\n" +
                "This sculpture was commissioned by a French cardinal who lived in Rome.");
        }
        static void CreationofAdam()
        {
            Console.WriteLine("In a sense, this picture shows much more than the creation of the first man." + "\n" +
                " in fact It shows the beginning of what would later become the human race. " + "\n" +
                 "Adam's body arched as he extended towards God. taking into account the idea that man was created in a manner like God himself. " + "\n" +
                 "The way the two important people relate and relate to each other. The closeness that Adam had to his Creator could be seen." + "\n" +
                 "Michelangelo created the creation of Adam in such a way that the figure of Adam reflected the image of God." + "\n" +
                " As if one thing was just an extension of another.");
        }
        static void TheLibyanSibyl()
        {
            Console.WriteLine("The Libyan Sibyl is a motif painted on the Sistine Chapel, one of the many that Michelangelo worked on for four years." + "\n" +
                 "These paintings all had religious motifs and depicted the doctrine of the Catholic Church.The Libyan Sibyl is a depiction of Phemonoe, " + "\n" +
                 "the priestess of the Oracle of Zeus-Ammon. She is known for predicting that the day would come when the hidden would be revealed. " + "\n" +
                 "She is known as the Libyan Sibyl because the Oracle she presided over was located in the Libyan desert at Siwa Oasis.");
        }
        static void WantToExits()
        {
            string text = "";
            while (text != "exit")
            {
                Console.Write("Input: ");
                text = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Thanks for watching and See you again in next time.");
            Console.WriteLine("------------------------------------------------------------");
            PrintHead();
        }
        static string CommentForArtWork()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Comment : ");
            return Console.ReadLine();
        }
    }
}
