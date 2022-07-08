using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRayCast : MonoBehaviour
{

    [SerializeField]
    public GameObject gameObject;
    string text;
    int childCount;
    string path = "Assets/MyProject/DataTransform.txt";
    int dem = 0;
    // Start is called before the first frame update
    void Start()
    {
        childCount = gameObject.transform.childCount;
        Hello();
        StartCoroutine(ExampleCoroutine());


    }
    private void Update()
    {
        

    }

    private void Hello()
    {

        for (int i = 0; i < childCount; i++)
        {
            GameObject gameObjectControl = gameObject.transform.GetChild(i).gameObject;

            MoveToPosition moveToPosition = new MoveToPosition();
            ReadTextData readTextData = new ReadTextData();
            Vector3 target = readTextData.GetPosition(gameObjectControl.name) * 1000;
            moveToPosition.AddAnimationClip(gameObjectControl, target);

            // Update is called once per frame
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Hello();

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
