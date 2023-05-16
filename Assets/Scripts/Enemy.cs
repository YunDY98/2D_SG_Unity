using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5;
    // Start is called before the first frame update

    GameObject player;

    public GameObject explosionFactory;

    void Start()
    {
       
        int randValue = UnityEngine.Random.Range(0,10);

        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player");

            dir = target.transform.position-transform.position;

            dir.Normalize();

        }
        else
        {
            dir = Vector3.down;
             
        }
 
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position += dir * speed * Time.deltaTime;
        
    }

    private void OnCollisionEnter(Collision other)
    {

       
        

        Destroy(gameObject);

        
        if (other.gameObject.tag != "wall")
        {
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;
            Destroy(other.gameObject);
        }


        GameObject smObject = GameObject.Find("ScoreManager");

        ScoreManager sm = smObject.GetComponent<ScoreManager>();

        sm.currentScore++;

        sm.currentScoreUI.text = "현재 점수 : " + sm.currentScore;

        if(sm.currentScore > sm.BestScore)
        {
            sm.BestScore = sm.currentScore;

            sm.BestScoreUI.text = "최고 점수 : " + sm.BestScore;

            PlayerPrefs.SetInt("Best Score",sm.BestScore);
        }

       

    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
