using System.ComponentModel;

namespace ConsoleBoxingAndUnboxing
{
    /*
    *Цей проект відпрацьовує проблематику boxing  і unboxing та відслідкування за допомогою ILSpy  його в IL  коді
    *
    *This project works on the issues of boxing and unboxing and tracking it in IL code using ILSpy.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object b = a; // Boxing: int to object
            int c = (int)b; // Unboxing: object back to int
            /*
               //{
	           IL_0000: nop
	           // int num = 10;
	           IL_0001: ldc.i4.s 10
	           IL_0003: stloc.0
	           // object obj = num;
	           IL_0004: ldloc.0
	           IL_0005: box [System.Runtime]System.Int32
	           IL_000a: stloc.1
	           // int num2 = (int)obj;
	           IL_000b: ldloc.1
	           IL_000c: unbox.any [System.Runtime]System.Int32
	           IL_0011: stloc.2
	           // }
	           IL_0012: ret

               Ви можете побачити, що при виконанні операції boxing, значення типу int (10) завантажується на стек,
               а потім упаковується в об'єкт (box). Після цього, при виконанні операції unboxing, об'єкт розпаковується назад до типу int
               і зберігається у змінній c.
               Це показує, як відбувається процес boxing і unboxing в IL коді, і як це впливає на продуктивність,
               оскільки ці операції можуть бути дорогими з точки зору ресурсів.

               You can see that when performing the boxing operation, the value of type int (10) is loaded onto the stack,
               and then boxed into an object. After that, when performing the unboxing operation, the object is unboxed back to type int
               and stored in variable c.
               This shows how the process of boxing and unboxing occurs in IL code, and how it affects performance,
               as these operations can be expensive in terms of resources.
            */

        }
    }
}
