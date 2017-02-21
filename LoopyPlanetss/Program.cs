using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyPlanetss
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageText;
            string messageText2;

            Console.WriteLine("Menu of Planets");
            Console.WriteLine("=== == ===");
            Console.WriteLine("1. Mercury       2. Venus        3. Mars");
            Console.WriteLine("4. Jupiter       5. Saturn       6. Uranus");
            Console.WriteLine("7. Neptune       8. Pluto        ");
            Console.WriteLine("What would your weight be in other planets?");

            Console.WriteLine("Please select a planet by inputting the corresponding number ");
            int x = Convert.ToInt32(Console.ReadLine());

            while (x > 0 && x < 9)
            {
                try
                {
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("What is your weight, in lbs?");
                            double y = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                double mercuryGravity = 0.37;

                                messageText = "Your weight would be ";
                                messageText2 = " lbs on mercury";


                                bool properWeight = true;
                                properWeight = y <= 999 && y >= 1;


                                if (properWeight == true)
                                {
                                    Console.WriteLine(messageText + ((y * mercuryGravity).ToString("#.#")) + messageText2);
                                }
                                else
                                {
                                    Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Please input your weight in numbers");
                            }
                            break;


                        case 2:

                            Console.WriteLine("What is your weight, in lbs?");
                            double a = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                double venusGravity = 0.88;

                                messageText = "Your weight would be ";
                                messageText2 = " lbs on Venus";

                                bool properWeight = true;
                                properWeight = a <= 999 && a >= 1;


                                if (properWeight == true)
                                {
                                    Console.WriteLine(messageText + ((a * venusGravity).ToString("#.#")) + messageText2);
                                }
                                else
                                {
                                    Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Please input your weight in numbers");
                            }
                            break;


                        case 3:

                            Console.WriteLine("What is your weight, in lbs?");
                            double b = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                double marsGravity = 0.38;

                                messageText = "Your weight would be ";
                                messageText2 = " lbs on Mars";


                                bool properWeight = true;
                                properWeight = b <= 999 && b >= 1;


                                if (properWeight == true)
                                {
                                    Console.WriteLine(messageText + ((b * marsGravity).ToString("#.#")) + messageText2);
                                }

                                else
                                {
                                    Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                }

                            }
                            catch
                            {
                                Console.WriteLine("Please input your weight in numbers");
                            }
                            break;


                        case 4:
                            {
                                Console.WriteLine("What is your weight, in lbs?");
                                double c = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    double jupiterGravity = 2.64;

                                    messageText = "Your weight would be ";
                                    messageText2 = " lbs on Jupiter";


                                    bool properWeight = true;
                                    properWeight = c <= 999 && c >= 1;


                                    if (properWeight == true)
                                    {
                                        Console.WriteLine(messageText + ((c * jupiterGravity).ToString("#.#")) + messageText2);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Please input your weight in numbers");
                                }
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("What is your weight, in lbs?");
                                double d = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    double saturnGravity = 1.15;

                                    messageText = "Your weight would be ";
                                    messageText2 = " lbs on Saturn";


                                    bool properWeight = true;
                                    properWeight = d <= 999 && d >= 1;


                                    if (properWeight == true)
                                    {
                                        Console.WriteLine(messageText + ((d * saturnGravity).ToString("#.#")) + messageText2);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Please input your weight in numbers");
                                }
                                break;
                            }



                        case 6:
                            {
                                Console.WriteLine("What is your weight, in lbs?");
                                double e = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    double uranusGravity = 1.15;

                                    messageText = "Your weight would be ";
                                    messageText2 = " lbs on Uranus";


                                    bool properWeight = true;
                                    properWeight = e <= 999 && e >= 1;


                                    if (properWeight == true)
                                    {
                                        Console.WriteLine(messageText + ((e * uranusGravity).ToString("#.#")) + messageText2);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Please input your weight in numbers");
                                }
                                break;
                            }


                        case 7:
                            {
                                Console.WriteLine("What is your weight, in lbs?");
                                double f = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    double neptuneGravity = 1.12;

                                    messageText = "Your weight would be ";
                                    messageText2 = " lbs on Neptune";


                                    bool properWeight = true;
                                    properWeight = f <= 999 && f >= 1;


                                    if (properWeight == true)
                                    {
                                        Console.WriteLine(messageText + ((f * neptuneGravity).ToString("#.#")) + messageText2);

                                    }

                                    else
                                    {
                                        Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Please input your weight in numbers");
                                }
                                break;
                            }


                        case 8:
                            {
                                Console.WriteLine("What is your weight, in lbs?");
                                double g = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    double plutoGravity = 0.04;

                                    messageText = "Your weight would be ";
                                    messageText2 = " lbs on Pluto";


                                    bool properWeight = true;
                                    properWeight = g >= 1;


                                    if (properWeight == true)
                                    {
                                        Console.WriteLine(messageText + ((g * plutoGravity).ToString("#.#")) + messageText2);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Please input your proper weight in lbs that is >= 1");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Please input your weight in numbers");
                                }
                                break;

                            }

                        default:
                            {
                                Console.WriteLine("Input, in numbers, your planet selection, then proceed by inputting your weight in lbs. Any other input will cause an error");
                                break;
                            }
                    }
                }

                catch
                {
                    Console.WriteLine("Please input a number from 1 - 8");
                }

                Console.ReadLine();

                Console.WriteLine("Would you like to Continue? Type 1 for Yes or 2 for No");
                int h = Convert.ToInt32(Console.ReadLine());

                switch (h)
                {
                    case 1:
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }
                





            }

            Console.WriteLine("Please make a selection 1 - 8");
            Console.ReadLine();

            //if (x == 9)
            //{
            //    Environment.Exit(0);
            //}


            //if (x == 1)
            //        {
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    try
            //            {
            //                double mercuryGravity = 0.37;

            //                messageText = "Your weight would be ";
            //                messageText2 = " lbs on mercury";


            //                bool properWeight = true;
            //                properWeight = y <= 999 && y >= 1;


            //                if (properWeight == true)
            //                {
            //                    Console.WriteLine(messageText + ((y * mercuryGravity).ToString("#.#")) + messageText2);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //                }
            //            }
            //            catch
            //            {
            //                Console.WriteLine("Please input your weight in numbers");
            //            }
            //        }


            //else if (x == 2)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double venusGravity = 0.88;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Venus";

            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * venusGravity).ToString("#.#")) + messageText2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}

            //else if (x == 3)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double marsGravity = 0.38;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Mars";


            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * marsGravity).ToString("#.#")) + messageText2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}

            //else if (x == 4)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double jupiterGravity = 2.64;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Jupiter";


            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * jupiterGravity).ToString("#.#")) + messageText2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}

            //else if (x == 5)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double saturnGravity = 1.15;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Saturn";


            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * saturnGravity).ToString("#.#")) + messageText2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}

            //else if (x == 6)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double uranusGravity = 1.15;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Uranus";


            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * uranusGravity).ToString("#.#")) + messageText2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}
            //else if (x == 7)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double neptuneGravity = 1.12;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Neptune";


            //        bool properWeight = true;
            //        properWeight = y <= 999 && y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * neptuneGravity).ToString("#.#")) + messageText2);

            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}
            //else if (x == 8)
            //{
            //    Console.WriteLine("What is your weight, in lbs?");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        double plutoGravity = 0.04;

            //        messageText = "Your weight would be ";
            //        messageText2 = " lbs on Pluto";


            //        bool properWeight = true;
            //        properWeight = y >= 1;


            //        if (properWeight == true)
            //        {
            //            Console.WriteLine(messageText + ((y * plutoGravity).ToString("#.#")) + messageText2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("Please input your proper weight in lbs that is >= 1");
            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input your weight in numbers");
            //    }
            //}

            //else if (x == 9)
            //{
            //        Environment.Exit(0);
            //}

            //else if (x > 9)
            //{
            //    Console.WriteLine("PLEASE SELECT ONE OF THE OPTIONS");
            //}

            //else
            //{
            //        Console.WriteLine("Default error");
            //}






        }

    }

    
}

    

