using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Languages : MonoBehaviour 
{
    public static Languages instance;

    public List<KeyValuePair<string, string>> fields = new List<KeyValuePair<string, string>>();

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);


        DontDestroyOnLoad(this);

        LoadLanguage("en");
    }     

    public void LoadLanguage(string lang)
    {
        fields.Clear();
        TextAsset textAsset = Resources.Load<TextAsset>("Texts/" + lang);
        string allTexts = "";
        if (textAsset == null)
        {
            textAsset = Resources.Load<TextAsset>("Texts/en");
        }
        allTexts = textAsset.text;
        string[] lines = allTexts.Split(new string[] { "\r\n", "\n" },
            StringSplitOptions.None);
        string key, value;
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].IndexOf("=") >= 0 && !lines[i].StartsWith("#"))
            {
                key = lines[i].Substring(0, lines[i].IndexOf("="));
                value = lines[i].Substring(lines[i].IndexOf("=") + 1,
                        lines[i].Length - lines[i].IndexOf("=") - 1).Replace("\\n", Environment.NewLine);
                //fields.Add(key, value);
                fields.Add(new KeyValuePair<string, string>(key, value));                
            }
        }        
    }

    public string GetSpecificText(string key)
    {
        var theKeyToLookFor = key;
        return fields.Where(kvp => kvp.Key == theKeyToLookFor).Select(kvp => kvp.Value).FirstOrDefault();        
    }
}
