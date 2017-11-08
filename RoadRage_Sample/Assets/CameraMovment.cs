using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public int frameNum = 0;
    static Vector3 south = new Vector3(1, 0, 0);
    static Vector3 north = new Vector3(-1, 0, 0);
    static Vector3 east = new Vector3(0, 0, 1);
    static Vector3 west = new Vector3(0, 0, -1);
    public float speed = 0.2F;
    static Vector3[] directions = { south, north, west, east };

    // Update is called once per frame
    void Update() {
        frameNum++;

        int i = frameNum / 500;
        transform.position += speed * directions[i % directions.Length];

    }
    
}
