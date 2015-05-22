using UnityEngine;
using System.Collections;

public class ScriptPato : MonoBehaviour {
    
    public GameObject brazoD,brazoI,ulti,furia,director; //objetos
    public Animator anim;
    public AudioSource audio,audioulti;
    public Transform pato;
	private Director bosses;
    public bool colld = false;
    [Range(0,1)]
    public float FuriaPorGolpe;

	// Use this for initialization
    void Start()
    {
		bosses = this.director.GetComponent<Director>();
        //this.reposoD.GetComponent<Animator>().SetBool("introReposoD",false);
       // this.golpeD.GetComponent<Animator>().SetBool("introGolpeD", true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("HitD", true);
            brazoD.SetActive(true);
            audio.Play();
            //this.golpeD.GetComponent<Animator>().SetBool("introGolpeD", false);
        }
        else
        {
            //this.golpeD.GetComponent<Animator>().SetBool("introGolpeD", false);
            brazoD.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("HitI", true);
            brazoI.SetActive(true);
            audio.Play();
        }
        else
            brazoI.SetActive(false);

        if (this.PorcientoFuria == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            audioulti.Play();
            Transform.Instantiate(this.pato);
            anim.SetBool("HitUlti", true);
            ulti.SetActive(true);
            PorcientoFuria = 0;
            bosses.DestroyAll();
        }
        else
            ulti.SetActive(false);
    
    }

    internal void OnHitEnemy()
    {
       // Debug.Log("On Hit Enemy");
        this.PorcientoFuria += this.FuriaPorGolpe;
        this.PorcientoFuria = Mathf.Clamp(this.PorcientoFuria, 0,1); //pone un tope de máximo
        //Debug.Log(this.PorcientoFuria);
    }

    public float PorcientoFuria { get; private set; }
}
