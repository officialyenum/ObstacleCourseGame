using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Printf(350.05f);
        PrintS("Start script loaded");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintS(string data)
    {
        Debug.Log(data);
    }

    void Printf(float data)
    {
        Debug.Log(data);
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
