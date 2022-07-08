using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveTransform : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObject;
    string text;
    int childCount;
    string path = "Assets/MyProject/DataTransform.txt";
    // Start is called before the first frame update
    void Start()
    {
        childCount = gameObject.transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            GameObject child = gameObject.transform.GetChild(i).gameObject;
            //string pathChild = path + '/' + child.name + ".txt";
            int a = child.transform.childCount;
            if (a !=0)
            {
                for (int j=0; j<a; j++)
                {
                    GameObject c = child.transform.GetChild(j).gameObject;
                    Vector3 d = c.transform.position;
                    text += '\n' + c.name + "_" + JsonUtility.ToJson(d);
                }    
            }    
            //pathChild = pathChild.Replace(':', '_');
            
        }

        StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.WriteLine(text);
        streamWriter.Close();
        Debug.Log("Hellllllllllllllllo");
        /*
        string path = "Assets/MyProject/1.txt";
        //Read the text from directly from the test.txt file
        StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.WriteLine("Hello");
        streamWriter.Close();
        */



        //Read the text from directly from the test.txt file
        //StreamReader streamWriter = new StreamReader(path);
        //Debug.Log(streamWriter.ReadToEnd());
        //streamWriter.Close();

        //string name = gameObject.transform.GetChild(i).name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
    }
}
