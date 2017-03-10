using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour {
    public int player;
    Vector3 tras;
    float vel;
    public GameObject prefabBola;
	// Use this for initialization
	void Start () {
        tras = new Vector3(0.0f, 0.0f);
        vel = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        tras.x = 0;
        tras.y = 0;
        if (player == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tras.y = vel * Time.deltaTime;
                transform.Translate(tras);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tras.y = -vel * Time.deltaTime;
                transform.Translate(tras);
            }
        }

        if (player == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                tras.y = vel * Time.deltaTime;
                transform.Translate(tras);
            }
            if (Input.GetKey(KeyCode.S))
            {
                tras.y = -vel * Time.deltaTime;
                transform.Translate(tras);
            }
        }
    }
}
