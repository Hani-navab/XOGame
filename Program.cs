using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace XOGame
{
    class Program
    {

        BooleanXO xo = new BooleanXO();


        static void Main(string[] args)
        {
          
            Drawdemo dr = new Drawdemo();
            dr.drow();
            Menu hh = new Menu();
            hh.MU();

            Console.ReadKey();
        }
        //************************************      

        public void ShowO(int _x, int _y)
        {
            //-------------------- situation for Winner----------------
            if (xo.a == true && xo.b == true && xo.c == true)
            {
                SaywinnerX();

            }

            else if (xo.d == true && xo.e == true && xo.f == true)
            {
                SaywinnerX();
            }

            else if (xo.g == true && xo.h == true && xo.l == true)
            {
                SaywinnerX();
            }
            else if (xo.a == true && xo.d == true && xo.g == true)
            {
                SaywinnerX();
            }
            else if (xo.b == true && xo.e == true && xo.h == true)
            {
                SaywinnerX();
            }
            else if (xo.c == true && xo.f == true && xo.l == true)
            {
                SaywinnerX();
            }
            else if (xo.a == true && xo.e == true && xo.l == true)
            {
                SaywinnerX();
            }
            else if (xo.c == true && xo.e == true && xo.g == true)
            {
                SaywinnerX();
            }
            //--------------
            else if (xo.m == true && xo.n == true && xo.o == true)
            {
                SaywinnerO();
            }

            else if (xo.p == true && xo.q == true && xo.r == true)
            {
                SaywinnerO();
            }

            else if (xo.s == true && xo.t == true && xo.u == true)
            {
                SaywinnerO();
            }
            else if (xo.m == true && xo.p == true && xo.s == true)
            {
                SaywinnerO();
            }
            else if (xo.n == true && xo.q == true && xo.t == true)
            {
                SaywinnerO();
            }
            else if (xo.o == true && xo.r == true && xo.u == true)
            {
                SaywinnerO();
            }
            else if (xo.m == true && xo.q == true && xo.u == true)
            {
                SaywinnerO();
            }
            else if (xo.o == true && xo.q == true && xo.s == true)
            {
                SaywinnerO();
            }
            if(xo.a==true&&xo.b==true&&xo.c==true&&xo.d==true&&xo.e==true&&xo.f==true&&xo.g==true&&xo.h==true&&xo.l==true&&xo.m==true&&xo.n==true&&xo.o==true&&xo.p==true&&xo.q==true&&xo.r==true&&xo.s==true&&xo.t==true&&xo.u==true)
            {
                SayDontHaveAWinner();
            }

        Repeat:
            //_____________________________________________                

            if (_x == 7 && _y == 6)
            {
                if (xo.a == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 6)
            {
                if (xo.b == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 6)
            {
                if (xo.c == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 12)
            {
                if (xo.d == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 12)
            {
                if (xo.e == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 12)
            {
                if (xo.f == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 18)
            {
                if (xo.g == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 18)
            {
                if (xo.h == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 18)
            {
                if (xo.l == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 6;
                    goto Repeat;
                }
            }

            //----------------------------------------------
            if (_x == 7 && _y == 6)
            {
                if (xo.m == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 6)
            {
                if (xo.n == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 6)
            {
                if (xo.o == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 12)
            {
                if (xo.p == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 12)
            {
                if (xo.q == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 12)
            {
                if (xo.r == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 18)
            {
                if (xo.s == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 18)
            {
                if (xo.t == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 18)
            {
                if (xo.u == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 6;
                    goto Repeat;
                }
            }


            //_____________________________________________        
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(_x, _y);
            Console.CursorVisible = false;
            ConsoleKeyInfo kp = Console.ReadKey();
            if (kp.Key == ConsoleKey.RightArrow)
            {

                MoveShodow_O MS = new MoveShodow_O();
                MS.RightArrow(_x, _y);
                if (_x == 7 && _y == 6)
                    ShowO(17, 6);
                if (_x == 17 && _y == 6)
                    ShowO(27, 6);
                if (_x == 27 && _y == 6)
                    ShowO(7, 12);
                if (_x == 7 && _y == 12)
                    ShowO(17, 12);
                if (_x == 17 && _y == 12)
                    ShowO(27, 12);
                if (_x == 27 && _y == 12)
                    ShowO(7, 18);
                if (_x == 7 && _y == 18)
                    ShowO(17, 18);
                if (_x == 17 && _y == 18)
                    ShowO(27, 18);
                if (_x == 27 && _y == 18)
                    ShowO(7, 6);


            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            while (kp.Key != ConsoleKey.O && kp.Key != ConsoleKey.RightArrow)
            {

                Console.Beep(1000, 70);
                goto Repeat;
            }
            if (kp.Key == ConsoleKey.O)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                ChangeColorSQXO cx = new ChangeColorSQXO();
                cx.ChSqo(_x, _y);
                if (_x == 7 && _y == 6)
                    xo.m = true;
                if (_x == 17 && _y == 6)
                    xo.n = true;
                if (_x == 27 && _y == 6)
                    xo.o = true;
                if (_x == 7 && _y == 12)
                    xo.p = true;
                if (_x == 17 && _y == 12)
                    xo.q = true;
                if (_x == 27 && _y == 12)
                    xo.r = true;
                if (_x == 7 && _y == 18)
                    xo.s = true;
                if (_x == 17 && _y == 18)
                    xo.t = true;
                if (_x == 27 && _y == 18)
                    xo.u = true;


                Move_shodow2_O kg = new Move_shodow2_O();
                kg.RightArrow(_x, _y);
                if (_x == 7 && _y == 6)
                    ShowX(17, 6);
                if (_x == 17 && _y == 6)
                    ShowX(27, 6);
                if (_x == 27 && _y == 6)
                    ShowX(7, 12);
                if (_x == 7 && _y == 12)
                    ShowX(17, 12);
                if (_x == 17 && _y == 12)
                    ShowX(27, 12);
                if (_x == 27 && _y == 12)
                    ShowX(7, 18);
                if (_x == 7 && _y == 18)
                    ShowX(17, 18);
                if (_x == 17 && _y == 18)
                    ShowX(27, 18);
                if (_x == 27 && _y == 18)
                    ShowX(7, 6);
            }
        }


        //************************************     

        public void ShowX(int _x, int _y)
        {
            //-----------------------situation for Winner-------------
            if (xo.a == true && xo.b == true && xo.c == true)
            {
                SaywinnerX();

            }

            if (xo.d == true && xo.e == true && xo.f == true)
            {
                SaywinnerX();
            }

            if (xo.g == true && xo.h == true && xo.l == true)
            {
                SaywinnerX();
            }
            if (xo.a == true && xo.d == true && xo.g == true)
            {
                SaywinnerX();
            }
            if (xo.b == true && xo.e == true && xo.h == true)
            {
                SaywinnerX();
            }
            if (xo.c == true && xo.f == true && xo.l == true)
            {
                SaywinnerX();
            }
            if (xo.a == true && xo.e == true && xo.l == true)
            {
                SaywinnerX();
            }
            if (xo.c == true && xo.e == true && xo.g == true)
            {
                SaywinnerX();
            }
            //--------------
            if (xo.m == true && xo.n == true && xo.o == true)
            {
                SaywinnerO();
            }

            if (xo.p == true && xo.q == true && xo.r == true)
            {
                SaywinnerO();
            }

            if (xo.s == true && xo.t == true && xo.u == true)
            {
                SaywinnerO();
            }
            if (xo.m == true && xo.p == true && xo.s == true)
            {
                SaywinnerO();
            }
            if (xo.n == true && xo.q == true && xo.t == true)
            {
                SaywinnerO();
            }
            if (xo.o == true && xo.r == true && xo.u == true)
            {
                SaywinnerO();
            }
            if (xo.m == true && xo.q == true && xo.u == true)
            {
                SaywinnerO();
            }
            if (xo.o == true && xo.q == true && xo.s == true)
            {
                SaywinnerO();
            }
            if (xo.a == true && xo.b == true && xo.c == true && xo.d == true && xo.e == true && xo.f == true && xo.g == true && xo.h == true && xo.l == true && xo.m == true && xo.n == true && xo.o == true && xo.p == true && xo.q == true && xo.r == true && xo.s == true && xo.t == true && xo.u == true)
            {
                SayDontHaveAWinner();
            }
        Repeat:
            //_____________________________________________                
            if (_x == 7 && _y == 6)
            {
                if (xo.a == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 6)
            {
                if (xo.b == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 6)
            {
                if (xo.c == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 12)
            {
                if (xo.d == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 12)
            {
                if (xo.e == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 12)
            {
                if (xo.f == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 18)
            {
                if (xo.g == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 17;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 18)
            {
                if (xo.h == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 27;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 18)
            {
                if (xo.l == true)
                {
                    DontGiveAnyKey1(_x, _y);
                    _x = 7;
                    _y = 6;
                    goto Repeat;
                }
            }

            //----------------------------------------------
            if (_x == 7 && _y == 6)
            {
                if (xo.m == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 6)
            {
                if (xo.n == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 6;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 6)
            {
                if (xo.o == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 12)
            {
                if (xo.p == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 12)
            {
                if (xo.q == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 12;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 12)
            {
                if (xo.r == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 7 && _y == 18)
            {
                if (xo.s == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 17;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 17 && _y == 18)
            {
                if (xo.t == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 27;
                    _y = 18;
                    goto Repeat;
                }
            }

            if (_x == 27 && _y == 18)
            {
                if (xo.u == true)
                {
                    DontGiveAnyKey2(_x, _y);
                    _x = 7;
                    _y = 6;
                    goto Repeat;
                }
            }
            //_____________________________________________        
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(_x, _y);
            Console.CursorVisible = false;
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.RightArrow)
            {
                MoveShodow_X MS = new MoveShodow_X();
                MS.RightArrow(_x, _y);
                if (_x == 7 && _y == 6)
                    ShowX(17, 6);
                if (_x == 17 && _y == 6)
                    ShowX(27, 6);
                if (_x == 27 && _y == 6)
                    ShowX(7, 12);
                if (_x == 7 && _y == 12)
                    ShowX(17, 12);
                if (_x == 17 && _y == 12)
                    ShowX(27, 12);
                if (_x == 27 && _y == 12)
                    ShowX(7, 18);
                if (_x == 7 && _y == 18)
                    ShowX(17, 18);
                if (_x == 17 && _y == 18)
                    ShowX(27, 18);
                if (_x == 27 && _y == 18)
                    ShowX(7, 6);
            }
            while (kt.Key != ConsoleKey.X && kt.Key != ConsoleKey.RightArrow)
            {
                Console.Beep(1000, 70);
                goto Repeat;
            }
            if (kt.Key == ConsoleKey.X)
            {
                ChangeColorSQXO cx = new ChangeColorSQXO();
                cx.ChSqx(_x, _y);
                if (_x == 7 && _y == 6)
                    xo.a = true;
                if (_x == 17 && _y == 6)
                    xo.b = true;
                if (_x == 27 && _y == 6)
                    xo.c = true;
                if (_x == 7 && _y == 12)
                    xo.d = true;
                if (_x == 17 && _y == 12)
                    xo.e = true;
                if (_x == 27 && _y == 12)
                    xo.f = true;
                if (_x == 7 && _y == 18)
                    xo.g = true;
                if (_x == 17 && _y == 18)
                    xo.h = true;
                if (_x == 27 && _y == 18)
                    xo.l = true;

                Move_shodow2_X kg = new Move_shodow2_X();
                kg.RightArrow(_x, _y);
                if (_x == 7 && _y == 6)
                    ShowO(17, 6);
                if (_x == 17 && _y == 6)
                    ShowO(27, 6);
                if (_x == 27 && _y == 6)
                    ShowO(7, 12);
                if (_x == 7 && _y == 12)
                    ShowO(17, 12);
                if (_x == 17 && _y == 12)
                    ShowO(27, 12);
                if (_x == 27 && _y == 12)
                    ShowO(7, 18);
                if (_x == 7 && _y == 18)
                    ShowO(17, 18);
                if (_x == 17 && _y == 18)
                    ShowO(27, 18);
                if (_x == 27 && _y == 18)
                    ShowO(7, 6);
            }

        }
        public void DontGiveAnyKey1(int dx, int dy)
        {
        rep:
            Console.SetCursorPosition(dx, dy);
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.RightArrow)
            {
                Console.Beep(900, 30);
                goto rep;
            }
            if (k.Key == ConsoleKey.RightArrow)
            {
                MoveShodow_O t = new MoveShodow_O();
                t.RightArrow(dx, dy);
                
            }

        }

        public void DontGiveAnyKey2(int dx, int dy)
        {
        rep:
            Console.SetCursorPosition(dx, dy);
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.RightArrow)
            {
                Console.Beep(900, 30);
                goto rep;
            }
            if (k.Key == ConsoleKey.RightArrow)
            {
                MoveShodow_O t = new MoveShodow_O();
                t.RightArrow(dx, dy);

               
            }

        }
        public void SaywinnerX()
        {

            Console.SetCursorPosition(40, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X Is Winner...");


            Console.SetCursorPosition(40, 17);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" O,you lost this game ");
            System.Threading.Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Drawdemo dr = new Drawdemo();
            dr.drow();
            Menu hh = new Menu();
            hh.MU();



        }
        public void SaywinnerO()
        {

            Console.SetCursorPosition(40, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O Is Winner...");


            Console.SetCursorPosition(40, 17);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" X,you lost this game ");
            System.Threading.Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Drawdemo dr = new Drawdemo();
            dr.drow();
            Menu hh = new Menu();
            hh.MU();
            
            
        }
        public void SayDontHaveAWinner()
      {
          Console.SetCursorPosition(40, 15);
          Console.BackgroundColor = ConsoleColor.Yellow;
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(" We dont have winner... ");


         
            
    
    }
    }
}                   
                 
        
  

            
          
        
     
   



