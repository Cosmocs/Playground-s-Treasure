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
    
    
    


}

