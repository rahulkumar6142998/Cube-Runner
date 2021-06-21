using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public NewBehaviourScript player;
    
    public Text score;
    private int scoreValue = 0;
    public AudioSource destroy;
    private int countDown;

    private void Start()
    {
        destroy = GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Destory")
        {
            destroy.Play();
            Destroy(other.gameObject);
           
            scoreValue += 1;
            score.text = scoreValue.ToString() ;
            
        }

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            player.enabled = false;

            Invoke("restart", 2f);

        }
      

    }
    void restart()
    {
        SceneManager.LoadScene("Menu");
    }


}
