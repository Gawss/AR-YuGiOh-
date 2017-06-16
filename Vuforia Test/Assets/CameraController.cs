using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public WebCamTexture mCamera = null;
    public GameObject plane;
    //public GameObject plane_2;

    // Use this for initialization
    void Start()
    {
        plane = GameObject.FindWithTag("Player");
        //plane_2 = GameObject.FindWithTag("Player_2");

        mCamera = new WebCamTexture();
        plane.GetComponent<Renderer>().material.mainTexture = mCamera;
        //plane_2.GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}