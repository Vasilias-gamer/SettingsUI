using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public JsonController JsonController;
    public SettingsData data;
    public GameObject ControlPanal;
    //public GameObject PrivacyPanal;
    //public GameObject GraphicPanal;
    //public GameObject LanguagePanal;
    private GameObject PanalSelected=null;

    private void Awake()
    {
        data = JsonController.Load();
    }

    private void Start()
    {
        SelectPanal(ControlPanal);
    }

    public void SelectPanal(GameObject Panal)
    {
        if (PanalSelected != Panal)
        {
            if (PanalSelected != null)
            {
                PanalSelected.SetActive(false);
                PanalSelected.transform.parent.GetComponent<Image>().color = new Color(0.122f, 0.145f, 0.200f, 1.000f);
            }
            Panal.SetActive(true);
            Panal.transform.parent.GetComponent<Image>().color = Color.white;
            PanalSelected = Panal;
        }
    }

    public void Done()
    {
        JsonController.Save(data);
    }
}

