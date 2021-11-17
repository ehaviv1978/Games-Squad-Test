using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayRedCode : MonoBehaviour
{
    // Start is called before the first frame update

    int lenghtOfCode;
    int lenghtForStars;
    public string _Code;
    [SerializeField] Text textOfRedCode;

    void Start()
    {
        GetRandomCode("12345");
        lenghtForStars = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GetRandomCode(string theCode)
    {
        //DisplayCodeOnScrean(theCode);
        lenghtOfCode = theCode.Length;
        for(int i = 0 ; i<lenghtOfCode ; i++)
        {
            _Code = _Code + " " + "_";
        }
        textOfRedCode.text = _Code;
    }
    string FakeRandomCodeForTest()
    {
        return "1234";
    }
    public void ChangeToStars()
    {
        _Code = "";
        lenghtForStars++;
        PrintChars(lenghtForStars,"*");
        PrintChars(lenghtOfCode - lenghtForStars,"_");
        textOfRedCode.text = _Code;
    }
    public void PrintChars(int lenght, string type)
    {
        for (int i = 0; i < lenght; i++)
        {
            _Code = _Code + " " + type;
        }
    }
    public bool IsDone()
    {
        if (lenghtForStars == lenghtOfCode)
            return true;
        else
            return false;
    }
    public void DisplayCodeOnScrean(string codeToDisplay)
    {
        foreach (int i in codeToDisplay)
        Debug.Log(codeToDisplay.Substring(0,i));
    }
}
