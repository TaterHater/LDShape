using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public float delay = 10.0f;

    public void changeScene()
    {
        SceneManager.LoadScene("Main");
    }


    
    void Start()
    {
        this.Invoke("changeScene", delay);
    }

   
   
    }