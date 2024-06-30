using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealingStation : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;
    private GameObject player;
    private float healingAmount = 100;
    private bool entered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
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

    // IEnumerator Heal()
    // {
        
    // }

    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.E) && entered)
        // {
        //     Heal(healingAmount);
        //     Mathf.Clamp(health, 0, 100);
        // }
    }
}
