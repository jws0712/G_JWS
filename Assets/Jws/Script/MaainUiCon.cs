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
        StoreButton.onClick.AddListener(Store);
        ExerciseButton.onClick.AddListener(Exercise);
        FightButton.onClick.AddListener(Fight);
        SettingButton.onClick.AddListener(Setting);
    }

    void Store()
    {
        Menu[0].gameObject.SetActive(true);
        Menu[1].gameObject.SetActive(false);
        Menu[2].gameObject.SetActive(false);
        Menu[3].gameObject.SetActive(false);

    }

    void Exercise()
    {
        Menu[1].gameObject.SetActive(true);
        Menu[0].gameObject.SetActive(false);
        Menu[2].gameObject.SetActive(false);
        Menu[3].gameObject.SetActive(false);

    }

    void Fight()
    {
        Menu[2].gameObject.SetActive(true);
        Menu[0].gameObject.SetActive(false);
        Menu[1].gameObject.SetActive(false);
        Menu[3].gameObject.SetActive(false);
    }

    void Setting()
    {
        Menu[3].gameObject.SetActive(true);
        Menu[0].gameObject.SetActive(false);
        Menu[2].gameObject.SetActive(false);
        Menu[1].gameObject.SetActive(false);
    }
}
