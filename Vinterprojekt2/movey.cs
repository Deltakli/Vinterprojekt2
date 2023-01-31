using System;
using System.Collections.Generic;
using Raylib_cs;

  public class TimerTwo
  {          
    public static (int, float, Rectangle) TimeTwo(int timer,
                                    float yMovement,
                                    Rectangle playerRect,
                                    int timer2) 
      {
        

        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            yMovement = -5;
        }

        else if (timer2 < 5)
        {
            timer2 --;
             yMovement = 50;
            timer2 = 30;
        }

         playerRect.y += yMovement;

           return (timer, yMovement, playerRect);
      }
  } 