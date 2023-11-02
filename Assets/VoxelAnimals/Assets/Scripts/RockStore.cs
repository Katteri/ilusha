using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class RockStore : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    private int _cost = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "toys")
        {
            _playerMoney.EarnMoney(_cost);
            Destroy(other.gameObject);
        }
    }
}
