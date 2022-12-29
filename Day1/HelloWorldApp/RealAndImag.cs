namespace Maths;

public class Complex{
    private int real;
    private int imag;

    public Complex(){
        this.real = 0;
        this.imag = 0;
    }

    public Complex(int real, int imag){
        this.real = real;
        this.imag = imag;
    }

    // Property
    public int Real{
        get{return this.real;}
        set{this.real = value;}
    }

    public int Imag{
        get{return this.imag;}
        set{this.imag = value;}
    }

    // Operator Overloading
    public static Complex operator+ (Complex c1, Complex c2){
        Complex temp = new Complex();
        temp.Real = c1.real + c2.real;
        temp.Imag = c1.imag + c2.imag;
        return temp;
    }
}