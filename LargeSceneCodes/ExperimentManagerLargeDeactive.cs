using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
// using scripts.Jatos;
using Random=UnityEngine.Random;
using System.Linq;

public class ExperimentManagerLargeDeactive : MonoBehaviour
{
	// google form data collection :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	[SerializeField]
	public string BASE_URL="https://docs.google.com/forms/u/0/d/e/1FAIpQLSezZyRRFzd8c6idOIBzqDD77i4Rcx_2mGOkexh-85yqSBbJfA/formResponse"; // URL of the google form 

	// address contains addresses to each question field in the form ...............................................................
	// private string[] address = new string[] {"entry.1999917522","entry.837571715","entry.176587697","entry.1787402673","entry.645230853","entry.1158964578","entry.1888521446","entry.1785148826","entry.1394827684","entry.1357288164","entry.1827920477","entry.302692730","entry.1456553159","entry.2052447624","entry.599168045","entry.467797710","entry.1865651058","entry.1675183321","entry.859251791","entry.696583781","entry.1284083772","entry.617047882","entry.1602804280","entry.951861515","entry.842002701","entry.284653438","entry.155309467","entry.1630217206","entry.2028926723","entry.2024761984","entry.661151237","entry.1178273108","entry.1329495400","entry.1139834709","entry.861050361","entry.1363107039","entry.1248845983","entry.1443573082","entry.1616533018","entry.1215157525","entry.1632204790","entry.1626818057","entry.783133901","entry.1113319548","entry.1912182312","entry.63626121","entry.1439549708","entry.1292592469","entry.881909567","entry.268394484","entry.175889029","entry.219129905","entry.1178279973","entry.1193313861","entry.269001236","entry.498042810","entry.1964346856","entry.1230472364","entry.490942525","entry.638722599","entry.523715843","entry.671168823","entry.2035768229","entry.1663006433","entry.312288105","entry.1890441255","entry.1034032106","entry.608746679","entry.1585984491","entry.1712233666","entry.1402477302","entry.249327086","entry.1023571914","entry.1795777164","entry.1770767467","entry.1479324078","entry.1112170689","entry.1932108477","entry.820178464","entry.350787996","entry.1409061982","entry.667413866","entry.1487611046","entry.2040376192","entry.1040871654","entry.1861826531","entry.2132736982","entry.871385182","entry.1049104815","entry.431728064","entry.1590663591","entry.1946225607","entry.1574780830","entry.198231677","entry.1159930255","entry.1975336631","entry.1692964721","entry.2143890128","entry.925973439","entry.1931616011","entry.2124937293","entry.1114139210","entry.863128398","entry.707546952","entry.1766919119","entry.2018322132","entry.52513326","entry.858640675","entry.1199244880","entry.1288493091","entry.1393610336","entry.738493828","entry.473216645","entry.45989188","entry.193829703","entry.921152083","entry.692028319","entry.1018916758","entry.234519000","entry.1143670093","entry.1005746394","entry.1943693350","entry.668704061","entry.724720495","entry.1951565246","entry.1167283984","entry.682597900","entry.879788461","entry.1708913631","entry.652439124","entry.1406295844","entry.190529595","entry.2059805969","entry.1658603072","entry.1520181620","entry.7386447","entry.26076756","entry.2114767445","entry.1823182001","entry.850868066","entry.1901665168","entry.1697756291","entry.1963042950","entry.909711823","entry.1449930848","entry.1527769768","entry.688371065","entry.298988769","entry.830912850","entry.530693406","entry.860295148","entry.1495030444","entry.1123811225","entry.1373176950","entry.123288071","entry.724891871","entry.892197776","entry.205387242","entry.693108893","entry.1918189599","entry.999938520","entry.2130008863","entry.150105084","entry.700995234","entry.1981750551","entry.1049208918","entry.864017416","entry.2125446824","entry.18139483","entry.624310178","entry.1628290583","entry.1335338178","entry.2028107917","entry.1740575523","entry.2037492634","entry.1612810593","entry.301963123","entry.39644151","entry.175358090","entry.849024451","entry.207447425","entry.169608679","entry.173216614","entry.492838079","entry.436746779","entry.628256499","entry.432592843","entry.741206404","entry.1718454535","entry.1220394426","entry.1005362392","entry.219770821","entry.1924154443","entry.1294786518","entry.856744231","entry.22946595","entry.551510588","entry.228782302","entry.627863738","entry.1710424788","entry.2019800477","entry.1830246119","entry.661345846","entry.207288098","entry.1108544641","entry.1399526167","entry.1201478875","entry.1053231874","entry.970451269","entry.591870739","entry.493350169","entry.1204826234","entry.742915224","entry.574111814","entry.134518324","entry.1305189404","entry.1343014516","entry.840913051","entry.1836465148","entry.215031337","entry.1718293256","entry.58152714","entry.1673723508","entry.1638424792","entry.269872164","entry.386407090","entry.2089528528","entry.891188137","entry.810174557","entry.1823357824","entry.1094158169","entry.798680036","entry.494617990","entry.227182486","entry.879941624","entry.1772489561","entry.86539778","entry.1860853812","entry.111239946","entry.709073174","entry.1819740215","entry.1961167804","entry.80842377","entry.1587375263","entry.1024229239","entry.2108942993","entry.1986760620","entry.1859066258","entry.666315091","entry.64169819","entry.1627287267","entry.3183685","entry.1364408679","entry.671919623","entry.221593198","entry.775937613","entry.485068460","entry.556643711","entry.983891918","entry.573529892","entry.1825441849","entry.333755488","entry.324752715","entry.891780518","entry.1966089024","entry.1765708170","entry.1411544531","entry.1857636600","entry.452534403","entry.1341923408","entry.29053707","entry.678495468","entry.116353755","entry.928882619","entry.1981204197","entry.483223132","entry.1903255055","entry.2038639014","entry.1263105767","entry.288556374","entry.662336667","entry.401616238","entry.850733817","entry.1084684316","entry.1730699912","entry.835069292","entry.170024417","entry.1369225654","entry.2062914969","entry.1177731949","entry.1653990885","entry.1032390956","entry.1935328693","entry.984311859","entry.129768363","entry.995220679","entry.1661282944","entry.120038658","entry.1986476869","entry.1970950147","entry.1271859807","entry.363707897","entry.950083611","entry.1067329322","entry.1248503470","entry.265477592","entry.1321942044","entry.2047496503","entry.316618822","entry.811908953"};
	private string[] address = new string[] {"entry.1999917522","entry.837571715","entry.176587697","entry.1787402673","entry.645230853","entry.1158964578","entry.1888521446","entry.1785148826","entry.1394827684","entry.1357288164","entry.1827920477","entry.302692730","entry.1456553159","entry.2052447624","entry.599168045","entry.467797710","entry.1865651058","entry.1675183321","entry.859251791","entry.696583781","entry.1284083772","entry.617047882","entry.1602804280","entry.951861515","entry.842002701","entry.284653438","entry.155309467","entry.1630217206","entry.2028926723","entry.2024761984","entry.661151237","entry.1178273108","entry.1329495400","entry.1139834709","entry.861050361","entry.1363107039","entry.1248845983","entry.1443573082","entry.1616533018","entry.1215157525","entry.1632204790","entry.1626818057","entry.783133901","entry.1113319548","entry.1912182312","entry.63626121","entry.1439549708","entry.1292592469","entry.881909567","entry.268394484","entry.175889029","entry.219129905","entry.1178279973","entry.1193313861","entry.269001236","entry.498042810","entry.1964346856","entry.1230472364","entry.490942525","entry.638722599","entry.523715843","entry.671168823","entry.2035768229","entry.1663006433","entry.312288105","entry.1890441255","entry.1034032106","entry.608746679","entry.1585984491","entry.1712233666","entry.1402477302","entry.249327086","entry.1023571914","entry.1795777164","entry.1770767467","entry.1479324078","entry.1112170689","entry.1932108477","entry.820178464","entry.350787996","entry.1409061982","entry.667413866","entry.1487611046","entry.2040376192","entry.1040871654","entry.1861826531","entry.2132736982","entry.871385182","entry.1049104815","entry.431728064","entry.1590663591","entry.1946225607","entry.1574780830","entry.198231677","entry.1159930255","entry.1975336631","entry.1692964721","entry.2143890128","entry.925973439","entry.1931616011","entry.2124937293","entry.1114139210","entry.863128398","entry.707546952","entry.1766919119","entry.2018322132","entry.52513326","entry.858640675","entry.1199244880","entry.1288493091","entry.1393610336","entry.738493828","entry.473216645","entry.45989188","entry.193829703","entry.921152083","entry.692028319","entry.1018916758","entry.234519000","entry.1143670093","entry.1005746394","entry.1943693350","entry.668704061","entry.724720495","entry.1951565246","entry.1167283984","entry.682597900","entry.879788461","entry.1708913631","entry.652439124","entry.1406295844","entry.190529595","entry.2059805969","entry.1658603072","entry.1520181620","entry.7386447","entry.26076756","entry.2114767445","entry.1823182001","entry.850868066","entry.1901665168","entry.1697756291","entry.1963042950","entry.909711823","entry.1449930848","entry.1527769768","entry.688371065","entry.298988769","entry.830912850","entry.530693406","entry.860295148","entry.1495030444","entry.1123811225","entry.1373176950","entry.123288071","entry.724891871","entry.892197776","entry.205387242","entry.693108893","entry.1918189599","entry.999938520","entry.2130008863","entry.150105084","entry.700995234","entry.1981750551","entry.1049208918","entry.864017416","entry.2125446824","entry.18139483","entry.624310178","entry.1628290583","entry.1335338178","entry.2028107917","entry.1740575523","entry.2037492634","entry.1612810593","entry.301963123","entry.39644151","entry.175358090","entry.849024451","entry.207447425","entry.169608679","entry.173216614","entry.492838079","entry.436746779","entry.628256499","entry.432592843","entry.741206404","entry.1718454535","entry.1220394426","entry.1005362392","entry.219770821","entry.1924154443","entry.1294786518","entry.856744231","entry.22946595","entry.551510588","entry.228782302","entry.627863738","entry.1710424788","entry.2019800477","entry.1830246119","entry.661345846","entry.207288098","entry.1108544641","entry.1399526167","entry.1201478875","entry.1053231874","entry.970451269","entry.591870739","entry.493350169","entry.1204826234","entry.742915224","entry.574111814","entry.134518324","entry.1305189404","entry.1343014516","entry.840913051","entry.1836465148","entry.215031337","entry.1718293256","entry.58152714","entry.1673723508","entry.1638424792","entry.269872164","entry.386407090","entry.2089528528","entry.891188137","entry.810174557","entry.1823357824","entry.1094158169","entry.798680036","entry.494617990","entry.227182486","entry.879941624","entry.1772489561","entry.86539778","entry.1860853812","entry.111239946","entry.709073174","entry.1819740215","entry.1961167804","entry.80842377","entry.1587375263","entry.1024229239","entry.2108942993","entry.1986760620","entry.1859066258","entry.666315091","entry.64169819","entry.1627287267","entry.3183685","entry.1364408679","entry.671919623","entry.221593198","entry.775937613","entry.485068460","entry.556643711","entry.983891918","entry.573529892","entry.1825441849","entry.333755488","entry.324752715","entry.891780518","entry.1966089024","entry.1765708170","entry.1411544531","entry.1857636600","entry.452534403","entry.1341923408","entry.29053707","entry.678495468","entry.116353755","entry.928882619","entry.1981204197","entry.483223132","entry.1903255055","entry.2038639014","entry.1263105767","entry.288556374","entry.662336667","entry.401616238","entry.850733817","entry.1084684316","entry.1730699912","entry.835069292","entry.170024417","entry.1369225654","entry.2062914969","entry.1177731949","entry.1653990885","entry.1032390956","entry.1935328693","entry.984311859","entry.129768363","entry.995220679","entry.1661282944","entry.120038658","entry.1986476869","entry.1970950147","entry.1271859807","entry.363707897","entry.950083611","entry.1067329322","entry.1248503470","entry.265477592","entry.1321942044","entry.2047496503","entry.316618822","entry.811908953","entry.608718462","entry.1224087367","entry.1583137170","entry.1254516156","entry.243586825","entry.1438961647","entry.737227053","entry.1956432739","entry.798079666","entry.83035810","entry.1717104473","entry.1480619059","entry.1939729890","entry.266396299","entry.1996690541","entry.571150899","entry.1513110063","entry.1562634277","entry.1052248417","entry.250282914","entry.1103799768","entry.539811530","entry.1753000301","entry.465675106","entry.322908781","entry.340622628","entry.683677146","entry.331697978","entry.39875966","entry.768054433","entry.109514446","entry.74990949","entry.1623452669","entry.1292713961","entry.1104675523","entry.1002471127","entry.1741151431","entry.1741323370","entry.1781361339","entry.1173108785","entry.1833278363","entry.1857091987","entry.1969643442","entry.559164012","entry.858299723","entry.2019442093","entry.1562365174","entry.1719477608","entry.384267838","entry.1844589316","entry.101042868","entry.1625063368","entry.1199107435","entry.754884522","entry.1998024600","entry.27088701","entry.1037803176","entry.485497029","entry.980717862","entry.1740639835","entry.464978284","entry.1070474601","entry.311946643","entry.436777101","entry.1547379977","entry.1702577301","entry.365177029","entry.1515467289","entry.1457256941","entry.367476037"};
	
