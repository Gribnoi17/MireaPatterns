using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public static class Wallet
    {

        public static int Money { get { CheckClass(); return walletInteractor.Money; } }
        public static bool IsInitialized {  get; private set; }

        private static WalletInteractor walletInteractor;

        public static void Initialize (WalletInteractor interactor)
        {
            walletInteractor = interactor;
            IsInitialized = true;
        }

        public static bool isEnoughMoney(int value)
        {
            CheckClass();
            return walletInteractor.IsEnoughMoney(value);
        }

        public static void AddMoney(int value)
        {
            CheckClass();
            walletInteractor.AddMoney(value);
        }

        public static void SpendMoney(int value)
        {
            CheckClass();
            walletInteractor.SpendMoney(value);
        }

        private static void CheckClass()
        {
            if (!IsInitialized)
            {
                throw new Exception("Wallet is not initialize yet");
            }
        }

    }
}
