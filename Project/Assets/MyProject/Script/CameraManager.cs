using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    GameObject target;
    private float speedMod = 70.0f;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            camera.transform.RotateAround(target.transform.position, Vector3.up, speedMod * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.B))
        {
            camera.transform.RotateAround(target.transform.position, Vector3.forward, speedMod * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.C))
        {
            camera.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            camera.transform.Translate(-Vector3.forward * 1f * Time.deltaTime);
        }
    }
}
