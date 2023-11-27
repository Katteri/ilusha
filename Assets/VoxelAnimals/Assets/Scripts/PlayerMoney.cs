using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

using UnityEngine.Events;
public class PlayerMoney : MonoBehaviour
{
    public int _moneyAmount;
    public TextMeshPro _money;

    public void Start()
    {
        _money.text = "money: " + _moneyAmount.ToString();
    }

    public void ProcessBuy(int money)
    {
        if (_moneyAmount - money < 0)
        {
            return;
        }

        _moneyAmount -= money;
        _money.text = "money: " + _moneyAmount.ToString();
    }

    public bool CanBuy(int price)
    {
        return _moneyAmount - price >= 0;

    }

    public void EarnMoney(int money)
    {
        _moneyAmount += money;
        _money.text = "money: " + _moneyAmount.ToString();
    }
}
