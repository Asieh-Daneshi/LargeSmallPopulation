using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class moveBalloon : MonoBehaviour
{

	public GameObject Balloon;
	public GameObject handR;
	public Vector3 handLoc;

	public IEnumerator raiseBalloonCoroutine;

	
    // Start is called before the first frame update
    void Start()
    {
		transform.position=handR.transform.position+new Vector3(0f,1.04f*0.35f,0f);
		raiseBalloonCoroutine = RaiseBalloon(Balloon,handR);
		StartCoroutine(raiseBalloonCoroutine);
		// 
    }

	public IEnumerator RaiseBalloon(GameObject myBalloon, GameObject AgentHand)
    {
		// AgentHand.transform.position;
		handLoc=AgentHand.transform.position;
		
		 while (true)
		 {
			 yield return new WaitForSeconds(Time.deltaTime);
			transform.Translate(AgentHand.transform.position-handLoc);
			
			print("posssssssssssssssssssssssssssss" +(AgentHand.transform.position-handLoc));
			handLoc=AgentHand.transform.position;
		 }
		// yield return null;
	}
}
