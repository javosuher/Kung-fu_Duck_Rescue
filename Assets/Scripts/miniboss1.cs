using UnityEngine;
using System.Collections;

public class miniboss1 : MonoBehaviour {
    public bool colld = false;
    public AudioSource aud;
    
	// Use this for initialization
	void Start () {
	}

    void OnCollisionEnter2D(Collision2D coll) //impacto con pato
    {

        if (coll.gameObject.tag == "Pato")
        {
            //aud.Play();
            Application.Quit();
            //Debug.Log("Muerto");
            colld = true;
        }
        else
            colld = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("Colision detectada fuera1");
        if (coll.gameObject.tag == "brazoD")
        {
            Destroy(gameObject);
        }
    }
   
	
	// Update is called once per frame
	void Update () {
        

        if (!colld) //si no detecta impacto
            transform.Translate(Vector3.left * Time.deltaTime);

	}
}
