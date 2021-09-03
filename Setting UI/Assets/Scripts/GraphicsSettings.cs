using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsSettings : MonoBehaviour
{
    public UIControl UIControl;

    private Graphics Graphics;

    [SerializeField]
    private Transform Presets;
    private GameObject PresetsSelected;

    [SerializeField]
    private Slider Resolution;

    [SerializeField]
    private Transform Shadows;
    private GameObject ShadowSelected;

    [SerializeField]
    private Slider ShadowDistance;

    [SerializeField]
    private Slider DrawDistance;

    [SerializeField]
    private Transform AntiAlasings;
    private GameObject AntiAlasingSelected;

    [SerializeField]
    private Transform V_syncs;
    private GameObject V_syncsSelected;

    [SerializeField]
    private Transform Reflections;
    private GameObject ReflectionsSelected;

    private void Awake()
    {
        PresetsSelected = null;
        ShadowSelected = null;
        AntiAlasingSelected = null;
        V_syncsSelected = null;
        ReflectionsSelected = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        Graphics = UIControl.data.Graphics;

        SelectPreset(Presets.Find(Graphics.Presets).gameObject);
        SelectShadow(Shadows.Find(Graphics.Shadow).gameObject);
        SelectAntiAlasing(AntiAlasings.Find(Graphics.AntiAlasing).gameObject);
        SelectV_sync(V_syncs.Find(Graphics.V_sync).gameObject);
        SelectReflections(Reflections.Find(Graphics.Reflection).gameObject);

        Resolution.value = Graphics.Resulation;
        ShadowDistance.value = Graphics.ShadowDistance;
        DrawDistance.value = Graphics.DrawDistance;
    }

    private void Update()
    {
        Graphics.Resulation = Resolution.value;
        Graphics.ShadowDistance = ShadowDistance.value;
        Graphics.DrawDistance = DrawDistance.value;
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

    public void SelectAntiAlasing(GameObject AntiAlasing)
    {
        if (AntiAlasingSelected != AntiAlasing)
        {
            if (AntiAlasingSelected != null)
            {
                AntiAlasingSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                AntiAlasingSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            AntiAlasing.GetComponent<Image>().color = Color.white;
            AntiAlasing.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            AntiAlasingSelected = AntiAlasing;
            Graphics.AntiAlasing = AntiAlasing.name;
            UIControl.data.Graphics = Graphics;
        }
    }

    public void SelectV_sync(GameObject V_sync)
    {
        if (V_syncsSelected != V_sync)
        {
            if (V_syncsSelected != null)
            {
                V_syncsSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                V_syncsSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            V_sync.GetComponent<Image>().color = Color.white;
            V_sync.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            V_syncsSelected = V_sync;
            Graphics.V_sync = V_sync.name;
            UIControl.data.Graphics = Graphics;
        }
    }

    public void SelectReflections(GameObject Reflections)
    {
        if (ReflectionsSelected != Reflections)
        {
            if (ReflectionsSelected != null)
            {
                ReflectionsSelected.GetComponent<Image>().color = new Color(0.298f, 0.369f, 0.549f, 1.000f);
                ReflectionsSelected.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.white;
            }
            Reflections.GetComponent<Image>().color = Color.white;
            Reflections.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
            ReflectionsSelected = Reflections;
            Graphics.Reflection = Reflections.name;
            UIControl.data.Graphics = Graphics;
        }
    }
    
}