	public List<String> MyList = new List<String>();
	public IEnumerator googleCoroutine;
	public IEnumerator dataStringCoroutine;
	private string prolificIdString1;
	private string prolificIdString2;
	public GameObject prolificID;
	public GameObject CanvasObject;
	public GameObject BKG;
	public GameObject myButton;
	// public Button myButton;
	public int InstructionPick;
	public GameObject InstructionGeneral1;
	public GameObject InstructionGeneral2;
	public GameObject Error;
	public GameObject Instruction1;
	public GameObject Instruction2;
	public GameObject Thank;
	public GameObject CorrectScreen;
	public GameObject WrongScreen;
	public GameObject MissedScreen;
	public GameObject Feedback10ScreenGood;
	public GameObject Feedback10ScreenBad;
	public GameObject Feedback20ScreenGood;
	public GameObject Feedback20ScreenBad;
	public GameObject camera;

	public int trialCounter;
	public float[,] responses;
	private string tempStr;
	
	public float referenceTime;
	public float referenceTime1;
	// =============================================================================================================================
	// here we introduce variables needed for changing the group density. We make three cocentric circles and consider five equidistance 
	// radiuses on them. Then, we add a random number (it can be negative) to these values to make sure that everything is random.
    // Agents will be positioned on the intersections of these circles and radiuses ................................................
	public List<float> xPos = new List<float>();
	public List<float> zPos = new List<float>();
	// =============================================================================================================================
    public GameObject[] squares;							// This is the list of game objects that the CubeClrUpdate() method will iterate through
	public Material Clr0;									// Initial color of the screen
    public Material Clr1;									// this is one of the two material that the squares (or any object) in the greed can have
    public Material Clr2;									// same as Color1
    public float x_Start, y_Start, z_Start; 				// this three floats are used to control the position of the grid
    public int columnLength; 								// this is the length (how many cells) are in a column of the grid
    public int rowLength; 									// this is the length (how many rows) are in a column of the grid
    public float x_Space, y_Space; 							// the distance between a the starting point of a square and the next one (should be the same as the size of the object that will be dropped and dragged in the "smallSquare" field, in the inspector)
    public GameObject smallSquare; 							// this line create a public field in the GUI in which the object that is cloned in every cell should be placed
    public MeshRenderer meshRenderer; 						// this line create a public field in which the object that is cloned in every cell should be placed (as above), but this one controls only the mesh renderer of the object
    
