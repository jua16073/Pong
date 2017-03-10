using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour {
    public Rigidbody vel;
    System.Random rnd= new System.Random();
    Vector3 velocidad= new Vector3();
    public GameObject prefabBola;
    // Use this for initialization
    void Start () {
        this.gameObject.name = "Bola";
    }
	
	// Update is called once per frame
	void Update () {
       if (Input.GetKey(KeyCode.Space))
        {
            vel = GetComponent<Rigidbody>();
            while (velocidad.x > -8 && velocidad.x < 8)
            {
                velocidad.x = rnd.Next(-9, 10);
            }
            while (velocidad.y > -6 && velocidad.y < 6)
            {
                velocidad.y = rnd.Next(-9, 10);
            }
            vel.velocity = velocidad;
        }


		
	}

    private void OnCollisionEnter(Collision collision)
    {
        vel.velocity = new Vector3();
        if (collision.gameObject.name == "Cube")
        {
            velocidad.x = rnd.Next(13, 18);
            velocidad.y = rnd.Next(-9, 10);
            while (velocidad.y<6 && velocidad.y > -6)
            {
                velocidad.y = rnd.Next(-9, 10);
            }
        }
        if (collision.gameObject.name == "Cube (1)")
        {
            velocidad.x = rnd.Next(-17, -12);
            velocidad.y = rnd.Next(-9, 10);
            while (velocidad.y < 6 && velocidad.y > -6)
            {
                velocidad.y = rnd.Next(-9, 10);
            }
        }
        if(collision.gameObject.name== "Borde arriba")
        {
            velocidad.y = -velocidad.y;
        }
        if (collision.gameObject.name == "Borde abajo")
        {
            velocidad.y = -velocidad.y;
        }
        vel.velocity = velocidad;
        if (collision.gameObject.name== "Gol")
        {
            Destroy(this.gameObject);
            Vector3 posIni = new Vector3(0.0f, 0.0f, 0.0f);
            Instantiate(prefabBola, posIni, Quaternion.identity);
            
        }
        if (collision.gameObject.name == "Gol (1)")
        {
            Destroy(this.gameObject);
            Vector3 posIni = new Vector3(0.0f, 0.0f, -1.0f);
            Instantiate(prefabBola, posIni, Quaternion.identity);
        }
    }

    private void Awake()
    {
        GetComponent<Bola>().enabled = true;
    }
}
