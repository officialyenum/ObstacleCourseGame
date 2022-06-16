using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
   [SerializeField] int score = 0;

   void OnCollisionEnter(Collision collision)
   {
        Debug.Log("Collision detected");
        if (collision.gameObject.tag != "Hit")
        {
            Debug.Log("Score Recorded: "+score);
            score++;
        }
   }
}
