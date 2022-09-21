using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        board = GameObject.Find("Board");
    }

    // Update is called once per frame
    void Update()
    {
        board.transform.Rotate(.05f,.005f,0f);
        print("Updating");
    }
}
