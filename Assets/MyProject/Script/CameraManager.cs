using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    private float speedMod = 70.0f;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.LookAt(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            camera.transform.RotateAround(Vector3.zero, Vector3.up, speedMod * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            camera.transform.RotateAround(Vector3.zero, Vector3.forward, speedMod * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.E))
        {
            camera.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            camera.transform.Translate(-Vector3.forward * 1f * Time.deltaTime);
        }
    }
}
