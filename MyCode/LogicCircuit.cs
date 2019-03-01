using System.Collections.Generic;

namespace MyCode
{
    public class LogicCircuit
    {
        // CombinationCircuit
        // SequentialCircuit
        
        /// <summary>
        /// 組み合わせ回路 ＝ 現在の入力のみで出力が決まる回路
        /// </summary>
        public class CombinationCircuit
        {
            // [x] LogicGate
            // [ ] DeCoder
            // [ ] EnCoder
            // [ ] MultiPlexer
            // [x] Adder
            // [ ] Multiplier

            /// <summary>
            /// LogicGate = 出力値が一つのゲート
            /// </summary>
            class LogicGate
            {
                public static int NOT(int a) { return a == 0 ? 1 : 0; }

                public static int OR(int a, int b) { return (a == 1 || b == 1) ? 1 : 0; }

                public static int AND(int a, int b) { return (a == 1 && b == 1) ? 1 : 0; }

                public static int XOR(int a, int b) { return (a == b) ? 0 : 1; }

                public static int NOR(int a, int b) { return (a == 0 && b == 0) ? 1 : 0; }

                public static int NAND(int a, int b) { return (a == 1 && b == 1) ? 0 : 1; }   
            }

            /// <summary>
            /// 加算器 ＝ 二進数の加算を行うもの。全加算器と半加算器がある。
            /// 負の数の表現に２の補数(complement)を使ったり、減算は2の補数を加算することで実現できる。
            /// </summary>
            class Adder
            {
                public static Dictionary<string, int> HalfAdder(int A, int B)
                {
                    int sum, carry;
                    sum = LogicGate.XOR(A, B);
                    carry = LogicGate.AND(A, B);

                    return ReturnAddderDict(sum, carry);
                }
                
                public static Dictionary<string, int> FullAdder(int A, int B, int C)
                {
                    Dictionary<string, int> hf1 = HalfAdder(A, B);
                    Dictionary<string, int> hf2 = HalfAdder(hf1["sum"], C);

                    int sum = hf2["sum"];
                    int carry = LogicGate.OR(hf1["carry"], hf2["carry"]);
             
                    return ReturnAddderDict(sum,carry);
                }

                private static Dictionary<string, int> ReturnAddderDict(int sum, int carry)
                {
                    Dictionary<string, int> sc = new Dictionary<string, int>();
                    sc.Add(nameof(sum), sum);
                    sc.Add(nameof(carry), carry);
                    return sc;
                }
            }
        }

        public class SequentialCircuit
        {
            // [ ] FlipFlopCircuit == Register
            // [ ] CounterCircuit
            
            
        }
    }
}