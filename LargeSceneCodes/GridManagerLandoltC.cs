using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class GridManagerLandoltC : MonoBehaviour
{
    public double randomThreshold;
	public List<int> numberList = new List<int>();
	public List<int> shuffledList = new List<int>();
	public int numberOfTrials;
	public int rndIndex;
	public int range;
	public int xxx;
	public int ac;
	public int catchTrial;
    public bool S = false;
	public double DC;
	// public AudioSource beeep;
	public GameObject beepObject;
	public AudioSource audioSource;
	public AudioClip beeep;
	
	public GameObject fixationSign;
	public GameObject LandoltC;
	public GameObject screen;
	// public GameObject stimulusScreen;
	
	public IEnumerator C1;		// coroutine for temporal orgnaizing the change of the stimulus (currently, each trial is 15 seconds)
	public IEnumerator C2;		// coroutine for changing the stimulus
	
	
	// entroducing the parameters that control the experiment
	#region entroducing the parameters that control the experiment
	// Introducing Agents ==================================================================================================================
	public List<GameObject> Agents;
	
	

	// Introducing Animators ===============================================================================================================
	public Animator fAnimator1, fAnimator2, fAnimator3, fAnimator4, fAnimator5, fAnimator6, fAnimator7, fAnimator8;
	public Animator mAnimator1, mAnimator2, mAnimator3, mAnimator4, mAnimator5, mAnimator6, mAnimator7;
	
	public IEnumerator raiseHandCoroutine;
	public IEnumerator raiseBalloonCoroutine;
	// public int NumberOfTrials;
	public int NumberOfBlocks;
	public float refTime;
	public float timePass;
	public float trialDuration;
	public float agentsRHTime;		// the time point that the agents are supposed to raise their hand in each trial -----------------------
	public float agentsHUDuration;	// the duration that agents keep their hands up --------------------------------------------------------
	// RightLeftF is the parameter that if a female avatar is supposed to raise her hand, it indicates the suitable animation. right: (1~6) 
	// left: (7~9) -------------------------------------------------------------------------------------------------------------------------
	public int RightLeftF1, RightLeftF2, RightLeftF3, RightLeftF4, RightLeftF5, RightLeftF6, RightLeftF7, RightLeftF8;
	// RightLeftM is the parameter that if a male avatar is supposed to raise his hand, it indicates the suitable animation. right: (1~6) --
	// left: (7~13) ------------------------------------------------------------------------------------------------------------------------
	public int RightLeftM1, RightLeftM2, RightLeftM3, RightLeftM4, RightLeftM5, RightLeftM6, RightLeftM7, RightLeftM8;	
	
	public double LR;
	public int congruencyFactor;
	
	
	// public GameObject fixationSign;
	// public GameObject stimulusScreen;
	#endregion
	// =====================================================================================================================================
	
    void Start()
    {	
		trialDuration=8f;
		agentsRHTime=1f;
		agentsHUDuration=2f;
		// NumberOfTrials=50;
		NumberOfBlocks=2;
		
		// Starting the stimulus ===========================================================================================================C=1;
		// randomThreshold=0.5;
		
		
		
		numberOfTrials=50;
		C1=CallStimulusChange();
		StartCoroutine(C1);
		// =================================================================================================================================
		// Starting to control the experiment ==============================================================================================
		// Initiating  animators -----------------------------------------------------------------------------------------------------------
		// Female animators ----------------------------------------------------------------------------------------------------------------
		fAnimator1 = Agents[0].GetComponent<Animator>();
		fAnimator2 = Agents[1].GetComponent<Animator>();
		fAnimator3 = Agents[2].GetComponent<Animator>();
		fAnimator4 = Agents[3].GetComponent<Animator>();
		fAnimator5 = Agents[4].GetComponent<Animator>();
		fAnimator6 = Agents[5].GetComponent<Animator>();
		fAnimator7 = Agents[6].GetComponent<Animator>();
		fAnimator8 = Agents[7].GetComponent<Animator>();
        // Male animators ------------------------------------------------------------------------------------------------------------------
		mAnimator1 = Agents[8].GetComponent<Animator>();
		mAnimator2 = Agents[9].GetComponent<Animator>();
		mAnimator3 = Agents[10].GetComponent<Animator>();
		mAnimator4 = Agents[11].GetComponent<Animator>();
		mAnimator5 = Agents[12].GetComponent<Animator>();
		mAnimator6 = Agents[13].GetComponent<Animator>();
		mAnimator7 = Agents[14].GetComponent<Animator>();
		// Initializing parameters ---------------------------------------------------------------------------------------------------------
		// trialDuration=12f;
		// agentsRHTime=2f;
		// agentsHUDuration=4f;
		// NumberOfTrials=50;
		// NumberOfBlocks=2;
		// raiseHandCoroutine = RaiseHand(2.0f,NumberOfTrials);
        // StartCoroutine(raiseHandCoroutine);
		// =================================================================================================================================
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.LeftArrow))
        // {
			// numberList.Clear();
			// shuffledList.Clear();

			// for(int i = 0; i < gridSize; i++)
			// {
				// numberList.Add(i);
			// }
			// range=gridSize-1;
			// for(int j=0; j<gridSize; j++)
			// {
				// rndIndex=Random.Range(0,range);
				// xxx=numberList[rndIndex];
				// shuffledList.Add(xxx);
				// numberList.Remove(xxx);
				// range=range-1;
			// }
			
			
			
			
            // CubeClrUpdate(shuffledList);
            // print("space key was pressed");
        // }
    }
    // void RandomClr()
    // {
        // int rnd = Random.Range(1,11);		// a random integer number between 1 and 10
        // if (rnd%2==0)
        // {
            // smallSquare.GetComponent<MeshRenderer>().material = Clr1;
        // }
        // else
        // {
            // smallSquare.GetComponent<MeshRenderer>().material = Clr2;
        // }
    // } 
	// =========================================================================================================================================
	
	// =========================================================================================================================================
	// Stimulus coroutines =====================================================================================================================
	#region stimulus coroutines
	IEnumerator CallStimulusChange()
    {
		// LandoltC.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		
		// print("Asiiiii");
		for(int i = 0; i < numberOfTrials; i++)
		{
			LandoltC.transform.localScale = new Vector3(0.5f, 0.5f, 0.001f);
			LandoltC.transform.Rotate(0.0f, 0.0f, Random.Range(0,4)*90.0f, Space.Self);
			fixationSign.SetActive(true);
			// stimulusScreen.SetActive(false);
			yield return new WaitForSeconds(2f);
			fixationSign.SetActive(false);
			screen.SetActive(true);
			LandoltC.SetActive(true);
			raiseHandCoroutine = RaiseHand(i);
			StartCoroutine(raiseHandCoroutine);
			yield return new WaitForSeconds(trialDuration);
			LandoltC.SetActive(false);
			screen.SetActive(false);
		}
    } 
	#endregion
	
	// ExperimentControl coroutines ============================================================================================================
	#region experimentControl coroutines
	// public IEnumerator RaiseHand(float waitTime, int NumberTrials)
	public IEnumerator RaiseHand(int tn)
    {
		// for(int i = 0; i < NumberTrials; i++)
		// {
			refTime=Time.time;
			// Selecting animators for each female and male avatar =============================================================================
			congruencyFactor=Random.Range(1,3);	// 50% of the trials are congruent (congruencyFactor=1) and 50% incongruent (congruencyFactor=2)
			if (congruencyFactor==1)
			{
				LR=DC;
			}
			else
			{
				LR=(DC-1.5)*-1+1.5;
			}
			print("DC+threshold"+DC+" : "+randomThreshold+"  :  "+congruencyFactor+"  :  "+LR);
				
			// LR=Random.Range(1,3);
			// LR=2;
			// print("LR:"+LR);
			if (LR==1)	// Agents are supposed to raise their left hand ------------------------------------------------------------------------
			{
				RightLeftF1=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
				RightLeftF2=Random.Range(1,7);
				RightLeftF3=Random.Range(1,7);
				RightLeftF4=Random.Range(1,7);
				RightLeftF5=Random.Range(1,7);
				RightLeftF6=Random.Range(1,7);
				RightLeftF7=Random.Range(1,7);
				RightLeftF8=Random.Range(1,7);
				RightLeftM1=Random.Range(1,7);		// choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
				RightLeftM2=Random.Range(1,7);
				RightLeftM3=Random.Range(1,7);
				RightLeftM4=Random.Range(1,7);
				RightLeftM5=Random.Range(1,7);
				RightLeftM6=Random.Range(1,7);
				RightLeftM7=Random.Range(1,7);
			}
			else if (LR==2)
			{
				RightLeftF1=Random.Range(7,9);	    // choose a random number between 7 and 9 (we have 3 animations for females raising right hand)
				RightLeftF2=Random.Range(7,9);
				RightLeftF3=Random.Range(7,9);
				RightLeftF4=Random.Range(7,9);
				RightLeftF5=Random.Range(7,9);
				RightLeftF6=Random.Range(7,9);
				RightLeftF7=Random.Range(7,9);
				RightLeftF8=Random.Range(7,9);
				RightLeftM1=Random.Range(7,14);		 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
				RightLeftM2=Random.Range(7,14);
				RightLeftM3=Random.Range(7,14);
				RightLeftM4=Random.Range(7,14);
				RightLeftM5=Random.Range(7,14);
				RightLeftM6=Random.Range(7,14);
				RightLeftM7=Random.Range(7,14);
			}
			print(RightLeftF1+" , "+RightLeftF2+" , "+RightLeftF3+" , "+RightLeftF4+" , "+RightLeftF5+" , "+RightLeftF6+" , "+RightLeftF7+" , "+RightLeftF8+" , "+RightLeftM1+" , "+RightLeftM2+" , "+RightLeftM3+" , "+RightLeftM4+" , "+RightLeftM5+" , "+RightLeftM6+" , "+RightLeftM7);
			// Starting	idle position of all the avatars ---------------------------------------------------------------------------------------
			#region  StartIdle			
			// "F" for female idles ------------------------------------------------------------------------------------------------------------
			// Warning: for each avatar the value of "F", "FLR", "FI", and "RestartF" must be the same *****************************************
			fAnimator1.SetInteger("F", RightLeftF1);
			fAnimator2.SetInteger("F", RightLeftF2);
			fAnimator3.SetInteger("F", RightLeftF3);
			fAnimator4.SetInteger("F", RightLeftF4);
			fAnimator5.SetInteger("F", RightLeftF5);
			fAnimator6.SetInteger("F", RightLeftF6);
			fAnimator7.SetInteger("F", RightLeftF7);
			fAnimator8.SetInteger("F", RightLeftF8);
			// "M" for male idles --------------------------------------------------------------------------------------------------------------
			// Warning: for each avatar the value of "M", "MLR", "MI", and "RestartM" must be the same *****************************************
			mAnimator1.SetInteger("M", RightLeftM1);
			mAnimator2.SetInteger("M", RightLeftM2);
			mAnimator3.SetInteger("M", RightLeftM3);
			mAnimator4.SetInteger("M", RightLeftM4);
			mAnimator5.SetInteger("M", RightLeftM5);
			mAnimator6.SetInteger("M", RightLeftM6);
			mAnimator7.SetInteger("M", RightLeftM7);
			#endregion
			// =================================================================================================================================
			yield return new WaitForSeconds(agentsRHTime);		// wait for "agentsRHTime", then the agents raise their hand -------------------
			#region RaiseHand
			// Female avatars raise hand. "FLR" for female raise hand; FLR1~FLR6: left hand; FLR7~FLR9: right hand -----------------------------
			fAnimator1.SetInteger("FLR", RightLeftF1);
			fAnimator2.SetInteger("FLR", RightLeftF2);
			fAnimator3.SetInteger("FLR", RightLeftF3);
			fAnimator4.SetInteger("FLR", RightLeftF4);
			fAnimator5.SetInteger("FLR", RightLeftF5);
			fAnimator6.SetInteger("FLR", RightLeftF6);
			fAnimator7.SetInteger("FLR", RightLeftF7);
			fAnimator8.SetInteger("FLR", RightLeftF8);
			// Male avatars raise hand. "MLR" for male raise hand; MLR1~MLR6: left hand; MLR7~MLR13: right hand --------------------------------
			mAnimator1.SetInteger("MLR", RightLeftM1);
			mAnimator2.SetInteger("MLR", RightLeftM2);
			mAnimator3.SetInteger("MLR", RightLeftM3);
			mAnimator4.SetInteger("MLR", RightLeftM4);
			mAnimator5.SetInteger("MLR", RightLeftM5);
			mAnimator6.SetInteger("MLR", RightLeftM6);
			mAnimator7.SetInteger("MLR", RightLeftM7);
			#endregion
			yield return new WaitForSeconds(1f);
			beepObject.SetActive(true);
			audioSource.PlayOneShot(beeep, 1f);
			// flagHead.transform.localRotation = Quaternion.Euler(180f, 0f, 180f);
			// flagHead.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			// =================================================================================================================================
			yield return new WaitForSeconds(agentsHUDuration);	// the duration that agents keep their hands up --------------------------------
			#region LowerHand
			// Female avatars lower their hands and go back to idle phase. "FI" for female lower hand; FI1~FI6: left hand; FI7~FI9: right hand -
			fAnimator1.SetInteger("FI", RightLeftF1);
			fAnimator2.SetInteger("FI", RightLeftF2);
			fAnimator3.SetInteger("FI", RightLeftF3);
			fAnimator4.SetInteger("FI", RightLeftF4);
			fAnimator5.SetInteger("FI", RightLeftF5);
			fAnimator6.SetInteger("FI", RightLeftF6);
			fAnimator7.SetInteger("FI", RightLeftF7);
			fAnimator8.SetInteger("FI", RightLeftF8);
			// =================================================================================================================================
			// Male avatars lower their hands and go back to idle phase. "MI" for male lower hand; MI1~MI6: left hand; MI7~M13: right hand -----
			mAnimator1.SetInteger("MI", RightLeftM1);
			mAnimator2.SetInteger("MI", RightLeftM2);
			mAnimator3.SetInteger("MI", RightLeftM3);
			mAnimator4.SetInteger("MI", RightLeftM4);
			mAnimator5.SetInteger("MI", RightLeftM5);
			mAnimator6.SetInteger("MI", RightLeftM6);
			mAnimator7.SetInteger("MI", RightLeftM7);
			#endregion
			// =================================================================================================================================
			timePass=Time.time-refTime;
			yield return new WaitForSeconds((trialDuration-timePass));
			#region OriginalIdle
			// *********************************************************************************************************************************
			// At the end of each trial we need to reset all the avatars to their first pose, to get ready for the next trial ------------------
			// "RestartF" to reset female avatars; RestartF1~RestartF9 -------------------------------------------------------------------------
			fAnimator1.SetInteger("RestartF", RightLeftF1);
			fAnimator2.SetInteger("RestartF", RightLeftF2);
			fAnimator3.SetInteger("RestartF", RightLeftF3);
			fAnimator4.SetInteger("RestartF", RightLeftF4);
			fAnimator5.SetInteger("RestartF", RightLeftF5);
			fAnimator6.SetInteger("RestartF", RightLeftF6);
			fAnimator7.SetInteger("RestartF", RightLeftF7);
			fAnimator8.SetInteger("RestartF", RightLeftF8);
			// "RestartM" to reset female avatars; RestartM1~RestartM13 ------------------------------------------------------------------------
			mAnimator1.SetInteger("RestartM", RightLeftM1);
			mAnimator2.SetInteger("RestartM", RightLeftM2);
			mAnimator3.SetInteger("RestartM", RightLeftM3);
			mAnimator4.SetInteger("RestartM", RightLeftM4);
			mAnimator5.SetInteger("RestartM", RightLeftM5);
			mAnimator6.SetInteger("RestartM", RightLeftM6);
			mAnimator7.SetInteger("RestartM", RightLeftM7);
			// PlayerRightHand.transform.TransformPoint(PlayerRightHand.transform.position )=new Vector3(3.86f, 3.96f, -11.6f);
			// PlayerRightHand.localRotation=new Vector3(3.86f, 3.96f, -11.6f);
			#endregion
			#region  ResetAnimatorParameters
			// StopCoroutine(C2);
			// *********************************************************************************************************************************
			yield return new WaitForSeconds(Time.deltaTime);	// wait for a glance and then reset all the animators, so that we can start over 
			// on the next trial ---------------------------------------------------------------------------------------------------------------
			// *********************************************************************************************************************************
			fAnimator1.SetInteger("F", 0);
			fAnimator2.SetInteger("F", 0);
			fAnimator3.SetInteger("F", 0);
			fAnimator4.SetInteger("F", 0);
			fAnimator5.SetInteger("F", 0);
			fAnimator6.SetInteger("F", 0);
			fAnimator7.SetInteger("F", 0);
			fAnimator8.SetInteger("F", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("M", 0);
			mAnimator2.SetInteger("M", 0);
			mAnimator3.SetInteger("M", 0);
			mAnimator4.SetInteger("M", 0);
			mAnimator5.SetInteger("M", 0);
			mAnimator6.SetInteger("M", 0);
			mAnimator7.SetInteger("M", 0);
			// =================================================================================================================================
			fAnimator1.SetInteger("FLR", 0);
			fAnimator2.SetInteger("FLR", 0);
			fAnimator3.SetInteger("FLR", 0);
			fAnimator4.SetInteger("FLR", 0);
			fAnimator5.SetInteger("FLR", 0);
			fAnimator6.SetInteger("FLR", 0);
			fAnimator7.SetInteger("FLR", 0);
			fAnimator8.SetInteger("FLR", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("MLR", 0);
			mAnimator2.SetInteger("MLR", 0);
			mAnimator3.SetInteger("MLR", 0);
			mAnimator4.SetInteger("MLR", 0);
			mAnimator5.SetInteger("MLR", 0);
			mAnimator6.SetInteger("MLR", 0);
			mAnimator7.SetInteger("MLR", 0);
			// =================================================================================================================================
			fAnimator1.SetInteger("FI", 0);
			fAnimator2.SetInteger("FI", 0);
			fAnimator3.SetInteger("FI", 0);
			fAnimator4.SetInteger("FI", 0);
			fAnimator5.SetInteger("FI", 0);
			fAnimator6.SetInteger("FI", 0);
			fAnimator7.SetInteger("FI", 0);
			fAnimator8.SetInteger("FI", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("MI", 0);
			mAnimator2.SetInteger("MI", 0);
			mAnimator3.SetInteger("MI", 0);
			mAnimator4.SetInteger("MI", 0);
			mAnimator5.SetInteger("MI", 0);
			mAnimator6.SetInteger("MI", 0);
			mAnimator7.SetInteger("MI", 0);
			// =================================================================================================================================
			fAnimator1.SetInteger("RestartF", 0);
			fAnimator2.SetInteger("RestartF", 0);
			fAnimator3.SetInteger("RestartF", 0);
			fAnimator4.SetInteger("RestartF", 0);
			fAnimator5.SetInteger("RestartF", 0);
			fAnimator6.SetInteger("RestartF", 0);
			fAnimator7.SetInteger("RestartF", 0);
			fAnimator8.SetInteger("RestartF", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("RestartM", 0);
			mAnimator2.SetInteger("RestartM", 0);
			mAnimator3.SetInteger("RestartM", 0);
			mAnimator4.SetInteger("RestartM", 0);
			mAnimator5.SetInteger("RestartM", 0);
			mAnimator6.SetInteger("RestartM", 0);
			mAnimator7.SetInteger("RestartM", 0);
			#endregion
		// }
    }
	#endregion
	// ExperimentControl coroutines ============================================================================================================
}
