using System;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UIElements;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] public int _moneyAmount;
    [SerializeField] public TextMeshPro _money;

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