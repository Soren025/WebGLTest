using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public object HttpUtility { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        if (Application.absoluteURL.EndsWith("red"))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (Application.absoluteURL.EndsWith("blue"))
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if (Application.absoluteURL.EndsWith("green"))
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(x, y) * Time.deltaTime * 5);

        transform.position = Vector3.ClampMagnitude(transform.position, 4);
    }
}
