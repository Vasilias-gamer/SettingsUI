using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SettingsData
{
    public Controls Contols = new Controls();
    public Language Language = new Language();
    public Graphics Graphics = new Graphics();
    public Privicy Privicy = new Privicy();
}

[Serializable]
public class Controls
{
    public string SteeringControl = "Steering";
    public bool SoundOn = false;
    public bool MusicOn = false;
    public string Hand = "LeftSide";
}

[Serializable]
public class Language
{
    public string LanguageSelected = "English";
}

[Serializable]
public class Graphics
{
    public string Presets="Automatic";
    public float Resulation=0f;
    public string Shadow="Off";
    public float ShadowDistance=0f;
    public float DrawDistance=0f;
    public string AntiAlasing="Off";
    public string V_sync="Off";
    public string Reflection="Off";
}

[Serializable]
public class Privicy
{
    public string PrivacyPolicy;
    public string GDPRSettings;
}