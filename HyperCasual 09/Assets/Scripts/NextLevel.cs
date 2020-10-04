using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("Go To Next Level");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
