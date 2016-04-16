using UnityEngine;
using System.Collections;

public class soundTrigger : MonoBehaviour {

    public GameObject Player;
    public AudioClip[] myClip;
    public int overrideChoice;
    //bool hasPlayed=false;
    public bool isActive = false;
   
    void Start()
    {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hiiit");
        isActive = true;

        if (other.tag == "Player")
        {
            if (overrideChoice != 20)
            {
                GetComponent<AudioSource>().clip = myClip[overrideChoice];
            }
            Debug.Log("hit");
            GetComponent<AudioSource>().clip = myClip[Random.Range(0, myClip.Length)];
            GetComponent<AudioSource>().Play();

        }


    }
}
