using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSc : MonoBehaviour
{
    private Toggle m_Toggle;
    private bool toggleValue;
    public Transform slider;

    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
        m_Toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(m_Toggle);
        });
        toggleValue = false;
    }

    private void Update()
    {
        if (toggleValue != m_Toggle)
            ToggleValueChanged(m_Toggle);
    }
    
    public void ToggleValueChanged(Toggle change)
    {
        if (change.isOn)
        {
            slider.localPosition = new Vector3(10, 0, 0);
            toggleValue = change;
        }

        else
        {
            slider.localPosition = new Vector3(-10, 0, 0);
            toggleValue = m_Toggle;
        }
    }
}
