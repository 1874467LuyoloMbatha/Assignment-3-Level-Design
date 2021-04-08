using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class GameController : MonoBehaviour
{
    public Text drawText;
    public Text WinText;
    public Text LossText;
    public Text restartText;

    public GameObject Water;
    public GameObject Rock;
    public GameObject Fire;
    public GameObject Grass;

    public Transform spawnP; 


    public int p1Choice =0;
    [SerializeField]
    private int oppChoice;
    private bool willRestart = false;

    // Start is called before the first frame update
    void Start()
    {
        oppChoice = Random.Range(1, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (willRestart == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene(0);
        
        }
         
        if (p1Choice > 0) 
        {
            // Water
            if (p1Choice == 1)  
            {
                if (oppChoice == 1) //Water selection 
                {
                    //draw
                    Instantiate(Water, spawnP.position, Quaternion.identity);
                    drawText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 2) //Rock selection 
                {
                    //Player Wins
                    Instantiate(Rock, spawnP.position, Quaternion.identity);
                    WinText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 3)//Fire selection 
                {
                    //PLayer Wins
                    Instantiate(Fire, spawnP.position, Quaternion.identity);
                    WinText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 4) //Grass selection 
                {
                    //Player Loss
                    Instantiate(Grass, spawnP.position, Quaternion.identity);
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;
                }
            }

            //Rock 
            if (p1Choice == 2) 
            {
                if (oppChoice == 1) //Water selection 
                {
                    //PLayer Loss
                   
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 2) //Rock selection 
                {
                    //Draw
                    
                    drawText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 3)//Fire selection 
                {
                    //PLayer Wins
                   
                    WinText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 4) //Grass selection 
                {
                    //Draw (a plant Grew as a result )
                    
                    drawText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }

            }

            //Fire
            if (p1Choice == 3) 
            {
                if (oppChoice == 1) //Water selection 
                {
                    //PLayer Loss
                   
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 2) //Rock selection 
                {
                    //Player Loss
                    
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 3)//Fire selection 
                {
                    //Draw( fire works between fiters)
                   
                    drawText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 4) //Grass selection 
                {
                    //Player Win
                   
                    WinText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }

            }

            //Grass
            if (p1Choice == 4) 
            {
                if (oppChoice == 1) //Water selection 
                {
                    //Player Win
                    
                    WinText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 2) //Rock selection 
                {
                    //Draw(a flower was planted)
                    
                    drawText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;

                }
                else if (oppChoice == 3)//Fire selection 
                {
                    //PLayer Loss
                   
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;
                }
                else if (oppChoice == 4) //Grass selection 
                {
                    //Player Draw
                    
                    LossText.enabled = true;
                    restartText.enabled = true;
                    willRestart = true;
                }

            }
        } 
    }
}
