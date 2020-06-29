
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using UnityEngine;

//Custom 8
public partial class Wit3D : MonoBehaviour {

  public Text myHandleTextBox;
  private bool actionFound = false;
    Animator anim;

    void Handle (string jsonString) {
    
    if (jsonString != null) {

      RootObject theAction = new RootObject ();
      Newtonsoft.Json.JsonConvert.PopulateObject (jsonString, theAction);

            if (theAction.entities.roll != null)
            {
                foreach (Roll aPart in theAction.entities.roll)
                {
                    Debug.Log(aPart.value + " this is value");
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
                }
            }
            if (theAction.entities.walk != null)
            {
                foreach (Walk aPart in theAction.entities.walk)
                {
                    Debug.Log(aPart.value + " this is value");
                    myHandleTextBox.text = aPart.value + " 1";
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value+"  2";
                    actionFound = true;
                }
            }
            if (theAction.entities.run != null) {
        foreach (Run aPart in theAction.entities.run) {
          Debug.Log (aPart.value);
          triggerAnimation(aPart.value);
          myHandleTextBox.text = aPart.value;
          actionFound = true;
        }
      }
            if (theAction.entities.stop != null)
            {
                foreach (Stop aPart in theAction.entities.stop)
                {
                    Debug.Log(aPart.value);
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
                }
            }
            if (theAction.entities.jog != null)
            {
                foreach (Jog aPart in theAction.entities.jog)
                {
                    Debug.Log(aPart.value);
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
                }
            }
            if (theAction.entities.jump != null)
            {
                foreach (Jump aPart in theAction.entities.jump)
                {
                    Debug.Log(aPart.value);
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
                }
            }
            if (theAction.entities.dance != null)
            {
                foreach (Dance aPart in theAction.entities.dance)
                {
                    Debug.Log(aPart.value);
                    triggerAnimation(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
                }
            }
            if (!actionFound) {
        myHandleTextBox.text = "Request unknown, please ask a different way.";
      } else {
        actionFound = false;
      }

     }//END OF IF

   }
    public void triggerAnimation(string action)
    {
        Debug.Log(action);
        myHandleTextBox.text = "object NOT detected";
        anim = GameObject.Find("BlueSuitFree01").GetComponent<Animator>();
        myHandleTextBox.text = "object detected";
        //anim = GameObject.Find("/DefaultAvatar").GetComponent<Animator>();

        Debug.Log("qwertty");
        Debug.Log(anim);
        
        anim.SetTrigger(action);
        Debug.Log("sami sajmi vsfvfsfffffffffffffff");
    }//END OF HANDLE VOID

}//END OF CLASS
  

//Custom 9
public class Walk {
  public bool suggested { get; set; }
  public double confidence { get; set; }
  public string value { get; set; }
  public string type { get; set; }
}
public class Run {
  public bool suggested { get; set; }
  public double confidence { get; set; }
  public string value { get; set; }
  public string type { get; set; }
}
public class Jump
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}
public class Stop
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}
public class Jog
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}
public class Dance
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}
public class Roll
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}
public class Entities {
  public List<Walk> walk { get; set; }
  public List<Run> run { get; set; }
    public List<Jump> jump { get; set; }
    public List<Jog> jog { get; set; }
    public List<Stop> stop { get; set; }
    public List<Dance> dance { get; set; }
    public List<Roll> roll { get; set; }
}

public class RootObject {
  public string _text { get; set; }
  public Entities entities { get; set; }
  public string msg_id { get; set; }
}
