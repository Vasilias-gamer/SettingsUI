using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlsSetting : MonoBehaviour
{
    public UIControl UIControl;
    private Controls Controls;
    private GameObject SteeringSelected;
    private GameObject HandSelected;
    [SerializeField]
    private Toggle SoundToggle;
    [SerializeField]
    private Toggle MusicToggle;

    private void Awake()
    {
        SteeringSelected = null;
        HandSelected = null;
    }

    private void Start()
    {
        Controls = UIControl.data.Contols;
        SteeringControl(transform.Find(Controls.SteeringControl).gameObject);
        Hand(transform.Find(Controls.Hand).gameObject);
        SoundToggle.isOn = Controls.SoundOn;
        MusicToggle.isOn = Controls.MusicOn;
    }

    private void Update()
    {
        Controls.SoundOn = SoundToggle.isOn;
        Controls.MusicOn = MusicToggle.isOn;
    }

    public void SteeringControl(GameObject sc)
    {
        if (SteeringSelected != sc)
        {
            if (SteeringSelected != null)
            {
                SteeringSelected.GetComponent<Image>().color = new Color(1, 1, 1, .2f);
                SteeringSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, .2f);
            }
            sc.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            sc.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
            SteeringSelected = sc;
            Controls.SteeringControl = sc.name;
            UpdateSetting();
        }
    }

    public void Hand(GameObject hand)
    {
        if (HandSelected != hand)
        {
            if (HandSelected != null)
            {
                HandSelected.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
                HandSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, .2f);
            }
            hand.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            hand.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
            HandSelected = hand;
            Controls.Hand = hand.name;
            UpdateSetting();
        }
    }

    /*public void SoundOn(bool SoundToggle)
    {
        Controls.SoundOn = SoundToggle;
        UpdateSetting();
    }

    public void MusicOn(bool MusicToggle)
    {
        Controls.MusicOn = MusicToggle;
        UpdateSetting();
    }*/

    public void UpdateSetting()
    {
        UIControl.data.Contols = Controls;
    }
}
