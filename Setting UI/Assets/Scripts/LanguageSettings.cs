using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageSettings : MonoBehaviour
{
    public UIControl UIControl;
    private Languages Languages;
    private GameObject LanguageSelected;

    private void Awake()
    {
        LanguageSelected = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        Languages = UIControl.data.Languages;
        ChooseLanguage(transform.Find(Languages.LanguageSelected).gameObject);
    }

    public void ChooseLanguage(GameObject language)
    {
        if (LanguageSelected != language)
        {
            if(LanguageSelected!=null)
            {
                LanguageSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                LanguageSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, .6f);
            }
            language.GetComponent<Image>().color = Color.white;
            language.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            LanguageSelected = language;
            Languages.LanguageSelected = language.name;
            UIControl.data.Languages = Languages;
        }
    }
}
