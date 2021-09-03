using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsSettings : MonoBehaviour
{
    public UIControl UIControl;
    private Graphics Graphics;
    private GameObject PresetsSelected;
    private GameObject ShadowSelected;

    private void Awake()
    {
        PresetsSelected = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        Graphics = UIControl.data.Graphics;
        //SelectPreset(transform.Find(Graphics.Presets).gameObject);
        SelectShadow(transform.Find(Graphics.Shadow).gameObject);
    }
    
    public void SelectPreset(GameObject preset)
    {
        if (PresetsSelected != preset)
        {
            if (PresetsSelected != null)
            {
                PresetsSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                PresetsSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            preset.GetComponent<Image>().color = Color.white;
            preset.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            PresetsSelected = preset;
            Graphics.Presets = preset.name;
            UIControl.data.Graphics = Graphics;
        }
    }

    public void SelectShadow(GameObject Shadow)
    {
        Debug.Log(Shadow);
        if (ShadowSelected != Shadow)
        {
            if (ShadowSelected != null)
            {
                ShadowSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                ShadowSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            Shadow.GetComponent<Image>().color = Color.white;
            Shadow.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            ShadowSelected = Shadow;
            Graphics.Shadow = Shadow.name;
            UIControl.data.Graphics = Graphics;
        }
    }
}
