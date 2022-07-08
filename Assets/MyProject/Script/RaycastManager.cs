using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public class RaycastManager : MonoBehaviour
{
    [SerializeField]
    public Material hightlightMaterial;
    Material defaultMaterial;
    Transform selection;
    GameObject gameObjectControl;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            gameObjectControl = null;

            //HIHI.GetComponent<MoveToPosition>().gameObjectControl = null;
        }
        if (selection != null)
        {
            selection.GetComponent<Renderer>().material = defaultMaterial;
            selection = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;
            string name = selection.name;
            var selectionRenderer = selection.GetComponent<Renderer>();
            defaultMaterial = selectionRenderer.material;
            if (selectionRenderer != null)
            {
                selectionRenderer.material = hightlightMaterial;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObjectControl = selection.gameObject;

                MoveToPosition moveToPosition = new MoveToPosition();
                ReadTextData readTextData = new ReadTextData();
                Vector3 target = readTextData.GetPosition(gameObjectControl.name) * 1000;
                moveToPosition.AddAnimationClip(gameObjectControl, target);
            }
            //HIHI.GetComponent<MoveToPosition>().gameObjectControl = gameObjectControl;
        }
    }

}





    /*
    public float speed = 10f;
    public Vector3 targetPos;
    public bool isMoving;
    const int MOUSE = 0;
    [SerializeField]
    public Material hightlightMaterial;
    public Material defaultMaterial;
    Transform selection;
    public GameObject gameObjectControl;
    // Start is called before the first frame update
    void Start()
    { 
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(MOUSE))
        {
            SetTarggetPosition(gameObjectControl);
        }
        if (isMoving)
        {
            MoveObject(gameObjectControl);
        }
    }

    void FixedUpdate()
    {
        if (selection != null)
        {
            selection.GetComponent<Renderer>().material = defaultMaterial;
            selection = null;
        }    
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;

            string name = selection.name;
            var selectionRenderer = selection.GetComponent<Renderer>();
            defaultMaterial = selectionRenderer.material;
            if (selectionRenderer != null)
            {
                selectionRenderer.material = hightlightMaterial;
            }
            if (Input.GetKey(KeyCode.A))
            {
                targetPos = selection.position;
                gameObjectControl = selection.gameObject;
            }    
        }
    }

    void Control(GameObject gameObject)
    {

    }    
    void SetTarggetPosition(GameObject gameObject)
    {
        Plane plane = new Plane(Vector3.up, gameObject.transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPos = ray.GetPoint(point);

        isMoving = true;
    }
    void MoveObject(GameObject gameObject)
    {
        gameObject.transform.LookAt(targetPos);
        gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (gameObject.transform.position == targetPos)
            isMoving = false;
        //Debug.DrawLine(transform.position, targetPos, Color.green);

    }
    */