    public  Material RndClrMaterial; 						// this is not to be filled with anything in the GUI, is used in this script, and it is public because I will refer to it in the animater

    public int gridSize;
    public float randomThreshold;							// a number between 0 and 1, indicating the percentage of blue and yellow in the stimulus
	public float correctnessCriterion;						// a number indicating the percentage of correct trials (practice and catch: 90%; main: there is no correct answer)
	public List<int> numberList = new List<int>();			// numberList and shuffledList are used to make the stimulus
	public List<int> shuffledList = new List<int>();
	public int rndIndex;									// the indices for shuffling the pixels in the stimulus
	public int range;
	public int ac;
	public int catchTrial;									// a number indicating catch trials. In current setup, only 20 percent of trials are catch
	public int catchInd;									// an index indicating catch trials. It is one, when the trial is a catch trial
	public int SessionInd;								    // this number is one in practice session, and 2 in test session
    public bool S = false;									// internal parameter for making the stimulus
	
	public int densitySelect;								// 1:high-density; 2:low-density
	public float Rp, Rt1, Rt2;								// radius of the group in the practice session and test sessions
	public float DC;
	public float DominColor;
	public float DominantColor;
	public float raisedColor;
	
	public int numberOfAgents;								// number of agents responding in each trial
	public List<int> respondingAgents = new List<int>();	// indices of responding agents
	public List<int> RightLefts = new List<int>();
	public int[] flag;
	public List<int> OriginalArray = new List<int>();		// OriginalArray and shuffledArray help for shuffling the agents
	public List<int> shuffledArray = new List<int>();
	public List<float> distance = new List<float>();
	public List<float> distanceSorted = new List<float>();
	public List<float> distanceBackup = new List<float>();
	
	public int randomIndex;
	
	public GameObject fixationSign;							// fixation cross

	
	public IEnumerator C1;									// coroutine for temporal orgnaizing the change of the stimulus (currently, each trial is 15 seconds)
	public IEnumerator C2;									// coroutine for changing the stimulus
	
	
	// entroducing the parameters that control the experiment
	#region entroducing the parameters that control the experiment
	// Introducing Agents ==================================================================================================================
	public List<GameObject> Agents;
	public GameObject Participant;
	// Introducing Animators ===============================================================================================================
	public Animator fAnimator1, fAnimator2, fAnimator3, fAnimator4, fAnimator5;
	public Animator mAnimator1, mAnimator2, mAnimator3, mAnimator4;
	public Animator participantAnimator;
	public IEnumerator raiseHandCoroutine;
	public IEnumerator raiseBalloonCoroutine;
	public int numberOfPracticeTrials;
	public int numberOfTestTrials;
	public int NumberOfBlocks;
	public int numberOfRounds;		// indicating how many times the whole setup will repeat. For example if we have a high-density, then low-density, then again high-density and low-density, it is "2"
	public float refTime;
	public float timePass;
	public float trialDuration;
	public float newTrialDuration;
	public float fixationDuration;	// the duration that the fixation cross would be shown -------------------------------------------------
	public float agentsRHTime;		// the time point that the agents are supposed to raise their hand in each trial -----------------------
	public float agentsHUDuration;	// the duration that agents keep their hands up --------------------------------------------------------
	// RightLeftF is the parameter that if a female avatar is supposed to raise her hand, it indicates the suitable animation. right: (1~6) 
	// left: (7~9) -------------------------------------------------------------------------------------------------------------------------
	public int RightLeftF1, RightLeftF2, RightLeftF3, RightLeftF4, RightLeftF5, RightLeftF6, RightLeftF7, RightLeftF8;
	// RightLeftM is the parameter that if a male avatar is supposed to raise his hand, it indicates the suitable animation. right: (1~6) --
	// left: (7~13) ------------------------------------------------------------------------------------------------------------------------
	public int RightLeftM1, RightLeftM2, RightLeftM3, RightLeftM4, RightLeftM5, RightLeftM6, RightLeftM7, RightLeftM8;	
	public int RightLeftP;
	public float LR;
	public int congruencyFactor;
	public int correctCount;
	public float percentCorrect;
	
