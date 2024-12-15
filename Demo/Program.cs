using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            #endregion

            #region Variable Declaration
            // Variable Declaration
            // Datatype VariableName;

            // int Number; // Declare Variable
            // Allocate UnInitialized 4 Bytes At Memory

            // Console.WriteLine(Number); // Invalid

            // Number = 5;


            // Variable
            // 1. Name      : Number
            // 2. Datatype  : int
            // 3. Size      : 4 Bytes
            // 4. Value     : 5
            // 5. Address   : 0xF2A

            // Console.WriteLine(Number); //5

            // int Number = 5; // Declaration And Iniyialization For Number

            // Console.WriteLine(Number);

            // int Number01;
            // int Number02;
            // int Number03;

            // int Number01 = 2, Number02 = 3, Number03 = 5; 
            #endregion

            #region Datatype (Value Type) : Stack
            // Datatype (Value Type) :Stack

            // Declare Variable

            // int Number; // Value type

            // Allocate Uninitialized 4 Bytes At Stack

            // int : C# Keyword

            // BLC: Int32

            // Int32 Number02;

            // Number = 12;

            // Console.WriteLine(Number02); 
            #endregion

            #region Datatype (Reference Type) : Heap

            // Point P01; // Null
            // Declare Reference From Type 'Point'
            // P01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will be Allocated At Stack For The 'P01'
            // 0 Bytes Will be Allocated At Heap

            // Console.WriteLine(P01);

            // Console.WriteLine(P01.X); // Invalid

            // P01 = new Point();
            // new
            // 1. Allocate The Number Of Required Bytes For The Object at Heap
            // 2. Initialized The Allocated Byte With The Default Value of The Datatype
            // 3. Call User-Defined Constructor if Exsists
            // 4. Assign The Object Address To The Reference 'P01'

            //Console.WriteLine(P01.X); // 0
            //Console.WriteLine(P01.Y); // 0
            //Console.WriteLine(P01);   // Demo.Point

            //Point P02 = new Point();

            //P02.X = 12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //P01 = P02;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X); 
            #endregion

            #region Object
            // object O01;
            // Declare For Reference From Type 'Object'
            // O01 : Can Refer to Instance From Type 'Object' Or Any Type Inherited From Object

            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = 1.2;
            //O01 = true;
            //O01 = new Point();

            //Console.WriteLine(O01.GetHashCode()); // Id : Identicate For The Address Of The Object

            //Console.WriteLine(O01); // Demo.Point

            //Point P01 = new Point();
            // Console.WriteLine(P01.ToString()); // Demo.Point
            // Console.WriteLine(P01); // Demo.Point




            //P01.GetType();
            //P01.ToString();
            //P01.GetHashCode();
            //P01.Equals(); 
            #endregion

            #region Implicit And Explicit Casting
            // Casting : Convert From Any Datatype To Any Datatype 
            // 1. Implicet Casting

            // int X = 5;

            // double Y = /*(double)*/ X; // Iplicit Casting (Safe Casting)

            // Console.WriteLine(Y);

            //2. Explicit Casting

            // double X = 2.5;

            // int Y = (int) X; // Explicit Casting (UnSafe)
            // Console.WriteLine(Y);

            // Long X = 1111111111111111;

            // int Y = X; // Explicit Casting (UnSafe) 

            // Console.WriteLine(Y);

            // Console.WriteLine(int.MaxValue); 
            #endregion

            #region Convert, Parse And TryParse
            // parse : Function

            //Console.WriteLine(value:"Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine(value: "Enter Your GPA: ");
            //double GPA = int.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);


            // Convert : Class

            // Console.WriteLine(value:"Enter Your Age: ");
            // int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(value: "Enter Your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);


            // TryParse

            // Console.WriteLine(value:"Enter Your Age: ");
            // int Age;
            // bool Flag = int.TryParse(Console.ReadLine(), out Age);

            //Console.WriteLine(value: "Enter Your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + Flag); 
            #endregion

            #region Frarctions And Discards
            // double X = 1.5;
            // float Y = 1.5f;
            // decimal Z = 1.5m;


            // int X = 1_000_000_000; // Disard _

            // Console.WriteLine(X); 
            #endregion

            #region Operators

            // 1. unary Operators -> Works On One Operand (Variable)
            // int X = 10;

            // ++
            // PreFix [Increment then print]
            // Console.WriteLine(++X); // 11
            // PostFix [Print then Increment]
            // Console.WriteLine(X++); // 10
            // Console.WriteLine(X); // 11 

            // --

            // PreFix [Decrement then print]
            // Console.WriteLine(--X); // 9
            // PostFix [Print then Decrement]
            // Console.WriteLine(X--); // 10
            // Console.WriteLine(X); // 9 

            // ================================

            // 2.Binary Operators => Works on Two Operands (Variables)
            // + = / * %
            //int Sum, Mul, Sub, Mod;
            //int Number01 = 2, Number02 = 6;

            //Sum = Number01 + Number02; //8
            //Mul = Number01 * Number02; //12
            //Sub = Number01 - Number02; //-4
            //Mod = Number01 % Number02; //2
            // 23 % 3 = 2

            // ==================================
            // 3. Assignment Opeators

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2


            // =========================================
            // 4. Relational Operators [Comparison]

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y);
            //Console.WriteLine(X != Y);
            //Console.WriteLine(X >= Y);
            //Console.WriteLine(X <= Y);
            //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);


            // ===========================================
            // 5. Logical Operators [And, OR , NOT]
            //Console.WriteLine(!false); // ! -> NOT
            //Console.WriteLine(false && true); // && -> AND Short Circut
            //Console.WriteLine(false || true); // || -> OR Short Circut


            // ============================================
            // 6. BitWise Operators
            //Console.WriteLine(!false); // ! -> NOT
            //Console.WriteLine(false & true); // & -> AND Long Circut
            //Console.WriteLine(false | true); // | -> OR Long Circut


            // =============================================
            // 7. Ternary Operator [Conditional Operator]

            //bool flag = 4> 2;
            //Console.WriteLine(flag);
            //string flag = 4 < 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(flag);

            #endregion

            #region Operator Priority [Precdence] and Associtvity

            /*
                1. Unary Operator (PreFix)
                2. Round Braces ()
                3. * / %
                4. + -

            */


            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;

            //e = (a + b) * c / d;   // (30 * 15) / 5

            //e = ((a + b) * c) / d;   // (30 * 15) / 5

            //e = (a + b) * (c / d);   // (30) * (15/5)

            //e = a + (b * c) / d;   // 20 + (150 / 5)

            #endregion



        }
    }
}
