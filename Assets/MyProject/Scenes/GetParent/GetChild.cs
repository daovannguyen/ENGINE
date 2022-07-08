using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GetChild : MonoBehaviour
{
    public GameObject gameObject;
    int childCount;
    List<string> allName = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
        childCount = gameObject.transform.childCount;
        for (int i=0; i<childCount; i++)
        {
            GameObject child = gameObject.transform.GetChild(i).gameObject;
            int s = child.transform.childCount;
            if (s != 0)
            {
                List<string> name = new List<string>();
                for (int j=0; j<s; j++)
                {
                    name.Add(child.transform.GetChild(j).name);
                }
                string combinedString = string.Join(",", name);
                allName.Add(combinedString);
            }    
        }
        string end = string.Join("\n", allName);
        StreamWriter streamWriter = new StreamWriter(@"D:\1.txt");
        streamWriter.WriteLine(end);
        streamWriter.Close();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
