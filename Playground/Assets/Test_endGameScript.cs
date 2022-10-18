using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test_endGameScript : MonoBehaviour
{
    private GameObject[] Elim1;
    private GameObject[] Elim2;
    private GameObject[] Elim3;
    private GameObject[] Elim4;
    private GameObject[] Elim5;
    private int ElimTotal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if there is anything in any list
        Elim1 = GameObject.FindGameObjectsWithTag("Round1");
        Elim2 = GameObject.FindGameObjectsWithTag("Round2");
        Elim3 = GameObject.FindGameObjectsWithTag("Round3");
        Elim4 = GameObject.FindGameObjectsWithTag("Round4");
        Elim5 = GameObject.FindGameObjectsWithTag("Round5");

        ElimTotal = Elim1.Length + Elim2.Length + Elim3.Length + Elim4.Length + Elim5.Length;

        if(ElimTotal == 0)
        {
            SceneManager.LoadScene("End");
        }


    }
}
