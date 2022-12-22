using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Transform p;
    public float pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = p.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + ((int)(p.position.z - pos));
    }
}
