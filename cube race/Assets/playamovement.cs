using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playamovement : MonoBehaviour
{
    public Rigidbody rb;
    public Material wm;
    public float speed;
    public float rs;
    public float us;
    public bool jump;
    public bool sleep = false;
    public Color wmct = new Color(255, 255, 255, 0);
    public Color wmc = new Color(255, 255, 255, 255);
    // Start is called before the first frame update
    void Start()
    {
        wm.color = wmct;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        
        if (sleep == false)
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
            //Debug.Log("working");
            if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.AddForce(-1 * rs, 0, 0);
                }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(rs, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow) && jump)
            {
                rb.AddForce(0, us, 0);
                jump = false;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0, -(us/5), 0);
            }
        }
        if (Input.GetKey(KeyCode.Space) || transform.position.y<-3)
        {
            restart_scene();
        }
        if (transform.position.z> 492.58)
        {
            wm.color = wmc;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "enemy")
        {
            sleep = true;
            Debug.Log("sleep");
        }
        else if (collision.collider.tag == "floor")
        {
            sleep = false;
            jump = true;
            Debug.Log("no sleep");
        }
    }
    public void restart_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
