using System;

namespace MyCode
{
    public class DokusyuCSharp
    {
        public class Delegate
        {
            // デリゲートを宣言する
            // 戻り値の型と引数の型が同じ関数を代入するお皿のようなもの
            delegate void HogeDelegateProcess(string str);

            /// <summary>
            /// 戻り値の型と引数の型が同じであれば代入できる
            /// メソッドの引数としてメソッドを渡せる
            /// </summary>
            class DelegateUse
            {
                void FugaFunction(string[] data, HogeDelegateProcess hogeDelegateProc)
                {
                    foreach (var val in data)
                    {
                        hogeDelegateProc(val);
                    }
                }

                /// <summary>HogeDelegateProcの戻り値がvoidなのでこのHogeFuncの戻り値もvoidでないといけない</summary>
                /// <summary>同様に引数も同じ型でないといけない</summary>>
                static void HogeFunc(string arg)
                {
                    Console.WriteLine($"argument is {arg}");
                }

                public static void FakeMain(string[] args)
                {
                    var data = new[] {"hogehoge", "fugafuga", "mogumogu"};
                    
                    // Delegateのインスタンスをつくる
                    HogeDelegateProcess hogeDelProc = new HogeDelegateProcess(HogeFunc);
                    
                    // Classのインスタンスを作る
                    DelegateUse delegateUseClass = new DelegateUse(); 
                    
                    // Classの関数で引数として指定したDelegateに合致するdelegateのインスタンスを指定する
                    delegateUseClass.FugaFunction(data, hogeDelProc);
                }
            }
        }
    }
}