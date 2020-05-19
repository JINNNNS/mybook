using System;

namespace mybook
{
    class MyBook
    {
        public string name;
        public string date;
        public string name2;
        public string name3;
        public string place;
        public string editer;
        public string idea;
        public string edit;
        public string design;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBook mybook = new MyBook
            {
                name = "PHP 프로그래밍 입문",
                date = "2018년 5월 20일",
                name2 = "황재호",
                name3 = "김태헌",
                place = "한빛아카데미(주)",
                editer = "김현용",
                idea = "김이화",
                edit = "김이화",
                design = "여동일"
            };

        }
    }
}
