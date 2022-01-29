using System;
namespace developer2{
    public class director{
        public card card1 = new card();
        public string value = "";
        public int score;
        public int start_card;
        public int end_card;
        public director(){
            score = 300;
            start_card = card1._card;
        }
        public void StartGame(){
                value = ("");
            while(true){
                Console.WriteLine($"This card is: {start_card}");
                Console.Write("Higher or lower? [h/l] ");
                value = Console.ReadLine();
                card1.GetCard();
                end_card = card1._card;
                Console.WriteLine($"Next card was: {end_card}");

                if (value == "h" || value == "H"){
                    if (end_card >= start_card){
                        score += 100;
                    }
                    else {
                        score -= 75;
                    }

                }
                else if (value == "l" || value == "L"){
                    if (start_card >= end_card) {
                        score += 100;
                    }
                    else {
                        score -= 75;
                    }

                }
                Console.WriteLine($"Your score is: {score}");
                Console.Write("Play again? [y/n]");
                value = Console.ReadLine();
                if(score <= 0){
                    break;
                }
                else if (value == "n" || value == "N"){
                    break;
                }
                start_card = end_card;
            }
        }
    }
}