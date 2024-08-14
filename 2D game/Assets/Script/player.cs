using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    float xValue;
    float yValue = 0;
    float zValue = 0;
    public float movementspeed = 5f;
    public float Jumpspeed = 5f;
    [SerializeField] Text scoretext;
    public int scorecounter;
    public GameObject Finish;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * movementspeed;
        yValue = Input.GetAxis("Vertical") * Jumpspeed;
        transform.Translate(xValue, yValue, zValue);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("you collect a coins");
            Time.timeScale = 0;
            Finish.gameObject.SetActive(true);


        }

            if (other.gameObject.tag == "Enemy")
            {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
            }
            

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "coins")
        {
            if (other.gameObject.tag == "coins")
            {
                scoretext.text = "SCORE:" + scorecounter;
                scorecounter++;
                Destroy(other.gameObject);
                Debug.Log("coin collected" + scorecounter);
                Debug.Log("you collect a coin");
            }
        }

    }












}
