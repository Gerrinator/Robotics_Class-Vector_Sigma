using UnityEngine;
using UnityEngine.UI;

public class Carmovement : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public float m_MySliderValue;
    public InputField terminalInput;
    public Text userinput;
    public bool move;
    public Rigidbody rb;
    public bool pick = false;
    public GameObject ball1;
    public GameObject mainBall;
    

    private void OnTriggerEnter(Collider other)
    {
        pick = true;
        print(true);
        
    }

    void Update()
    {

        print(Input.GetKeyDown(KeyCode.Return));
        if (GameObject.Find("UI").GetComponent<terminalmanager>().move)
        {
            print(1);

            if (userinput.text.ToUpper() == "NORTH")
            {
               rb.AddForce(transform.forward * 4000);
                //transform.Translate(0, 0, 100);
                print(1);
            }

            else if (userinput.text.ToUpper() == "SOUTH")
            {
                rb.AddForce(-transform.forward * 4000);
            }

            else if (userinput.text.ToUpper() == "EAST")
            {
                transform.Rotate(0, 5, 0);
                //rb.AddTorque(transform.up * 10);
            }

            else if (userinput.text.ToUpper() == "WEST")
            {
                transform.Rotate(0, -5, 0);
                //rb.AddTorque(-transform.up * 10);
            }
            else if (userinput.text.ToUpper() == "STOP")
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
            else if (userinput.text.ToUpper() == "PICK" && pick)
            {
                ball1.SetActive(false);
                mainBall.SetActive(true);
            }
        }
        GameObject.Find("UI").GetComponent<terminalmanager>().move = false;
        //transform.localEulerAngles = new Vector3(0, transform.localRotation.eulerAngles.y, 0);



    }
}
  
