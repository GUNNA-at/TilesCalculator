using System.Diagnostics.CodeAnalysis;

internal class value

{


    private static void Main(string[] args)
    {
        const int TILE_PRICE = 10;
        const float TRIANGLE_TILE_PRICE = 9;
        const float RABAT = 5; //percent
        const string answer1 = "1";
        const string answer2 = "2";
        const string service_ansver1 = "Yes";
        const string service_ansver2 = "No";
        const float service_price = 86;
        float full_price_with_rabat;
        float rabat_price;
        float area;

        Console.WriteLine("How much tiles do you want to buy?");

        Console.WriteLine("More then 10 tiles - 5%");

        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\ta - Calculate how much tiles u need to cpver your floor");
        Console.WriteLine("\tb - Choose different shapes of tiles");

        {





            switch (Console.ReadLine())
            {


                case "a":
                    Console.WriteLine("Please enter te length of our floor:");
                    float length = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Please enter the width of your:");
                    float width = Convert.ToSingle(Console.ReadLine());


                    area = 2 * (length + width);

                    float quantityNeeded = area;
                    float totalPriceForArea = quantityNeeded * TILE_PRICE;
                    if (area >= 10)

                    {
                        {
                            rabat_price = RABAT / 100 * totalPriceForArea;
                            full_price_with_rabat = totalPriceForArea - rabat_price;
                            Console.WriteLine($"You need {quantityNeeded} tiles, and the total price is {full_price_with_rabat} Euros.");
                        }
                    }
                    else

                        Console.WriteLine($"You need {quantityNeeded} tiles, and the total price is {totalPriceForArea} Euros.");
                    break;
                case "b":
                    Console.WriteLine("\t1 - Triangle shape");
                    Console.WriteLine("\t2 - Square shape");
                    string shapeChoice = Console.ReadLine();
                    if (shapeChoice == answer1)
                    {

                        Console.WriteLine("How much do you want to buy?");
                        float quantity_triangle = Convert.ToSingle(Console.ReadLine());
                        if (quantity_triangle >= 10)
                        {

                            float price_triangle = quantity_triangle * TRIANGLE_TILE_PRICE;
                            float rabat_triangle = RABAT / 100 * price_triangle;
                            float full_price_triangle = price_triangle - rabat_triangle;
                            Console.WriteLine($"Your price is {full_price_triangle} Euro");


                        }

                    }
                    break;
            }
            Console.WriteLine("Do you want to use our proffecional service?");
            string service_answer1 = Console.ReadLine();


            if (service_answer1 == "Yes")

                Console.WriteLine("Our services cost 86 Euros per hour (our proffecionals will do 20 foot squared in one hour)");
            Console.WriteLine("Do you want to proceed?  Yes/No");

            string service_answerblock = Console.ReadLine();
            if (service_answerblock == "Yes" && full_price_with_rabat > 0)
            {
                Console.WriteLine($"Your cost is {(float)((area / 20) * service_price)} Euros.");

            }
                   
                    
                        
                
                













            





        }
    }
}