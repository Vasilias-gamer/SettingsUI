using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonController : MonoBehaviour
{
    public string FileName = "setting.txt";

    private void Start()
    {
        Debug.Log(GetFilePath(FileName));
    }

    public void Save(SettingsData data)
    {
        string json = JsonUtility.ToJson(data);
        WriteToFile(FileName, json);
    }
    public SettingsData Load()
    {
        SettingsData data = new SettingsData();
        string json = ReadFromFile(FileName);
        JsonUtility.FromJsonOverwrite(json, data);
        return data;
    }
    public void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }
    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.LogWarning("File not found!!!");
            return "";
        }
    }
    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
