using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    public JsonController JsonController;
    [HideInInspector]
    public SettingsData data;

    public GameObject[] Panals;
    public Button[] TabButtons;

    private Transform ButtonSelected;
    private GameObject PanalSelected;

    private void Awake()
    {
        PanalSelected = null;
        ButtonSelected = null;
        data = JsonController.Load();
    }

    private void Start()
    {
        foreach (GameObject panal in Panals)
            panal.SetActive(false);

        SelectPanal(Panals[0]);
        UpdateButton(TabButtons[0].transform);
    }

    public void SelectPanal(GameObject Panal)
    {
        if (PanalSelected != Panal)
        {
            if (PanalSelected != null)
            {
                PanalSelected.SetActive(false);
            }
            Panal.SetActive(true);
            PanalSelected = Panal;
        }
    }

    public void UpdateButton(Transform button)
    {
        if (ButtonSelected != button)
        {
            if (ButtonSelected != null)
            {
                ButtonSelected.GetComponent<Image>().color = new Color(0.122f, 0.145f, 0.200f, 1.000f);
                ButtonSelected.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, .5f);
            }
            button.GetComponent<Image>().color = Color.white;
            button.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            ButtonSelected = button;
        }
    }
    

    public void Done()
    {
        JsonController.Save(data);
    }
}

