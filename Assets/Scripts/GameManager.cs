using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private UIManager uIManager;
    private AudioSource audio;
    [SerializeField] private Vector2[] imagePositions;
    private int it = 0;
    [SerializeField] private GameObject img;
    private Button selected; 

    // Start is called before the first frame update
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        BackToMenu();
        audio =  GetComponent<AudioSource>();
        uIManager.SliderValue(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void Options ()
    {
        uIManager.HideMenu();
        uIManager.ShowOptions();
    }

    public void BackToMenu()
    {
        uIManager.HideOptions();
        uIManager.ShowMenu();
        uIManager.HideCredits();
    }

    public void ShowCredits()
    {
        uIManager.HideMenu();
        uIManager.ShowCredits();
    }

    public void ChangeVolume(float musicVolume)
    {
        audio.volume = musicVolume;
    }

    public void Mute(bool muteyn)
    {
        audio.mute = muteyn;
        uIManager.SliderValue(0);
  
    }

    public void ChangeImage()
    {
        it++;
        if (it == 4)
        {
            it = 0;
        }
        img.transform.position = imagePositions[it];
    }

    public void ChangeButtonState(Button skin)
    {
        skin.interactable = false;
        if(selected != null)
        {
            selected.interactable=true;
        }
        selected = skin;

    }

}
