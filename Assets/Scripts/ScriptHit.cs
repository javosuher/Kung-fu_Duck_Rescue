using UnityEngine;
using System.Collections;

public class ScriptHit : MonoBehaviour
{                                         
    private ScriptPato pato;              
                                          
    // Use this for initialization        
    void Start()
    {
        this.pato = this.transform.parent.GetComponent<ScriptPato>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "miniboss")
        {
            //Debug.Log("Colision detectada fuera");
            this.pato.OnHitEnemy();
        }

        if (coll.gameObject.tag == "miniboss2")
        {
            //Debug.Log("Colision detectada fuera");
            this.pato.OnHitEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
