using UnityEngine;
using System.Collections;

public class miniboss2 : MonoBehaviour {

    public bool colld = false;

    // Use this for initialization
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D coll) //impacto con pato
    {

        if (coll.gameObject.tag == "Pato")
        {
            //Debug.Log("Colision detectada fuera");
            Application.Quit();
            colld = true;
        }
        else
            colld = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("Colision detectada fuera1");
        if (coll.gameObject.tag == "brazoI")
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!colld) //si no detecta impacto
            transform.Translate(Vector3.right * Time.deltaTime);

    }
}
