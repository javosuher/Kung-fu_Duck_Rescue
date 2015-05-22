using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Director : MonoBehaviour {

    public Transform boss, boss2;
    public GUIText gText;
    public float timer = 10;
    private List<Transform> ListBosses;
	
        // Use this for initialization
	void Start () {
        this.StartCoroutine(this.SpawnEveryXSeconds());
        ListBosses = new List<Transform>();
	}

    private IEnumerator SpawnEveryXSeconds()
    {
        //Debug.Log("1");
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f,1.5f)); //2segundos
            ListBosses.Add(Transform.Instantiate(this.boss));
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
            ListBosses.Add(Transform.Instantiate(this.boss2));
        }
    }

    public void DestroyAll()
    {
        foreach (var boss in ListBosses)
        {
			if(boss != null)
            	Destroy(boss.gameObject);
        }
        ListBosses.Clear();
    }

	// Update is called once per frame
	void Update () {
        
    }
}
