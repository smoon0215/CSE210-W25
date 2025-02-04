using System;

public class Fraction{
    private int top_;
    private int bottom_;

    public Fraction(){
        top_ = 1;
        bottom_ = 1;
    }

    public Fraction(int number){
        top_ = number ;
        bottom_ = 1;
    }

    public Fraction(int top, int bottom){
        top_ = top;
        bottom_ = bottom;
    }

    public string GetFractionString(){
        string fractionString = $"{top_}/{bottom_}";
        return fractionString;
    }

    public double GetDecimalValue(){
        return (double)top_ / (double)bottom_;
    }
}