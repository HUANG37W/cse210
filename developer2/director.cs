using System;
namespace developer2{
    public class director{
        public card card1 = new card();
        public string vaule = "";
        public int score;
        public int start_card;
        public int end_card;
        public director(){
            score = 300;
            start_card = card1._card;
        }
        public void StartGame(){
            while(true){
                Console.WriteLine($"This card is: {start_card}");
                Console.Write("Higher or lower? [h/l] ");
                value = Console.ReadLine();
                card1.GetCard();
                end_card = card1._card;
                Console.WriteLine($"Next card was: {end_card}");

                if (value == "h" || value == "H"){

                }
                else if (value == "l" || value == "L"){

                }
                Console.WriteLine($"Your score is: {score}");
                Console.Write("Play again? [y/n]");
                vaule = Console.ReadLine();
                if(score <= 0){
                    break;
                }
                else if (vaule == "n" || vaule == "N"){
                    break;
                }
            }
        }
    }
}