using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class GameMang : MonoBehaviour
{
    public event Action OnButtonClicked;

    [SerializeField] GameSpawn _gameSpawn;

    [SerializeField] private Interactable _interactable;

    public void Start()
    {
        _interactable.OnClick.AddListener(ProcessClick);
    }
    public void ProcessClick()
    {
        OnButtonClicked?.Invoke();

        _gameSpawn.Play();

    }
}