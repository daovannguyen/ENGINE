using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
struct InfoGameObjectChild
{
   public string name;
   public Vector3 toaDo;
   public Vector3 goc;
};*/

public class AddVatLieu : MonoBehaviour
{
    public int dem = 0;
    public string text = "";
    [SerializeField]
    public GameObject model;
    public Material[] textures;
    //public List<InfoGameObjectChild> infoChild = new List<InfoGameObjectChild>();
    public List<string> name;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            GameObject a = model.gameObject.transform.GetChild(i).gameObject;
            a.gameObject.GetComponent<Renderer>().material = textures[i % 4];

            try
            {
                name.Add(a.name);
            }
            finally
            {

            }
            //InfoGameObjectChild b;
            //b.name = a.name;
            //b.toaDo = a.transform.position;
            //b.goc = a.transform.qua;
            //infoChild.Add(b);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (dem == 0)
        {
            for (int i = 0; i < 590; i++)
                text += "\t" + name[i];
            print(text);
            dem++;
        }
    }
}
