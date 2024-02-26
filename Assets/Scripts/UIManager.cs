using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Button start;
    [SerializeField] private Button quit;
    [SerializeField] private Button credits;
    [SerializeField] private Button option;
    [SerializeField] private GameObject img;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject options;
    [SerializeField] private Slider music;
    [SerializeField] private Toggle mute;
    [SerializeField] private GameObject[] skins;
    private GameManager gameManager;
    [SerializeField] private Button back;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private Button creditsMenu;
    private EventTrigger imagenMenu;
    [SerializeField] private Button skin1;
    [SerializeField] private Button skin2;
    [SerializeField] private Button skin3;

    // Start is called before the first frame update
    void Start()
    {
        imagenMenu = img.GetComponent<EventTrigger>();
        gameManager = FindObjectOfType<GameManager>();
        start.onClick.AddListener(() => { gameManager.StartGame(); });
        quit.onClick.AddListener(() => { gameManager.ExitGame(); });
        option.onClick.AddListener(() => { gameManager.Options(); });
        back.onClick.AddListener(() => { gameManager.BackToMenu(); });
        credits.onClick.AddListener(() => { gameManager.ShowCredits(); });
        creditsMenu.onClick.AddListener(() => { gameManager.BackToMenu(); });
        //       start.onClick.AddListener(() => { gameManager.StartGame(); });

        music.onValueChanged.AddListener(gameManager.ChangeVolume);
        mute.onValueChanged.AddListener(gameManager.Mute);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HideMenu()
    {
        menu.SetActive(false);
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
    }

    public void HideOptions() 
    {
        options.SetActive(false);
    }

    public void ShowOptions()
    {
       options.SetActive(true);
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void SliderValue(float value)
    {
        music.value = value;
    }

    public float GetValue()
    {
        return music.value;
    }

}
