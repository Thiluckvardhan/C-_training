// using System;
// using DigitalWallet.Core;
// namespace DigitalWalletApp
// {
//     class Program{
//         static void Main(string[] args)
//         {
//             string appName=WalletInfo.GetAppName();
//             Console.WriteLine(appName);
//         }
//     }
// }

using System;
using DigitalWallet.Core;
namespace DigitalWalletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000m;

            object boxedBalance = balance;   // BOXING

            Console.WriteLine("Boxed Balance: " + boxedBalance.GetType());
        }
    }
}
