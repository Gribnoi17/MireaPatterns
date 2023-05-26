using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class WalletRepository : Repository
{
    private const string KEY = "WALLET_MONEY";
    public int Money { get; set; }
    public override void Initialize()
    {
        this.Money = PlayerPrefs.GetInt(KEY, 0);
    }

    public override void Save()
    {
        PlayerPrefs.SetInt(KEY, this.Money);
    }
}

