﻿using System;
namespace project
{
    class Rectangle
    {
     
            double length;
            double width;

            public void acceptdetails(){
                length=4.5;
                width=3.5;
            }
        
    public double GetArea(){
        return length*width;
    }
    public void Display(){
       
        Console.WriteLine("Length:{0}",length);
         Console.WriteLine("Width:{0}",width);
          Console.WriteLine("Area:{0}",GetArea());
    }
        }
        class ExecuteRectangle{
            static void Main(string[] args){
                Rectangle r=new Rectangle();
                r.acceptdetails();
                r.Display();
                Console.ReadLine();

            }
        }
    }

