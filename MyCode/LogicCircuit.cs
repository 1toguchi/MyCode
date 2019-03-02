using System;
using System.Collections.Generic;

namespace MyCode
{
    public class LogicCircuit
    {


        public static void Main(string[] args)
        {
        }
        // CombinationCircuit
        // SequentialCircuit
        
        /// <summary>
        /// 組み合わせ回路 ＝ 現在の入力のみで出力が決まる回路
        /// </summary>
        public class CombinationCircuit
        {

            // [ ] LogicGate
            //TODO: Bit enzan
                // [ ] TODO: Bitshift
            // [x] EnCoder

            /// <summary>
            /// 2進数を10進数に変換する。
            /// </summary>
            public static int Decoder(string str, int baseNum = 2)
            {
                int result = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    result += int.Parse(str[(str.Length-1) - i].ToString()) * (int)Math.Pow(baseNum, i);
                    Console.WriteLine("Now result is " + result);
                }

                return result;
            }

            /// <summary>
            /// 10進数をn進数に変換する。
            /// </summary>
            public static string Encoder(int n, int baseNum = 2){
                int num = n;
                string str = "";
                while (num != 0) {
                    int k = num % baseNum;
                    str = k + str;
                    num /= baseNum;
                }
                return str;
            }

            // [ ] MultiPlexer
            // [ ] Adder
                //TODO: completion 
            // [ ] Multiplier

            /// <summary>
            /// LogicGate = 出力値が一つのゲート
            /// </summary>
            class LogicGate
            {
                public static int NOT(int a) { return a == 0 ? 1 : 0; }

                /// <summary>
                /// bit演算におけるセットの役割。　0bX OR 1 で値をセットする。 0bX OR 0 だと値をセットしない。 
                /// </summary>
                public static int OR(int a, int b) { return (a == 1 || b == 1) ? 1 : 0; }

                /// <summary>
                /// bit演算におけるクリアの役割。　0bX AND 1 で値を残す。0bX AND 0 で値を残さない。
                /// </summary>
                public static int AND(int a, int b) { return (a == 1 && b == 1) ? 1 : 0; }

                /// <summary>
                /// bit演算における反転の役割。 0bX XOR 1 で値を反転する。 0bX XOR 0 で値を反転しない。
                /// </summary>
                public static int XOR(int a, int b) { return (a == b) ? 0 : 1; }

                public static int NOR(int a, int b) { return (a == 0 && b == 0) ? 1 : 0; }

                public static int NAND(int a, int b) { return (a == 1 && b == 1) ? 0 : 1; }   
            }

            /// <summary>
            /// ビット演算はあるまとまりのビット群に対して論理ゲートの処理を行うこと。
            /// ここでは入力をintにしている。intを内部処理でstringに変換してintで吐き出す。
            /// </summary>
            class BitwiseOperation
            {
                //BitOR
                public static string BitOR(string binaryStr, string maskBit)
                {
                    //todo exception
                    if (binaryStr.Length == maskBit.Length) return "";

                    for (int i = 0; i < binaryStr.Length; i++)
                    {
                        
                    }
                }
                
                //BitAND
                //BitNOT
                //BitXOR
                //BitShift
                    // LogicalRightShift
                    // LogicalLeftShift
                    // ArithmeticRightShift
                    // ArithmeticLeftShift
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

        /// <summary>
        /// 順序回路 = 過去の入力と現在の入力で出力が決まる回路
        /// </summary>
        public class SequentialCircuit
        {
            // [ ] FlipFlopCircuit == Register
            // [ ] CounterCircuit
            
            
        }
    }
}