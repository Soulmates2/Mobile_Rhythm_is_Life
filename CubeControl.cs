using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    GameObject cube;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale += new Vector3(4, 1, 0);
        cube.GetComponent<Renderer>().material.color = Color.blue;
        cube.transform.position = new Vector3(0, -15, 55);
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
    }
}