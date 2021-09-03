using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SettingsData
{
    public Controls Contols = new Controls();
    public Languages Languages = new Languages();
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
public class Languages
{
    public string LanguageSelected = "English";
}

[Serializable]
public class Graphics
{
    public string Presets="Automatic";
    public int Resulation;
    public string Shadow="Low";
    public int ShadowDistance;
    public int DrawDistance;
    public string AntiAlasing;
    public bool V_sync;
    public bool Reflection;
}

[Serializable]
public class Privicy
{
    public string PrivacyPolicy;
    public string GDPRSettings;
}