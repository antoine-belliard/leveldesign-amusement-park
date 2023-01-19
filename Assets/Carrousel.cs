using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrousel : MonoBehaviour
{
    public float vitesseRotation = 1f;
    public int directionRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        Rotation(directionRotation);
    }

    private void Rotation(int i)
    {
        transform.Rotate(new Vector3(0, i * vitesseRotation, 0));
    }
}