	public Material yellowMaterial;
	public Material blueMaterial;
	
	
	private Vector3[] myPos;	
																										   			   // position of one avatar 
	private float thetaPos;
	private float RPos;
    private int[] posList;					                										 // list of positions of all avatars (elements of this list come from myPos)
	private int[] randomList;
	public GameObject[] avatarPrefabs;
	public int stimSize;	
	public float gridSpacing;																								 // the common distance between each pair of avatars
	private Animator[] Animators;											   							  			   // animations of the avatars that we are going to control
	private GameObject[] myAvatars;
	public GameObject participantAvatar;
	private int avatarCounter = 0;	
	public Material[] clothingMaterialTemplates;
	public int Rem;
	public int numARCs;		// number of arcs
	public int numAngles;	// number of angles
	public int blockPick;
	public int BlockIndex;

	
	#endregion
	// =====================================================================================================================================
    void Start()
    {	
		InstructionPick=2;
		if (InstructionPick==1)
		{
			InstructionGeneral1.SetActive(true);
		}
		else
		{
			InstructionGeneral2.SetActive(true);
		}
		// Initializing parameters ---------------------------------------------------------------------------------------------------------
		trialDuration=5f;									// the duration of each trial
		newTrialDuration=5f;
		agentsRHTime=0.1f;									// the time between the onset of each trial and agents' responses
		agentsHUDuration=2f;								// the time that agents keep their hand raised
		NumberOfBlocks=1;									// number of blocks of the experiment (one practice and one test)
		fixationDuration=1f;
		numberOfRounds=1;
		blockPick=Random.Range(1,3);		// if 1, the poplulation in the first block	is large; if 2, it is small
		numARCs=10;
		numAngles=20;
		// Starting the stimulus ===========================================================================================================
        GenerationCube();
		gridSize=columnLength * rowLength;
		
		numberOfPracticeTrials=4;		//10
		numberOfTestTrials=4;			//75
		Animator participantAnimator = participantAvatar.GetComponent<Animator>();
	}
	// Generate cartesian coordinates for agents ===========================================================================================
	private IEnumerator GeneratePositions(int numARC, int numAngle, int blockIndex1)						   			    // in this coroutine, we generate an array of positions that each avatar will be located (myPos)
    {
		
		myPos = new Vector3[numARC * numAngle];
		ActivateOriginalAvatars();
		int ct=0;
		for (int i1 = 0; i1 < numARC; i1++) 
		{
			for (int j1 = 0; j1 < numAngle; j1++) 
			{
				float randomXOffset = Random.Range(-25f, 25f)/100;
                float randomZOffset = Random.Range(-25f, 25f)/100;
				xPos.Add(i1*gridSpacing/100f-(numARC-1)+randomXOffset);
				zPos.Add(j1*gridSpacing/100f-(numAngle)/2f+randomZOffset);
				print(i1+"    ,     "+j1+"    ,     "+xPos[ct]+"    ,     "+zPos[ct]);
				ct++;
			}
		}
		// Shuffle(xPos);
		// Shuffle(zPos);
        
		for (int counter = 0; counter < numARC * numAngle; counter++)
        {
			myPos[counter] = new Vector3(xPos[counter], -0.24f, zPos[counter]);
            yield return null; // Yield each iteration
        }
		print("Asiiiii");
		StartCoroutine(InstantiateAvatars(numARC, numAngle, blockIndex1));
    }
	// =====================================================================================================================================
	// Function for shuffeling any array (here I use it to shuffle agents' positions =======================================================
	void Shuffle(List<float> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            float temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
	
	void ShuffleInt(List<int> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            int temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
	// =====================================================================================================================================
	// Here, I produce avatars in coordinates mentioned above. I have 9 original avatars that I duplicate them as many times as needed
    private IEnumerator InstantiateAvatars(int numARC, int numAngle, int blockIndex2)
    {
		if (blockIndex2>=2)
		{
			for (int i=0; i<myAvatars.Length; i++)
			{
				myAvatars[i].SetActive(false);
			}
		}
		print("numARC  "+ numARC+"  ,  "+numAngle);
		posList = new int[numARC * numAngle];
		randomList = new int[numARC * numAngle];
		Animators = new Animator[numARC * numAngle];
		myAvatars = new GameObject[numARC * numAngle];
		flag = new int[numARC * numAngle];
		int posCounter = 0;
        for (int i3 = 0; i3 < numARC * numAngle; i3++)			// in this loop, I make a list of numbers between 0 and expected total number of avatars
        {
            posList[i3] = i3;
			randomList[i3] = i3;
			Vector3 position = myPos[i3];
			
			if(position[1]!=0)
			{
				GameObject newAvatar = Instantiate(avatarPrefabs[(i3 % 9)], myPos[i3], Quaternion.identity);
				newAvatar.transform.Rotate(0f, 180.0f, 0.0f, Space.World);
				if ((i3 % 9)==6)
				{
					newAvatar.transform.localScale = new Vector3(0.0045f, 0.0045f, 0.0045f);
				}
				else
				{
					newAvatar.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
				}
				ApplyRandomColorVariation(i3,newAvatar);
				Animator newAnimator = newAvatar.GetComponent<Animator>();
				Animators[i3]=newAnimator;
				myAvatars[i3]=newAvatar;
				Animators[i3].SetInteger("LR", 0);
				avatarCounter++;
			}
			if(position[2]>=0)
			{
				flag[i3]=1;
			}
			print("Flag: "+flag[i3]);
            yield return null; // Yield each iteration
        }

		// Deactivate original avatars, because we didn't choose their position, better let them go!
        DeactivateOriginalAvatars();		// calling the function for deactivating agents
		BKG.SetActive(false);
		Instruction2.SetActive(false);
		CanvasObject.GetComponent<Canvas>().enabled = false;
		C1=ExperimentStructure(blockIndex2, numARC, numAngle);
		StartCoroutine(C1);
		yield return null;	
		
    }

	private void DeactivateOriginalAvatars()
    {
        for (int i = 0; i < avatarPrefabs.Length; i++)
        {
            avatarPrefabs[i].SetActive(false);
        }
    }
	
	private void ActivateOriginalAvatars()
    {
        for (int i = 0; i < avatarPrefabs.Length; i++)
        {
            avatarPrefabs[i].SetActive(true);
        }
    }
	
	private void ApplyRandomColorVariation(int q, GameObject newAvatar)
    {
		// ChangeGlovesColor(newAvatar.transform);
		// newAvatar=myAvatars[q];
        foreach (Renderer renderer in newAvatar.GetComponentsInChildren<Renderer>())
        {
            if (!renderer.gameObject.name.Contains("Body") && 
                !renderer.gameObject.name.Contains("Hair") && 
                !renderer.gameObject.name.Contains("Eye"))
            {
				// print(renderer.gameObject.name);
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    Color randomColor = GenerateNonYellowBlue();
                    newMaterial.color = randomColor;
					newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;
			}	
        }
		// ChangeGlovesColor(newAvatar.transform);
    }
	
	private Color GenerateNonYellowBlue()
    {
		// hue: 0-60:red; 61-120:yellow; 121-180:green; 181-240:cyan; 241-300: blue; 301-360:magenta
        float hue, sat, val;
		hue=2;
		while((hue>0.08f && hue<0.18f) || (hue>0.2f && hue<0.5f) || (hue>0.64f) )
		{ 
			hue = Random.Range(0f, 1f);
		}
        sat = Random.Range(0.2f, 1f);		// how strong is the color
        val = Random.Range(0.3f, 0.7f);		// how bright is the color
        
        return Color.HSVToRGB(hue, sat, val);
    }
	
	// =========================================================================================================================================
	// Stimulus functions ======================================================================================================================
	#region stimulus functions 
    void GenerationCube()
	{
		for (int i = 0; i < columnLength * rowLength; i++)
        {
			smallSquare.GetComponent<MeshRenderer>().material = Clr0;
            Instantiate(smallSquare, new Vector3(x_Start + x_Space * (i%rowLength), y_Start + (-y_Space * (i/columnLength)),z_Start), Quaternion.identity);
        }
		smallSquare.SetActive(false);
	}
	// =====================================================================================================================================
    void CubeClrUpdate(List<int> myShuffledList1, float DC, int blockIndex)
    {
		print("DC:  "+DC);
		catchInd=0;
		catchTrial=Random.Range(1,6);	// choose a random number between 1 and 5. Then, if this number is 5, it is catch trial, meaning that 20% of the trials are catch trial.
		if (catchTrial==5 & blockIndex!=1)
		{
			catchInd=1;					// when catchInd==1, that trial is a catch trial
		}
		if(catchTrial==5 | blockIndex==1)			//blockIndex=1: practice session; 
		{
			randomThreshold=0.6f;
		}
		else
		{
			randomThreshold=0.5f;
		}
		print(catchInd+"   ,   "+randomThreshold);
		if(DC==1)	// choose the dominant color (completely random 50-50)
		{
			randomThreshold=1-randomThreshold;
		}
		
        void SingleCubeRandom(int ACC, List<int> myShuffledList2)
        {
			int ClrChances = myShuffledList2[ACC];
			// int ClrChances = Random.Range(1, columnLength * rowLength + 1);
            if (ClrChances <= randomThreshold * columnLength * rowLength)
            {
                RndClrMaterial = Clr2;
            }
            else
            {
                RndClrMaterial = Clr1;
            }
        }
        
        if (squares == null)
        {
            squares = GameObject.FindGameObjectsWithTag("Squares");
        }
        else
        {
            squares = GameObject.FindGameObjectsWithTag("Squares");
        }

		ac=0;
		foreach (var element in squares)
        {
            SingleCubeRandom(ac,myShuffledList1);
            element.GetComponent<MeshRenderer>().material = RndClrMaterial; //here the value should be RndClrMaterial -  if it is Clr2 or Clr1 that is because the script is being tested with one of the two possible Clr value
			ac++;
        }
        if (S == false)
        {
            S = true;
        }
        else
        {
            S = false;
        }
    }
	#endregion

	// =========================================================================================================================================
	// Experiment Structure coroutine ==========================================================================================================
	#region Experiment Structure coroutine
	IEnumerator ExperimentStructure(int blockIndex, int NumARC, int NumAngle)
    {	
	// participant moves to the first pos (behind all avatars)
	float cameraTime=Time.time;
	participantAnimator.SetInteger("activate", 1);
	while((Time.time-cameraTime) <= 2f)
	{
		// camera.transform.Translate(0, 0, Time.deltaTime*2f/1f);		// 2 m in 1 sec
		participantAvatar.transform.Rotate(0f, -Time.deltaTime*2.5f/1f, 0.0f, Space.World);
		yield return new WaitForSeconds(Time.deltaTime);
		print("Time.time-cameraTime:  "+(Time.time-cameraTime));
	}
	participantAnimator.SetInteger("deactivate", 1);
	participantAnimator.SetInteger("activate", 0);
	
	if (blockIndex==1)		// practice session
	{	
		responses = new float[400,10];		// The array that we are going to store the parameters of the experiment and participants' responses in it
		trialCounter=0;
		catchInd=0;
		correctCount=0;
		for(int ip = 0; ip < numberOfPracticeTrials/2; ip++)		// practice session
		{
			raisedColor=0;
			referenceTime1=Time.time;
			SessionInd=1;						// SessionInd indicates the practice trials (1) and test trials (2)
			trialCounter=trialCounter+1;
			DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
			C2=StimulusChange(gridSize, DominantColor, SessionInd);
			StartCoroutine(C2);
			
			raiseHandCoroutine = RaiseHand(DominantColor, numARCs, numAngles);
			StartCoroutine(raiseHandCoroutine);
			
			while (!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) && (Time.time - referenceTime1) < trialDuration)
			{
				yield return new WaitForSeconds(Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialCounter, 5] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialCounter, 5] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialCounter, 5] = 0;
			}
			responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
			responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
			responses[trialCounter,2]=numARCs*numAngles;
			responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
			responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
			responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
			responses[trialCounter,7]=DominantColor;
			raisedColor=Mathf.Abs(responses[trialCounter,5]-InstructionPick);		// if 0: yellow raised; if 1: blue raised

			
			CanvasObject.GetComponent<Canvas>().enabled = true;
			BKG.SetActive(true);
			
			if((responses[trialCounter, 5]!=0 & raisedColor==0 & DominantColor==1) | (responses[trialCounter, 5]!=0 & raisedColor==1 & DominantColor==2))
			{
				CorrectScreen.SetActive(true);
				correctCount=correctCount+1;
			}
			else if(responses[trialCounter, 5]!=0)
			{
				WrongScreen.SetActive(true);
			}
			else
			{
				MissedScreen.SetActive(true);
			}

			// trialCounter=trialCounter+1;
			percentCorrect=correctCount/(trialCounter+0f);
			StopCoroutine(C2);
			dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
			StartCoroutine(dataStringCoroutine);
			
			yield return new WaitForSeconds(fixationDuration);
			yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
			StopCoroutine(raiseHandCoroutine);
			BKG.SetActive(false);
			CorrectScreen.SetActive(false);
			WrongScreen.SetActive(false);
			MissedScreen.SetActive(false);
			CanvasObject.GetComponent<Canvas>().enabled = false;
		}
		
		CanvasObject.GetComponent<Canvas>().enabled = true;
		BKG.SetActive(true);
		if (percentCorrect>=0.75){
			Feedback10ScreenGood.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback10ScreenGood.SetActive(false);
		}		
		else if(percentCorrect<0.75){
			Feedback10ScreenBad.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback10ScreenBad.SetActive(false);
		}
		BKG.SetActive(false);
		Feedback10ScreenGood.SetActive(false);
		Feedback10ScreenBad.SetActive(false);
		CanvasObject.GetComponent<Canvas>().enabled = false;	

		// participant moves to the second pos (among avatars)
		cameraTime=Time.time;
		participantAnimator.SetInteger("activate", 1);
		while((Time.time-cameraTime) <= 4f)
		{
			// camera.transform.Translate(0, 0, Time.deltaTime*25f/10f);		// 15 m in 5 sec
			participantAvatar.transform.Rotate(0f, -Time.deltaTime*2f/1f, 0.0f, Space.World);
			yield return new WaitForSeconds(Time.deltaTime);
			print("Time.time-cameraTime:  "+(Time.time-cameraTime));
		}
		participantAnimator.SetInteger("deactivate", 1);
		participantAnimator.SetInteger("activate", 0);
		// ========================================================
		correctCount=0;	
		for(int ip = numberOfPracticeTrials/2; ip < numberOfPracticeTrials; ip++)		// practice session
		{
			raisedColor=0;
			referenceTime1=Time.time;
			SessionInd=1;						// SessionInd indicates the practice trials (1) and test trials (2)
			trialCounter=trialCounter+1;
			DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
			C2=StimulusChange(gridSize, DominantColor, SessionInd);
			StartCoroutine(C2);
			
			raiseHandCoroutine = RaiseHand(DominantColor, numARCs, numAngles);
			StartCoroutine(raiseHandCoroutine);
			
			while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
			{
				yield return new WaitForSeconds(Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialCounter, 5] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialCounter, 5] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialCounter, 5] = 0;
			}
			
			responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
			responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
			responses[trialCounter,2]=numARCs*numAngles;
			responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
			responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
			responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
			responses[trialCounter,7]=DominantColor;
			
			
			raisedColor=Mathf.Abs(responses[trialCounter,5]-InstructionPick);		// if 0: yellow raised; if 1: blue raised
			CanvasObject.GetComponent<Canvas>().enabled = true;
			BKG.SetActive(true);

			if((responses[trialCounter, 5]!=0 & raisedColor==0 & DominantColor==1) | (responses[trialCounter, 5]!=0 & raisedColor==1 & DominantColor==2))
			{
				CorrectScreen.SetActive(true);
				correctCount=correctCount+1;
			}
			else if(responses[trialCounter, 5]!=0)
			{
				WrongScreen.SetActive(true);
			}
			else
			{
				MissedScreen.SetActive(true);
			}
			
			percentCorrect=correctCount/(trialCounter-10f);
			StopCoroutine(C2);
			dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
			StartCoroutine(dataStringCoroutine);
			
			yield return new WaitForSeconds(fixationDuration);
			yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
			StopCoroutine(raiseHandCoroutine);
			BKG.SetActive(false);
			CorrectScreen.SetActive(false);
			WrongScreen.SetActive(false);
			MissedScreen.SetActive(false);
			CanvasObject.GetComponent<Canvas>().enabled = false;
		}	
		// ========================================================
		CanvasObject.GetComponent<Canvas>().enabled = true;
		BKG.SetActive(true);
		if (percentCorrect>=0.75){
			Feedback20ScreenGood.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback20ScreenGood.SetActive(false);
		}		
		else if(percentCorrect<0.75){
			Feedback20ScreenBad.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback20ScreenBad.SetActive(false);
		}
		// BKG.SetActive(false);
		// Feedback20ScreenGood.SetActive(false);
		// Feedback20ScreenBad.SetActive(false);
		CanvasObject.GetComponent<Canvas>().enabled = false;
		BlockIndex=2;
		StartCoroutine(GeneratePositions(numARCs, numAngles,2));
	}
	else if(blockIndex==2)
	{
		print("Block1");
		// Modifying the density of the group ==================================================================================================
		// for(int rund = 0; rund < numberOfRounds; rund++)
		// {
			for(int it1 = 0; it1 < numberOfTestTrials; it1++)		// practice session
			{
				referenceTime1=Time.time;
				SessionInd=2;						// SessionInd indicates the practice trials (1) and test trials (2)
				if (it1==0)
				{
					trialCounter=numberOfPracticeTrials;
				}
				trialCounter=trialCounter+1;
				
				
				
				fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
				yield return new WaitForSeconds(fixationDuration);
				fixationSign.SetActive(false);

				DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
				C2=StimulusChange(gridSize, DominantColor, SessionInd);
				StartCoroutine(C2);
				
				raiseHandCoroutine = RaiseHand(DominantColor, numARCs, numAngles);
				StartCoroutine(raiseHandCoroutine);
				
				while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
				{
					yield return new WaitForSeconds(Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.RightArrow))
				{
					responses[trialCounter, 5] = 1;
					Input.ResetInputAxes();
				}
				else if(Input.GetKey(KeyCode.LeftArrow))
				{
					responses[trialCounter, 5] = 2;
					Input.ResetInputAxes();
				}
				else
				{
					responses[trialCounter, 5] = 0;
				}
				responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
				responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
				responses[trialCounter,2]=numARCs*numAngles;
				responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
				responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
				responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
				responses[trialCounter,7]=DominantColor;
				StopCoroutine(C2);
				dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
				StartCoroutine(dataStringCoroutine);
				yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
				StopCoroutine(raiseHandCoroutine);
			}

			CanvasObject.GetComponent<Canvas>().enabled = true;
			BKG.SetActive(true);
			Instruction2.SetActive(true);
			yield return new WaitForSeconds(2f);
			// BKG.SetActive(false);
			// Instruction2.SetActive(false);
			// CanvasObject.GetComponent<Canvas>().enabled = false;
			BlockIndex=3;
			StartCoroutine(GeneratePositions(numARCs, numAngles, 3));
	}
	else if(blockIndex==3)
	{
			// ............................................
			for(int it2 = 0; it2 < numberOfTestTrials; it2++)		// practice session
			{
				referenceTime1=Time.time;
				SessionInd=3;						// SessionInd indicates the practice trials (1) and test trials (2)
				if (it2==0)
				{
					trialCounter=numberOfPracticeTrials+numberOfTestTrials;
				}
				trialCounter=trialCounter+1;
				// print("trialCounter:  "+trialCounter);
				fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
				yield return new WaitForSeconds(fixationDuration);
				fixationSign.SetActive(false);

				DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
				C2=StimulusChange(gridSize, DominantColor, SessionInd);
				StartCoroutine(C2);
				
				raiseHandCoroutine = RaiseHand(DominantColor,numARCs, numAngles);
				StartCoroutine(raiseHandCoroutine);
				
				while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
				{
					yield return new WaitForSeconds(Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.RightArrow))
				{
					responses[trialCounter, 5] = 1;
					Input.ResetInputAxes();
				}
				else if(Input.GetKey(KeyCode.LeftArrow))
				{
					responses[trialCounter, 5] = 2;
					Input.ResetInputAxes();
				}
				else
				{
					responses[trialCounter, 5] = 0;
				}
				responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
				responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
				responses[trialCounter,2]=numARCs*numAngles;
				responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
				responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
				responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
				responses[trialCounter,7]=DominantColor;
				StopCoroutine(C2);
				// print("trialCounter:  "+it2+"   ,   "+trialCounter);
				dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
				StartCoroutine(dataStringCoroutine);
				yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
				StopCoroutine(raiseHandCoroutine);
				// after block2
			}
			// if (rund==0)
			// {
				CanvasObject.GetComponent<Canvas>().enabled = true;
				BKG.SetActive(true);
				// Instruction2.SetActive(true);
				yield return new WaitForSeconds(5f);
				// BKG.SetActive(false);
				// Instruction2.SetActive(false);
				// CanvasObject.GetComponent<Canvas>().enabled = false;
			// }
		// }
		CanvasObject.GetComponent<Canvas>().enabled = true;
		BKG.SetActive(true);
		Thank.SetActive(true);
	}
		// JatosInterface.StartNextJatosEvent();
	} 

	IEnumerator StimulusChange(int GridSize, float DominColor, int sessionIndex)
    {
		numberList.Clear();
		shuffledList.Clear();

		for(int i = 0; i < gridSize; i++)
		{
			numberList.Add(i);
		}
		range=gridSize-1;
		for(int j=0; j<gridSize; j++)
		{
			rndIndex=Random.Range(0,range);
			shuffledList.Add(numberList[rndIndex]);
			numberList.Remove(numberList[rndIndex]);
			range=range-1;
		}
		CubeClrUpdate(shuffledList, DominColor, sessionIndex);
		yield return null;
    } 
	#endregion
	// =========================================================================================================================================
	
	// ExperimentControl coroutines ============================================================================================================
	#region experimentControl coroutines

	public IEnumerator RaiseHand(float myDC, int numARC, int numAngle)
    {
		// here, we choose the percentage of the times that the group responds correctly.
		correctnessCriterion=Random.Range(1,11);	// make a randm number between 1 and 10, including 1 and 10
		if (correctnessCriterion<10)		// if the random number is less than 10 (not including 10), group respond correctly. In other words, 90% of the time!
		{
			LR=myDC;
		}
		else
		{
			LR=Random.Range(1,3);
		}		
		refTime=Time.time;
		OriginalArray=new List<int>{};
		for (int j = 0; j < numARC * numAngle; j++) // Add each number 10 times
        {
            OriginalArray.Add(j);
        }
		ShuffleInt(OriginalArray);
		shuffledArray=new List<int>{};		// a shuffled array of all the numbers between 1 and 15
		numberOfAgents=(Random.Range(1,4)*3-2)*(numARC * numAngle)/12;		// 1, 4, or 7 agents respond.
		respondingAgents=new List<int>{};
		for (int n = 0; n < numberOfAgents; n++)
		{
			respondingAgents.Add(OriginalArray[n]);	
		}
		// =================================================================================================================================
		if (LR==1)	// Agents are supposed to raise their left hand --------------------------------------------------------------------
		{
			RightLefts=new List<int>{};
			for (int n = 0; n < numberOfAgents; n++)
			{
				RightLefts.Add(Random.Range(1,7));	
			}
		}
		else if (LR==2)		// Agents are supposed to raise their right hand -----------------------------------------------------------
		{
			RightLefts=new List<int>{};
			for (int n = 0; n < numberOfAgents; n++)
			{
				RightLefts.Add(8);
			}
		}
			
		for (int b = 0; b < numberOfAgents; b++)
		{
			print("Agents:   "+respondingAgents[b]);
			for(int a=0; a<numARC * numAngle; a++)
			{
				if (((a==respondingAgents[b]) && (respondingAgents[b]%9)<=4)&(flag[b] != 1))
				{
					RightLeftF1=RightLefts[b];
					Animators[a].SetInteger("F", RightLeftF1);
				}
				else if (((a==respondingAgents[b]) && (respondingAgents[b]>4))&(flag[b] != 1))
				{
					RightLeftM1=RightLefts[b];
					Animators[a].SetInteger("M", RightLeftM1);
				}
			}
		}
		yield return new WaitForSeconds(agentsRHTime);
		for (int b = 0; b < numberOfAgents; b++)
		{
			for(int a=0; a<numARC * numAngle; a++)
			{
				if (((a==respondingAgents[b]) && (respondingAgents[b]%9)<=4)&(flag[b] != 1))
				{
					RightLeftF1=RightLefts[b];
					Animators[a].SetInteger("FLR", RightLeftF1);
				}
				else if (((a==respondingAgents[b]) && (respondingAgents[b]>4))&(flag[b] != 1))
				{
					RightLeftM1=RightLefts[b];
					Animators[a].SetInteger("MLR", RightLeftM1);
				}
			}
		}
		yield return new WaitForSeconds(agentsHUDuration);
		for (int b = 0; b < numberOfAgents; b++)
		{
			for(int a=0; a<numARC * numAngle; a++)
			{
				if ((a==respondingAgents[b]) && (respondingAgents[b]%9)<=4)
				{
					RightLeftF1=RightLefts[b];
					Animators[a].SetInteger("FI", RightLeftF1);
					Animators[a].SetInteger("RestartF", RightLeftF1);
				}
				else if ((a==respondingAgents[b]) && (respondingAgents[b]>4))
				{
					RightLeftM1=RightLefts[b];
					Animators[a].SetInteger("MI", RightLeftM1);
					Animators[a].SetInteger("RestartM", RightLeftM1);
				}
			}
		}
		yield return new WaitForSeconds(0.5f);
		for (int b = 0; b < numberOfAgents; b++)
		{
			for(int a=0; a<numARC * numAngle; a++)
			{
				if ((a==respondingAgents[b]) && (respondingAgents[b]%9)<=4)
				{
					RightLeftF1=RightLefts[b];
					Animators[a].SetInteger("F", 0);
					Animators[a].SetInteger("FLR", 0);
					Animators[a].SetInteger("FI", 0);
				}
				else if ((a==respondingAgents[b]) && (respondingAgents[b]>4))
				{
					RightLeftM1=RightLefts[b];
					Animators[a].SetInteger("M", 0);
					Animators[a].SetInteger("MLR", 0);
					Animators[a].SetInteger("MI", 0);
				}
			}
		}
		yield return new WaitForSeconds(1f);
		for (int b = 0; b < numberOfAgents; b++)
		{
			for(int a=0; a<numARC * numAngle; a++)
			{
				if ((a==respondingAgents[b]) && (respondingAgents[b]%9)<=4)
				{
					RightLeftF1=RightLefts[b];
					Animators[a].SetInteger("RestartF", 0);
				}
				else if ((a==respondingAgents[b]) && (respondingAgents[b]>4))
				{
					RightLeftM1=RightLefts[b];
					Animators[a].SetInteger("RestartM", 0);
				}
			}
		}
    }
	#endregion
	// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                   make data string                   ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		IEnumerator DataStringMaker(float[,] responses, int trialNumber, List<string> myList){
			tempStr=(((responses[trialNumber, 0]).ToString())+", "+((responses[trialNumber, 1]).ToString())+", "+((responses[trialNumber, 2]).ToString())+", "+((responses[trialNumber, 3]).ToString())+", "+((responses[trialNumber, 4]).ToString())+", "+((responses[trialNumber, 5]).ToString())+", "+((responses[trialNumber, 6]).ToString())+", "+((responses[trialNumber, 7]).ToString()));
			// trialDataString.Add(new string(tempStr));
			myList.Add(tempStr);
			// print("11111111111111");
			print(trialNumber+"   ;   "+(numberOfPracticeTrials+numberOfTestTrials*2*numberOfRounds)+ "  ,  "+numberOfPracticeTrials+"  ,  "+numberOfTestTrials);
			if (trialNumber==(numberOfPracticeTrials+numberOfTestTrials*2*numberOfRounds))		// *2 because we have two test sessions (blocks). Since the trialNumber starts at 1, no need to subtract 1 from the summation
			{
				print("222222222222222"+trialNumber);
				WWWForm form=new WWWForm();
				prolificIdString2=prolificID.GetComponent<InputField>().text;
				// prolificIdString2="Asi";
				form.AddField(address[0],prolificIdString2);
				form.AddField(address[1],"LargeSmall");		// a code to simplify distinguishing the data from each experiment
				form.AddField(address[2],InstructionPick);		// a code to simplify distinguishing the data from each experiment
				for(int i = 0; i < (numberOfPracticeTrials+numberOfTestTrials*2*numberOfRounds); i++)
				{
					form.AddField(address[i+3],myList[i]);
				}
				byte[] rawData=form.data;
				WWW www=new WWW(BASE_URL, rawData);
				yield return www;
			}
			
			
			yield return null;
		}	
	
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::     get basic information from the participant       ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		IEnumerator PID(string MyProlificIdString){
		WWWForm form=new WWWForm();
		// form.AddField(address[0],MyProlificIdString);
		byte[] rawData=form.data;
		WWW www=new WWW(BASE_URL, rawData);
		yield return null;
		}
		
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::   save basic information of the participant  on google form   :::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	public void Send(){
		prolificIdString1=prolificID.GetComponent<InputField>().text;
		int count = prolificIdString1.Length;
		InstructionGeneral1.SetActive(false);
		InstructionGeneral2.SetActive(false);
		if (count<20)
		{
			Error.SetActive(true);
		}
		else
		{
			Error.SetActive(false);
			prolificID.SetActive(false);
			// 
			myButton.SetActive(false);	// This removes the button from the UI entirely:
			CanvasObject.GetComponent<Canvas>().enabled = false;
			Input.ResetInputAxes();
			BlockIndex=1;
			StartCoroutine(GeneratePositions(numARCs, numAngles, 1));
		}
	}
}