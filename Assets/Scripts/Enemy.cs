using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform M_Player;
    public GameObject dieScreen;
    public AudioSource dieSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = M_Player.position;
    }

    void OnTriggerEnter( Collider other)
    {
        if(other.name == "Player")
        {
            //Destroy(other.gameObject);
            Time.timeScale = 0;
            dieScreen.SetActive(true);
            dieSound.Play();
        }
    }
}
