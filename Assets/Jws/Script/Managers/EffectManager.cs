using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance { get; private set; }

    public bool IsEffect;

    public GameObject ToggleEffectPanel;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        IsEffect = true;
    }
    public void On()
    {
        IsEffect = true;
    }

    public void Off()
    {
        IsEffect = false;
    }

    public void PanelOnOff(bool type)
    {
        ToggleEffectPanel.SetActive(type);
    }
}
