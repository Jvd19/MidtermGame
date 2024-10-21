using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerSceneScript : MonoBehaviour
{
        void Update()
        {
            //If the player hit space. . .
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Then load the 'Example 3' scene
                SceneManager.LoadScene("Example 3");
            }
        }
}
