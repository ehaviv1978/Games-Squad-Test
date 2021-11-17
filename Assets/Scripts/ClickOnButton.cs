using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ClickOnButton : MonoBehaviour
{
    public string srtingThatHadBeenClicked;
    public DisplayRedCode redScript;
    public bool finishChek;
    [SerializeField] GameObject finishImage;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void IfClicked()
    {
        //string name = gameObject.name.ToString();
        string name = EventSystem.current.currentSelectedGameObject.name.ToString();
        char lastLatter = name[name.Length - 1];
        Debug.Log("strlastLattering lastlatter= "+ lastLatter);
        CollectClicks(lastLatter.ToString());
        ChangeRedCode();
    }
    void CollectClicks(string clickedString)
    {
        srtingThatHadBeenClicked += clickedString;
        Debug.Log(srtingThatHadBeenClicked);
    }
    public void ChangeRedCode()
    {
        redScript.ChangeToStars();
        if (redScript.IsDone())
            DoneGame();
    }
    public bool DoneGame()
    {
        Debug.Log("Finito");
        finishImage.SetActive(true);
        return true;
    }
}
