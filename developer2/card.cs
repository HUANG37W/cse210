using System;

namespace developer2{
    public class card{
        public int _card;
            public Random num = new Random();
        public card(){
            _card = num.Next(1,14);
        }
        public void GetCard(){
            _card = num.Next(1,14);
        }
    }
}