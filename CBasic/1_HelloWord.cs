// using == python의 import
using System; // 우리는 System과
using static System.Console; // static System.Console을 사용할거야.



namespace Hello
{
    internal class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args) // static vold 메서드부터 프로그램이 실행된다고 생각하면 된다.
        { // 코드가 여기서 시작해서 *
            if ( args.Length == 0 )  // args라는 인자내 아무것도 없는 경우에는
            {
                Console.WriteLine("사용법 : Hello.exe <이름>"); // 해당 메세지를 출력하라.
                // 사실 우리는  using sdtatic System.Console을 했기 때문에, Console 부분을 빼도 코드는 돌아간다.
                return;
            }

            WriteLine("Hello, {0}", args[0]); // 인자가 있는 경우에는, 인자의 가장 첫번째 것을 출력해라. [0]은 인덱스
            // 해당 부분을 보면, Console 부분을 뺀 것을 볼 수 있다.
        } // 여기서 끝남 (중괄호는 코드 블럭)
    }
}
