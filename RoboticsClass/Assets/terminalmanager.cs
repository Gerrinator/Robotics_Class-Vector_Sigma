using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class terminalmanager : MonoBehaviour
{
    public GameObject directoryline;
    public GameObject responseline;
    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msglIST;
    public Text userinput;
    public Text responsetext;
    public bool move = false;

    private void OnGUI()
    {
        if (terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            move = true;
            userinput.text = terminalInput.text;
            if(userinput.text.ToUpper() == "NORTH")
            {
                responsetext.text = "Moving North";
            }

            else if (userinput.text.ToUpper() == "SOUTH")
            {
                responsetext.text = "Moving South";
            }

            else if (userinput.text.ToUpper() == "EAST")
            {
                responsetext.text = "Moving East";
            }

            else if (userinput.text.ToUpper() == "WEST")
            {
                responsetext.text = "Moving West";
            }

            else if (userinput.text.ToUpper() == "STOP")
            {
                responsetext.text = "robot stopped";
            }

            else if (userinput.text.ToUpper() == "PICK")
            {
                responsetext.text = "trying to pick ball...";
            }



            else
            {
                responsetext.text = "Incorrect Command";
            }


            

            //string userInput = terminalInput.text;
            ClearInputField();


            //AddDirectoryLine(userInput);

        }


    }

    void AddDirectoryLine(string userInput)
    {
        Vector2 msgListSize = msglIST.GetComponent<RectTransform>().sizeDelta;
        msglIST.GetComponent<RectTransform>().sizeDelta = new Vector2(msgListSize.x, msgListSize.y + 35.0f);
        GameObject msg = Instantiate(directoryline, msglIST.transform);
        msg.transform.SetSiblingIndex(msglIST.transform.childCount - 1);
        msg.GetComponentInChildren<Text>().text = userInput;


    }
    void ClearInputField()
    {
        terminalInput.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
