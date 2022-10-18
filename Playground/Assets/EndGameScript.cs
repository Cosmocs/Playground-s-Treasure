using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class EndGameScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject[] gone;
    public GameObject[] Elim;
    public bool Erased()
    {

        //checks to see if all squares are gone
        //look for objects in array
        for (int i = 0; i < gone.Length; i++)
        {
            //check if object is in scene 
            if (gone[i] != null)
            {
                return false;


            }

        }

        return true;


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "worm")
        {
            Elim = GameObject.FindGameObjectsWithTag("Round5");
            foreach (GameObject elim in Elim) //destroy each varible in Elim
            {
                Destroy(elim);
            }

            Destroy(this.gameObject);


            if (Erased())
            {
                StartCoroutine(TheEnd());
                SceneManager.LoadScene("End");

            }



        }


    }*/



    IEnumerator TheEnd()
    {


        yield return new WaitForSeconds(6);


    }





}










