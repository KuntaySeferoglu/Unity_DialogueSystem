using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]

public class NPC : MonoBehaviour
{

    private DialogueSystem dialogueSystem;

    public bool isTalkable;

    public string Name;
    [TextArea(5,10)]

    public string[] sentences;



    
    void Start()
    {
       isTalkable = false;
    }

    


    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        //Debug.Log ("cOLLisi0n");
        isTalkable = true;
        DialogueSystem.instance.EnterRangeOfNPC();
        }
    }

    void Update()
    {
            if (Input.GetKeyDown(KeyCode.E) && isTalkable)
            {
            //Debug.Log ("is talking");
            DialogueSystem.instance.Names = Name;
            DialogueSystem.instance.dialogueLines = sentences;
            DialogueSystem.instance.NPCName();
            Debug.Log (isTalkable);
        }
    }

public void OnTriggerExit()
{
    isTalkable = false;
    DialogueSystem.instance.OutOfRange();
    //Debug.Log (isTalkable);
}


}
