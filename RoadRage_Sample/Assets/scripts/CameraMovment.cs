using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        rb = this.GetComponent<Rigidbody>();
        camera = Camera.main;
    }

    private Rigidbody rb;
    public int frameNum = 0;
    static Vector3 right = new Vector3(1, 0, 0);
    static Vector3 left = new Vector3(-1, 0, 0);
    static Vector3 forwed = new Vector3(0, 0, 1);
    static Vector3 back = new Vector3(0, 0, -1);
    public float speed = 0.2F;
    public float force = 2F;

    //public GameObject steeringWheel;

    Camera camera;

    // Update is called once per frame
    void Update() {
        Vector3 direction = camera.transform.forward;
        direction.y = 0;
        //Debug.Log("x = " + camera.transform.eulerAngles.x + " y =  " + camera.transform.eulerAngles.z  + " z = " + camera.transform.eulerAngles.z);
        //Debug.Log("direction = " + direction.ToString());



        rb.AddForce(direction * force);

    }

    public void moveLeft()
    {
        transform.position += speed * left;

    }

    public void moveRight()
    {
        transform.position += speed * right;

    }

    public void moveForwed()
    {
        transform.position += speed * forwed;

    }

    public void moveBack()
    {
        transform.position += speed * back;
    }

}
