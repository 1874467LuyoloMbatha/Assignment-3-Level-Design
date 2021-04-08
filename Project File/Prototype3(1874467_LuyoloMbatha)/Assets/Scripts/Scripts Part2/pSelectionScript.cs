using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pSelectionScript : MonoBehaviour
{
    public int choiceNum; 
    public SpriteRenderer sRenderer;
    public GameController gameControls;

    private void OnMouseDown()
    {
        gameControls.p1Choice = choiceNum;
        sRenderer.color = Color.gray;
    }



}
