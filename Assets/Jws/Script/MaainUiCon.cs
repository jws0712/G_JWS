using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaainUiCon : MonoBehaviour
{
    public GameObject[] Menu;


    public Button StoreButton;
    public Button ExerciseButton;
    public Button FightButton;
    public Button SettingButton;

    void Start()
    {
        SoundManager.instance.PlayMusic("Music");
        StoreButton.onClick.AddListener(Store);
        ExerciseButton.onClick.AddListener(Exercise);
        FightButton.onClick.AddListener(Fight);
        SettingButton.onClick.AddListener(Setting);
    }

    void Store()
    {
        Menu[0].gameObject.SetActive(true);
        SoundManager.instance.PanelOnOff(false);

        CheckMenu(0);
    }

    void Exercise()
    {
        Menu[1].gameObject.SetActive(true);
        SoundManager.instance.PanelOnOff(false);

        CheckMenu(1);


    }

    void Fight()
    {
        Menu[2].gameObject.SetActive(true);
        SoundManager.instance.PanelOnOff(false);

        CheckMenu(2);

    }

    void Setting()
    {
        SoundManager.instance.PanelOnOff(true);
        Menu[3].gameObject.SetActive(true);
        CheckMenu(3);


    }

    void CheckMenu(int ThisMenu)
    {
        for(int i = 0; i <= 3; i++)
        {
            if(i != ThisMenu)
            {
                Menu[i].gameObject.SetActive(false);
            }
            
        }
    }
}
