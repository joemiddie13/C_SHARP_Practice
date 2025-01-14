﻿using System;

namespace Domain3
{
    class Program
    {
        
    static void Main(string[] args)
    {
     ToyTruck toyTruck1 = new ToyTruck("Monster","Beige",20,4);
     
     Console.WriteLine("The Monster truck sale price is {0}", toyTruck1.salePrice());
    }
    }   
    

public class ToyCar
{
    private double price;
    public string Name;
    public string Color;
    public virtual double Price

    {
        get
        {
         return price;
        }
        set
        {
         if (value > 0)
              price = value;
         }
    }
    public virtual double salePrice()
	{
	    return Price * .75;
	}
    

}


class ToyTruck: ToyCar
{
	public void ToyCar(string name, string color, double price)
	{
	 Name = name;
	 Color = color;
	 Price = price;
	}
	public int Doors;
	public override double salePrice()
	{
	    return Price * .7;
	}

    public ToyTruck(string name, string color, double price, int doors)
    {
        Name = name;
        Color = color;
        Price = price;
        Doors = doors;

    }
    }
}

