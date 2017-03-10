using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marcador : MonoBehaviour {
    public int gol;
    int cont1;
    int cont2;
    public Text text1;
    public Text text2;
	// Use this for initialization
	void Start () {
        text1.text = "0";
        text2.text = "0";
        cont1 = 0;
        cont2 = 0;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.N))
        {
            cont1 = 0;
            cont2 = 0;
            text1.text = cont1.ToString();
            text2.text = cont2.ToString();
        }
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (gol == 1)
        {
            if (collision.gameObject.name == "Bola")
            {
                cont2++;
                text2.text = cont2.ToString();
            }
        }
        if (gol == 2)
        {
            if (collision.gameObject.name == "Bola")
            {
                cont1++;
                text1.text = cont1.ToString();
            }
        }
    }
}
