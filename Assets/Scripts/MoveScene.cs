using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MoveScene : MonoBehaviour
{
    public int sceneBuildIndex;
    [SerializeField] private GameObject uiElement;

    private bool entered = false;

    private void Update()
    {
        if(entered && Input.GetKeyDown(KeyCode.E)) 
            {
                // Player pressed E, so move level
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
    }
 
    // Level move zoned enter, if collider is a player
    // Move game to another scene
    private void OnTriggerEnter2D(Collider2D other) 
    {
        // Could use other.GetComponent<Player>() to see if the game object has a Player component
        if(other.tag == "Player") 
        {
            uiElement.SetActive(true);
            entered = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        uiElement.SetActive(false);
        entered = false;
    }
}