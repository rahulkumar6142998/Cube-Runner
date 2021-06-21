using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoder : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
   
    // Update is called once per frame
     void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            LoadNextLevel();

        }
         
        
    }
    public void LoadNextLevel()
    {
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator Loadlevel(int LevelIndex)
    {
        //Start the Animation
        transition.SetTrigger("Start");

        //Wait for the Animation
        yield return new WaitForSeconds(transitionTime);

        //Load Scenne
        SceneManager.LoadScene(LevelIndex);
    }
}
