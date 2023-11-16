using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private GameMang gameMang;
    [SerializeField] private GameObject menuMiniGame;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Interactable stopMiniGame;
    [SerializeField] private GameSpawn miniGame;

    public float timeStart;
    [SerializeField] public TextMeshPro timerText;

    public AudioClip _music;
    public AudioSource audioSource;
    public void StartGame()
    {
        timeStart = 60;
        timerText.text = timeStart.ToString();
        audioSource.PlayOneShot(_music);
        stopMiniGame.OnClick.AddListener(timeEnd);
        
    }
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();

        if (timeStart < 0)
        {
            timeEnd();
        }
    }
    public void timeEnd()
    {
        //audioSource.Stop();
        menuMiniGame.SetActive(false);
        mainMenu.SetActive(true);
        miniGame.StopPlay();
    }
}