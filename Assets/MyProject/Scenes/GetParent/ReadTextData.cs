using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ReadTextData
{
    string DATA;
    public ReadTextData()
    {
        string path = "Assets/MyProject/DataTransform.txt";
        StreamReader streamReader = new StreamReader(path);
        DATA = streamReader.ReadToEnd();
        streamReader.Close();
    }

    public Vector3 GetPosition(string name)
    {
        string[] b = DATA.Split('\n');
        foreach (var i in b)
        {
            string[] c = i.Split('_');
            if (c[0] == name)
            {
                return JsonUtility.FromJson<Vector3>(c[1]);
            }    
        }

        return Vector3.zero;
    }
}
