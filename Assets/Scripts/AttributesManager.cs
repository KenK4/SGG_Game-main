using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesManager : MonoBehaviour
{
    public Image healthBar;
    public float health = 100f;
    public float attack;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Mathf.Clamp(health, 0, 100);
        healthBar.fillAmount = health / 100f;
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if(atm != null)
        {

            atm.TakeDamage(attack);
        }
    }
}
