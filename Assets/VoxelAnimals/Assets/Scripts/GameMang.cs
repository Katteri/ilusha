using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using Unity.VisualScripting;
using UnityEngine;

public class GameMang : MonoBehaviour
{
    public event Action OnButtonClicked;

    [SerializeField] GameSpawn _gameSpawn;

    [SerializeField] private Interactable _interactable;

    [SerializeField] private GameObject menuMiniGame;
    [SerializeField] private GameObject mainMenu;

    [SerializeField] private Timer Timer;


    public void Start()
    {
        _interactable.OnClick.AddListener(ProcessClick);

    }
    public void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        Timer.StartGame();
        menuMiniGame.SetActive(true);
        mainMenu.SetActive(false);
        _gameSpawn.Play();

    }
}
