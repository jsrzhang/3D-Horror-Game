using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winGame : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    //loops game upon reaching end this is aplace holder for menu and end screen
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("game");
        }
}
