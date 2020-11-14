using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TEST : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        Debug.Log(gameManager.Score);
    }
}