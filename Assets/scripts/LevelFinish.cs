using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource finishSound;
    private bool isFinish = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.name == "Player" && !isFinish)
        {
            finishSound.Play();
            isFinish = true;
            Invoke("CompleteLevel", 2f);


        }
    }
    // Update is called once per frame
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
