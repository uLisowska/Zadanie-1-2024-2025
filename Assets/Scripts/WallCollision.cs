using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public GameObject player;
    private int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        player.GetComponent<PlayerMovement>().points += 1;
        points = player.GetComponent<PlayerMovement>().points;

        this.gameObject.GetComponent<Renderer>().material.color = Color.red;

        Debug.Log("Masz "+points+" punkty");
    }
}
