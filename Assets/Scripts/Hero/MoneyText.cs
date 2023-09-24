using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;
using UnityEngine;


public class MoneyText : MonoBehaviourPunCallbacks
{
    [SerializeField] private CoinPicker _coinPicker;
    [SerializeField] private TMP_Text _coinText;
    private int _coin;

    private void Awake()
    {
        _coinPicker.CoinCollected += CoinPickerOnCoinCollected;
    }

    private void CoinPickerOnCoinCollected(float coinsValue)
    {
        _coinText.SetText($"{coinsValue}");
    }

    private void OnDestroy()
    {
        _coinPicker.CoinCollected -= CoinPickerOnCoinCollected;
    }

    private void Start()
    {
       
    }
}
