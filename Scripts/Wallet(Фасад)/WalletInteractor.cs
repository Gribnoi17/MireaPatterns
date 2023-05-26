
namespace Assets.Scripts
{
     public class WalletInteractor : Interactor
    {
        private WalletRepository _repository;

        public int Money => _repository.Money;

        public WalletInteractor(WalletRepository repository)
        {
            _repository = repository;
        }

        public override void Initialize()
        {
            Wallet.Initialize(this);
        }

        public bool IsEnoughMoney(int value)
        {
            return Money >= value;
        }

        public void AddMoney(int value)
        {
            _repository.Money += value;
            _repository.Save();
        }

        public void SpendMoney(int value)
        {
            _repository.Money -= value;
            _repository.Save();
        }
    }
}
