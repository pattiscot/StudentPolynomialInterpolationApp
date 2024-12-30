﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolynomialInterpolationApp
{
    interface IPolyInter
    {

        /// <summary>
        /// These are the parts of the Polynomial Interpolation 
        /// Object. Note that string Polynomial is the polynomial
        /// function created by the eval method. 
        /// 
        /// In your program when you are ready to run an example, 
        /// you will first create an object of type PolyInter, and 
        /// give it a name, say Polynomial. Then you will read in the
        /// x and y arrays (from console probably) saving them in 
        /// Polynomial.X and Polynomial.Y and you will set up array A by doing 
        /// Polynomial.A = new double[Polynomail.X.GetLength(0)];
        /// <summary>
        /// 
        /// 
        /// <summary>
        /// This is where the coefficients are saved
        /// </summary>
        double[] A { get; set; }
        
        /// <summary>
        /// This is where the x values are stored by the user
        /// </summary>
        double[] X { get; set; }
        
        /// <summary>
        /// This is where the y values are stored by the user
        /// </summary>
        double[] Y { get; set; }
        
        /// <summary>
        /// This is where you will store the string representation 
        /// of the polynomial in Newton's Form
        /// </summary>
        string Polynomial { get; set; }
        
        /// <summary>
        /// This is a boolean variable set to true if you can find
        /// an interpolating polynomial. It is set to false if you
        /// cannot find an interpolating polynomial.
        /// </summary>
        bool IsPossible { get; set; }

        /// <summary>
        /// This calculates the coefficients using the improved divided difference method and saves the coefficients to double[] A.
        /// </summary>
        void Coef();

        /// <summary>
        /// This evaluates the polynomial at some value t. You should also be
        /// able to write a string representation of the polynomial to the console.
        /// This is not implemented in the pseudocode. You will need to figure
        /// out how to do this.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        double Eval(double t);
    }
}
