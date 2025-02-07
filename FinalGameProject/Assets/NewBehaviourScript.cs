using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform childObject = GameObject.Find("PlayerGun").transform;

        Transform parentObject = GameObject.Find("Main Camera").transform;

        childObject.SetParent(parentObject);
    }
}
