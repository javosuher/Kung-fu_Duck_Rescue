using UnityEngine;
using System.Collections;

public class ProgressBarFury : MonoBehaviour {

    public ScriptPato pato;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var percent = this.pato.PorcientoFuria;

        this.transform.Translate(Vector3.right * 1000 * Time.deltaTime);
        var xPos =   Mathf.Lerp(-7f, -3.15f, percent);

        var pos = this.transform.position;
        pos.x = xPos;
        this.transform.position = pos;
	}
}
