using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public TextMeshProUGUI HealthDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 200;
    }

    // Update is called once per frame
    void Update()
    {
        HealthDisplay.SetText("<color=red>"+ "HEALTH: "+Health+"</color>");
    }
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "BulletSample(Clone)")
            {
                Debug.Log("Took damage by EnemyBullet");
                Health -= 5;
            }
        }
}