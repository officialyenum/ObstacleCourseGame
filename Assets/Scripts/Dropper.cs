using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 5.0f;
    MeshRenderer meshRenderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
