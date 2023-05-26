using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class СollisionDetector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    private WalletRepository walletRepository;
    private WalletInteractor walletInteractor;

    private void Start()
    {
        this.walletRepository = new WalletRepository();
        this.walletRepository.Initialize();

        this.walletInteractor = new WalletInteractor(walletRepository);
        this.walletInteractor.Initialize();
    }


    private void OnCollisionEnter(Collision collision)
    {
        Wallet.AddMoney(5);
        _moneyText.text = "Money: " + Wallet.Money;
        SpawnerPoint.Instance.DestroyPoint();
        SpawnerPoint.Instance.SpawnPoint();
    }
}
