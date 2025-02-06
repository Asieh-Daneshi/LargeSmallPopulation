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
// *****************************************************************************************************************************************************************************
public class Main : MonoBehaviour
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
	public GameObject CanvasBKG;
	public GameObject myButton;
	public GameObject Error;
	
    public GameObject[] avatarPrefabs;
	public GameObject fixationSign;		// the original avatars that we copy several times 
	public Material[] clothingMaterialTemplates;
    public int numberOfDuplicates;												     									  // number of times that each avatar must be duplicated
	public int stimSize;	
    public float gridSpacing;																								 // the common distance between each pair of avatars
	private Animator[] Animators;											   							  			   // animations of the avatars that we are going to control
	private GameObject[] myAvatars;

    private Vector3[] myPos;																											   			   // position of one avatar 
    private int[] posList;					                										 // list of positions of all avatars (elements of this list come from myPos)
	private int[] randomList;
	private int[] RightLeft;
    private int avatarCounter = 0;			                                   							       			   // a counter for the avatars that we make in the code
	public int numTrialsTrain = 10;
	public int numTrialsTest = 10;
	public float referenceTime1;
	public float trialDuration=5f;
	public int conditionSelect;
	public int catchIndex;
	
	public Material yellowMaterial;
	public Material blueMaterial;
	
	public float[,] responses;
	public float refTime;
	public float timePassed;
	public int pamponColorSelcet;
	public IEnumerator C1;
	private string tempStr;
	public int trialNumber;
	
    private IEnumerator Start()
    {
		myPos = new Vector3[stimSize * stimSize];
        posList = new int[stimSize * stimSize];
		randomList = new int[stimSize * stimSize];
		// RightLeft = new int[stimSize * stimSize];
		yield return new WaitForSeconds(.001f);  
    }

    private IEnumerator GeneratePositions()						   			    // in this coroutine, we generate an array of positions that each avatar will be located (myPos)
    {
        int counter = 0;
		// int randRightLeft=0;
		
		for (int i1 = 0; i1 < stimSize; i1++)
        {
            for (int i2 = 0; i2 < stimSize; i2++)
            {
                float randomXOffset = Random.Range(-75f, 75f);
                float randomZOffset = Random.Range(-75f, 75f);
                myPos[counter] = new Vector3(i1 * gridSpacing + randomXOffset-150, 0f, i2 * gridSpacing + randomZOffset+10000);
				// randRightLeft=Random.Range(0,10);
				// if (randRightLeft < 5)		// left hand
					// RightLeft[counter] = Random.Range(10,15);	// a number between 10 and 14
				// else		// right hand
					// RightLeft[counter] = Random.Range(3,10); 	// a number between 3 and 9
							
						
                counter++;
                yield return null; // Yield each iteration
            }
        }
		
        // for (int i1 = 0; i1 < avatarPrefabs.Length; i1++)
        // {
            // for (int i2 = 0; i2 < numberOfDuplicates; i2++)
            // {
                // float randomXOffset = Random.Range(-75f, 75f);
                // float randomZOffset = Random.Range(-75f, 75f);
                // myPos[counter] = new Vector3(i1 * gridSpacing + randomXOffset, 0f, i2 * gridSpacing + randomZOffset);
                // counter++;
                // yield return null; // Yield each iteration
            // }
        // }
    }

    private IEnumerator InstantiateAvatars()
    {
		Animators = new Animator[stimSize * stimSize];
		myAvatars = new GameObject[stimSize * stimSize];
        for (int i3 = 0; i3 < stimSize * stimSize; i3++)			// in this loop, I make a list of numbers between 0 and expected total number of avatars
        {
            posList[i3] = i3;
			randomList[i3] = i3;
            yield return null; // Yield each iteration
        }

        // int totalAvatars = avatarPrefabs.Length * numberOfDuplicates;
        int posCounter = 0;
		// in this nested loop, first, we shuffle the elements of "posList", so that copies of each avatar be located randomly, not in a queue behid that avatar. Then, we copy 
		// original avatars as new avatars, call their animators, and change the color of their clothes randomly!
        int k1, k2;
		for (int row = 0; row < stimSize; row++)		
		{
            for (int i = 0; i < stimSize; i++)
            {
				if (i<10)
				{
					k1=i;
					k2=0;
				}
				else
				{
					k1=i % (avatarPrefabs.Length);
					k2=Mathf.FloorToInt(i/(avatarPrefabs.Length));
					// print(k1+"  ,  "+k2);
				}
                int posIndex = Random.Range(0, stimSize * stimSize - posCounter);
				int randomIndex = Random.Range(0, stimSize * stimSize - posCounter);
                posCounter++;
                Vector3 position = myPos[posList[posIndex]];
                posList[posIndex] = posList[stimSize * stimSize - posCounter];
				randomList[posIndex] = randomList[stimSize * stimSize - posCounter];
                GameObject newAvatar = Instantiate(avatarPrefabs[k1], position, Quaternion.identity, transform);
				newAvatar.transform.rotation = Quaternion.Euler(0, 180, 0);
                Animator newAnimator = newAvatar.GetComponent<Animator>();
                // print(row * (stimSize) +(k2)*(avatarPrefabs.Length) +k1);
				Animators[row * (stimSize) +(k2)*(avatarPrefabs.Length)+k1]=newAnimator;
				myAvatars[row * (stimSize) +(k2)*(avatarPrefabs.Length)+k1]=newAvatar;
				// print(row * (stimSize) +(k2)*(avatarPrefabs.Length)+k1);
                ApplyRandomColorVariation(row * (stimSize) +(k2)*(avatarPrefabs.Length)+k1,newAvatar);
				Animators[row * (stimSize) +(k2)*(avatarPrefabs.Length)+k1].SetInteger("LR", 0);																	         // avatars raise their hand and keep it up until further notice
				
                // newAvatar.tag = $"agent{avatarCounter + 1}";
				// ChangeGlovesColor(newAvatar.transform);
                avatarCounter++;
                yield return null; // Yield each iteration
            }
        }
		// Step 3: Deactivate original avatars
        DeactivateOriginalAvatars();
		// Int his loop, we assign a name for each animator, and initiate the animators. "LR" is the parameter that when is not zero starts the animation in the idle mode!
		for (int j = 0; j< (stimSize*stimSize);j++)
		{
			Animators[j].gameObject.name="Animator"+(j+1);
			// Animators[j].SetInteger("LR", RightLeft[j]);
		}
		
		yield return StartCoroutine(ControlAvatars(myAvatars));		                               // "StartCoroutine" is a coroutine that controls the timing of the actions of avatars
    }

	private IEnumerator ControlAvatars(GameObject[] MyAvatar)
    {
		pamponColorSelcet=Random.Range(1,3);	// if 1: right hand blue, left hand yellow; if 2: right hand yellow, left hand blue
		// RightLeft = new int[stimSize * stimSize];
		
		responses = new float[400,10];
		trialNumber = 0;
		int participantSelect=Random.Range(1,3);
		// Practice session ===========================================================================================
		for (int trial=0; trial< numTrialsTrain; trial++)		// Training session
		{
			print("trial: "+ trial);
			RightLeft = new int[stimSize * stimSize];
			int count=0;
			float randRightLeft=0;
			
			conditionSelect=Random.Range(1,3);	// we have one condition in practice and cath trials 60 to 40, but the dominant color can be yellow or blue, so, we consider two conditions: 60 to 40 or 40 to 60
			if (conditionSelect==1)
			{		
				print("Asiiiiiii");
				for (int i1 = 0; i1 < stimSize; i1++)
				{
					for (int i2 = 0; i2 < stimSize; i2++)
					{
						// ApplyBlackPampons(MyAvatar[count]);
						RightLeft[count]=0;
						randRightLeft=Random.Range(1f,100f);
						if (randRightLeft < 40)		// left hand
							RightLeft[count] = Random.Range(10,15);	// a number between 10 and 14
						else		// right hand
							RightLeft[count] = Random.Range(3,10); 	// a number between 3 and 9
						Animators[count].SetInteger("LR", RightLeft[count]);
						if (participantSelect==1)
						{
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable visibility
							}
						}
						
						
						if (participantSelect == 1)
						{
							// Hide the agents
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable agent visibility
							}

							// Show the cylinders
							MeshRenderer[] meshRenderers = MyAvatar[count].GetComponentsInChildren<MeshRenderer>();
							foreach (MeshRenderer mr in meshRenderers)
							{
								mr.enabled = true; // Enable cylinder visibility
							}
						}
						else
						{
							// Show the agents
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = true; // Enable agent visibility
							}

							// Hide the cylinders
							foreach (GameObject avatar in MyAvatar)
							{
								Transform[] allChildren = avatar.GetComponentsInChildren<Transform>(true); // Get all nested children

								foreach (Transform child in allChildren)
								{
									if (child.CompareTag("cylinder")) // Check for cylinders deep in hierarchy
									{
										child.gameObject.SetActive(false);  // Hide the cylinder
										Debug.Log("Hiding cylinder: " + child.name);
									}
								}
							}
							// MeshRenderer[] meshRenderers = MyAvatar[count].GetComponentsInChildren<MeshRenderer>();
							// foreach (MeshRenderer mr in meshRenderers)
							// {
								// mr.enabled = false; // Disable cylinder visibility
							// }
						}
						count++;
					}
					
				}
			}
			else
			{		
				print("Asiiiiiii");
				for (int i1 = 0; i1 < stimSize; i1++)
				{
					for (int i2 = 0; i2 < stimSize; i2++)
					{
						// ApplyBlackPampons(MyAvatar[count]);
						RightLeft[count]=0;
						randRightLeft=Random.Range(1f,100f);
						if (randRightLeft < 40)		// right hand
							RightLeft[count] = Random.Range(3,10);	// a number between 3 and 9
						else		// left hand
							RightLeft[count] = Random.Range(10,15); 	// a number between 10 and 14
						Animators[count].SetInteger("LR", RightLeft[count]);
						if (participantSelect==1)
						{
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable visibility
							}
						}
						count++;
					}
					
				}
			}
			
			
			yield return new WaitForSeconds(1f);	                                                                         // the time before avatars raise their hand
			refTime = Time.time;
			for (int j = 0; j< (stimSize*stimSize);j++)																		         // avatars raise their hand and keep it up until further notice
			{
				Animators[j].SetInteger("O", 0);
				Animators[j].SetInteger("U", RightLeft[j]);
				Animators[j].SetInteger("KU", RightLeft[j]);
				ApplyColorPampons(MyAvatar[j],pamponColorSelcet);
			}
			fixationSign.SetActive(false);
			 print("Raise");
			
			// yield return new WaitForSeconds(3f);							 															// the time that avatars keep their hands up
			
			refTime = Time.time;
			timePassed=Time.time-refTime;	
	
			while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (timePassed)<=trialDuration)
			{
				// yield return new WaitForSeconds(Time.deltaTime);
				yield return null;
				timePassed=Time.time-refTime;
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialNumber, 1] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialNumber, 1] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialNumber, 1] = 0;
			}

			
			for (int j = 0; j< (stimSize*stimSize);j++)								   
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("LR", 0);
				Animators[j].SetInteger("U", 0);
				Animators[j].SetInteger("KU", 0);
				Animators[j].SetInteger("D", RightLeft[j]);
				Animators[j].SetInteger("I", RightLeft[j]);
			}
			 print("Down");
			
			yield return new WaitForSeconds(1f); // the time that avatars have already lowered their hands and stay in their idle posture before returning to their original posture
			for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("D", 0);
				Animators[j].SetInteger("I", 0);
				Animators[j].SetInteger("O", RightLeft[j]);
			}
			yield return new WaitForSeconds(3f);
			print("Back");
			for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("O", 0);
			}
			responses[trialNumber,0]=conditionSelect;
			responses[trialNumber,2]=timePassed;
			responses[trialNumber,3]=pamponColorSelcet;
			print("responses: " + trial + " , " + responses[trialNumber,0] + " , " + responses[trialNumber,1] + " , " + responses[trialNumber,2] + " , " + responses[trialNumber,3]);
			dataStringCoroutine = DataStringMaker(responses, trialNumber, MyList);
			StartCoroutine(dataStringCoroutine);
			trialNumber=trialNumber+1;
		}
		// Test session ===============================================================================================
		for (int trial=0; trial< numTrialsTest; trial++)		// Training session
		{
			print("trial: "+ trial);
			RightLeft = new int[stimSize * stimSize];
			int count=0;
			float randRightLeft=0;
			refTime = Time.time;
			catchIndex=Random.Range(0,5);		// 20 percent of the trials in the test session are catch trials. 
			if (catchIndex>0)					// main trials 
			{
				conditionSelect=3;				// 50% of the agents raise their right hand and 50% raise their left hand
			}
			else
			{
				conditionSelect=Random.Range(1,3);	// we have one condition in practice and cath trials 60 to 40, but the dominant color can be yellow or blue, so, we consider two conditions: 60 to 40 or 40 to 60
			}
			if (conditionSelect==1)
			{		
				for (int i1 = 0; i1 < stimSize; i1++)
				{
					for (int i2 = 0; i2 < stimSize; i2++)
					{
						// ApplyBlackPampons(MyAvatar[count]);
						RightLeft[count]=0;
						randRightLeft=Random.Range(1f,100f);
						if (randRightLeft <= 40)		// left hand
							RightLeft[count] = Random.Range(10,15);	// a number between 10 and 14
						else		// right hand
							RightLeft[count] = Random.Range(3,10); 	// a number between 3 and 9
						Animators[count].SetInteger("LR", RightLeft[count]);
						if (participantSelect==1)
						{
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable visibility
							}
						}
						count++;
					}
					
				}
			}
			else if (conditionSelect==2)
			{		
				for (int i1 = 0; i1 < stimSize; i1++)
				{
					for (int i2 = 0; i2 < stimSize; i2++)
					{
						// ApplyBlackPampons(MyAvatar[count]);
						RightLeft[count]=0;
						randRightLeft=Random.Range(1f,100f);
						if (randRightLeft <= 40)		// right hand
							RightLeft[count] = Random.Range(3,10);	// a number between 3 and 9
						else		// left hand
							RightLeft[count] = Random.Range(10,15); 	// a number between 10 and 14
						Animators[count].SetInteger("LR", RightLeft[count]);
						if (participantSelect==1)
						{
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable visibility
							}
						}
						count++;
					}
					
				}
			}
			else 	// conditionSelect=3; main trials
			{		
				for (int i1 = 0; i1 < stimSize; i1++)
				{
					for (int i2 = 0; i2 < stimSize; i2++)
					{
						// ApplyBlackPampons(MyAvatar[count]);
						RightLeft[count]=0;
						randRightLeft=Random.Range(1f,100f);
						if (randRightLeft <= 50)		// right hand
							RightLeft[count] = Random.Range(3,10);	// a number between 3 and 9
						else		// left hand
							RightLeft[count] = Random.Range(10,15); 	// a number between 10 and 14
						Animators[count].SetInteger("LR", RightLeft[count]);
						if (participantSelect==1)
						{
							SkinnedMeshRenderer[] skinnedMeshRenderers = MyAvatar[count].GetComponentsInChildren<SkinnedMeshRenderer>();
							foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
							{
								smr.enabled = false; // Disable visibility
							}
						}
						count++;
					}
					
				}
			}
			
			
			yield return new WaitForSeconds(1f);	                                                                         // the time before avatars raise their hand
			
			for (int j = 0; j< (stimSize*stimSize);j++)																		         // avatars raise their hand and keep it up until further notice
			{
				Animators[j].SetInteger("O", 0);
				Animators[j].SetInteger("U", RightLeft[j]);
				Animators[j].SetInteger("KU", RightLeft[j]);
				ApplyColorPampons(MyAvatar[j],pamponColorSelcet);
			}
			fixationSign.SetActive(false);
			 // print("Raise");
			
			// yield return new WaitForSeconds(3f);							 															// the time that avatars keep their hands up
			
			refTime = Time.time;
			timePassed=Time.time-refTime;	
	
			while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (timePassed)<=trialDuration)
			{
				// yield return new WaitForSeconds(Time.deltaTime);
				yield return null;
				timePassed=Time.time-refTime;
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialNumber, 5] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialNumber, 5] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialNumber, 5] = 0;
			}
			
			for (int j = 0; j< (stimSize*stimSize);j++)								   
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("LR", 0);
				Animators[j].SetInteger("U", 0);
				Animators[j].SetInteger("KU", 0);
				Animators[j].SetInteger("D", RightLeft[j]);
				Animators[j].SetInteger("I", RightLeft[j]);
			}
			 // print("Down");
			
			yield return new WaitForSeconds(1f); // the time that avatars have already lowered their hands and stay in their idle posture before returning to their original posture
			for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("D", 0);
				Animators[j].SetInteger("I", 0);
				Animators[j].SetInteger("O", RightLeft[j]);
			}
			yield return new WaitForSeconds(3f);
			print("Back");
			for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			{
				Animators[j].gameObject.name="Animator"+(j+1);
				Animators[j].SetInteger("O", 0);
			}
			responses[trialNumber,0]=conditionSelect;
			responses[trialNumber,3]=pamponColorSelcet;
			print("responses: " + trialNumber + " , " + responses[trialNumber,0] + " , " + responses[trialNumber,1] + " , " + responses[trialNumber,2] + " , " + responses[trialNumber,3]);
			dataStringCoroutine = DataStringMaker(responses, trialNumber, MyList);
			StartCoroutine(dataStringCoroutine);
			trialNumber=trialNumber+1;
		}
		
		// // Block 2
		// for (int trial=0; trial< numTrialsTest; trial++)		// Training session
		// {
			// print("trial: "+ trial);
			// RightLeft = new int[stimSize * stimSize];
			// int count=0;
			// float randRightLeft=0;
			// refTime = Time.time;
			// catchIndex=Random.Range(0,5);		// 20 percent of the trials in the test session are catch trials. 
			// if (catchIndex>0)					// main trials 
			// {
				// conditionSelect=3;				// 50% of the agents raise their right hand and 50% raise their left hand
			// }
			// else
			// {
				// conditionSelect=Random.Range(1,3);	// we have one condition in practice and cath trials 60 to 40, but the dominant color can be yellow or blue, so, we consider two conditions: 60 to 40 or 40 to 60
			// }
			// if (conditionSelect==1)
			// {		
				// for (int i1 = 0; i1 < stimSize; i1++)
				// {
					// for (int i2 = 0; i2 < stimSize; i2++)
					// {
						// // ApplyBlackPampons(MyAvatar[count]);
						// RightLeft[count]=0;
						// randRightLeft=Random.Range(1f,100f);
						// if (randRightLeft <= 40)		// left hand
							// RightLeft[count] = Random.Range(10,15);	// a number between 10 and 14
						// else		// right hand
							// RightLeft[count] = Random.Range(3,10); 	// a number between 3 and 9
						// Animators[count].SetInteger("LR", RightLeft[count]);
						// if (myAvatars[count].TryGetComponent<MeshRenderer>(out MeshRenderer meshRenderer))
						// {
							// meshRenderer.enabled =false;
						// }
						// count++;
					// }
					
				// }
			// }
			// else if (conditionSelect==2)
			// {		
				// for (int i1 = 0; i1 < stimSize; i1++)
				// {
					// for (int i2 = 0; i2 < stimSize; i2++)
					// {
						// // ApplyBlackPampons(MyAvatar[count]);
						// RightLeft[count]=0;
						// randRightLeft=Random.Range(1f,100f);
						// if (randRightLeft <= 40)		// right hand
							// RightLeft[count] = Random.Range(3,10);	// a number between 3 and 9
						// else		// left hand
							// RightLeft[count] = Random.Range(10,15); 	// a number between 10 and 14
						// Animators[count].SetInteger("LR", RightLeft[count]);
						// count++;
					// }
					
				// }
			// }
			// else 	// conditionSelect=3; main trials
			// {		
				// for (int i1 = 0; i1 < stimSize; i1++)
				// {
					// for (int i2 = 0; i2 < stimSize; i2++)
					// {
						// // ApplyBlackPampons(MyAvatar[count]);
						// RightLeft[count]=0;
						// randRightLeft=Random.Range(1f,100f);
						// if (randRightLeft <= 50)		// right hand
							// RightLeft[count] = Random.Range(3,10);	// a number between 3 and 9
						// else		// left hand
							// RightLeft[count] = Random.Range(10,15); 	// a number between 10 and 14
						// Animators[count].SetInteger("LR", RightLeft[count]);
						// count++;
					// }
					
				// }
			// }
			
			
			// yield return new WaitForSeconds(1f);	                                                                         // the time before avatars raise their hand
			
			// for (int j = 0; j< (stimSize*stimSize);j++)																		         // avatars raise their hand and keep it up until further notice
			// {
				// Animators[j].SetInteger("O", 0);
				// Animators[j].SetInteger("U", RightLeft[j]);
				// Animators[j].SetInteger("KU", RightLeft[j]);
				// ApplyColorPampons(MyAvatar[j],pamponColorSelcet);
			// }
			// fixationSign.SetActive(false);
			 // // print("Raise");
			
			// // yield return new WaitForSeconds(3f);							 															// the time that avatars keep their hands up
			
			// refTime = Time.time;
			// timePassed=Time.time-refTime;	
	
			// while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (timePassed)<=trialDuration)
			// {
				// // yield return new WaitForSeconds(Time.deltaTime);
				// yield return null;
				// timePassed=Time.time-refTime;
			// }
			// if(Input.GetKey(KeyCode.RightArrow))
			// {
				// responses[trialNumber, 5] = 1;
				// Input.ResetInputAxes();
			// }
			// else if(Input.GetKey(KeyCode.LeftArrow))
			// {
				// responses[trialNumber, 5] = 2;
				// Input.ResetInputAxes();
			// }
			// else
			// {
				// responses[trialNumber, 5] = 0;
			// }
			
			// for (int j = 0; j< (stimSize*stimSize);j++)								   
			// {
				// Animators[j].gameObject.name="Animator"+(j+1);
				// Animators[j].SetInteger("LR", 0);
				// Animators[j].SetInteger("U", 0);
				// Animators[j].SetInteger("KU", 0);
				// Animators[j].SetInteger("D", RightLeft[j]);
				// Animators[j].SetInteger("I", RightLeft[j]);
			// }
			 // // print("Down");
			
			// yield return new WaitForSeconds(1f); // the time that avatars have already lowered their hands and stay in their idle posture before returning to their original posture
			// for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			// {
				// Animators[j].gameObject.name="Animator"+(j+1);
				// Animators[j].SetInteger("D", 0);
				// Animators[j].SetInteger("I", 0);
				// Animators[j].SetInteger("O", RightLeft[j]);
			// }
			// yield return new WaitForSeconds(3f);
			// print("Back");
			// for (int j = 0; j< (stimSize*stimSize);j++)								   // here, avatars lower their hands and go back to their original posture, waiting for the next trial to start
			// {
				// Animators[j].gameObject.name="Animator"+(j+1);
				// Animators[j].SetInteger("O", 0);
			// }
			// responses[trialNumber,0]=conditionSelect;
			// responses[trialNumber,3]=pamponColorSelcet;
			// print("responses: " + trialNumber + " , " + responses[trialNumber,0] + " , " + responses[trialNumber,1] + " , " + responses[trialNumber,2] + " , " + responses[trialNumber,3]);
			// dataStringCoroutine = DataStringMaker(responses, trialNumber, MyList);
			// StartCoroutine(dataStringCoroutine);
			// trialNumber=trialNumber+1;
		// }
    }

    private void DeactivateOriginalAvatars()
    {
        for (int i = 0; i < avatarPrefabs.Length; i++)
        {
            avatarPrefabs[i].SetActive(false);
        }
    }
	
	
	private void ApplyRandomColorVariation(int q, GameObject newAvatar)
    {
		// ChangeGlovesColor(newAvatar.transform);
		newAvatar=myAvatars[q];
        foreach (Renderer renderer in newAvatar.GetComponentsInChildren<Renderer>())
        {
            if (!renderer.gameObject.name.Contains("Body") && 
                !renderer.gameObject.name.Contains("Hair") &&
				!renderer.gameObject.name.Contains("SphereL") &&
				!renderer.gameObject.name.Contains("SphereR") &&				
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
	

    private void ApplyColorPampons(GameObject newAvatar1, int ColorSelcet)
    {
		// ChangeGlovesColor(newAvatar.transform);
        foreach (Renderer renderer in newAvatar1.GetComponentsInChildren<Renderer>())
        {		
			if ((renderer.gameObject.name.Contains("g_RetopoGroup1_RetopoGroup1") ||
				renderer.gameObject.name.Contains("g_RetopoGroup2_RetopoGroup2") ||
				renderer.gameObject.name.Contains("SphereL")) && ColorSelcet==1)
            {
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					newMaterial.color = Color.yellow;
                    newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;
			}
			if ((renderer.gameObject.name.Contains("g_RetopoGroup3_RetopoGroup3") ||
				renderer.gameObject.name.Contains("g_RetopoGroup4_RetopoGroup4") ||
				renderer.gameObject.name.Contains("SphereR")) && ColorSelcet==1)
            {
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					// newMaterial.color = new Color(12/255f, 111/255f, 188/255f);
					newMaterial.color = Color.blue;
                    newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;
			}
			
			if ((renderer.gameObject.name.Contains("g_RetopoGroup3_RetopoGroup3") ||
				renderer.gameObject.name.Contains("g_RetopoGroup4_RetopoGroup4") ||
				renderer.gameObject.name.Contains("SphereR")) && ColorSelcet==2)
            {
				// print(renderer.gameObject.name);
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					// newMaterial.color = new Color(12/255f, 111/255f, 188/255f);
					newMaterial.color = Color.yellow;
                    newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;
			}
			if ((renderer.gameObject.name.Contains("g_RetopoGroup1_RetopoGroup1") ||
				renderer.gameObject.name.Contains("g_RetopoGroup2_RetopoGroup2") ||
				renderer.gameObject.name.Contains("SphereL")) && ColorSelcet==2)
            {
				// print(renderer.gameObject.name);
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					newMaterial.color = Color.blue;
                    newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;
			}
        }
		// ChangeGlovesColor(newAvatar.transform);
    }
	
	
	private void ApplyBlackPampons(GameObject newAvatar1)
    {
		// ChangeGlovesColor(newAvatar.transform);
        foreach (Renderer renderer in newAvatar1.GetComponentsInChildren<Renderer>())
        {
			renderer.enabled = true;
			if (renderer.gameObject.name.Contains("g_RetopoGroup1_RetopoGroup1") ||
				renderer.gameObject.name.Contains("g_RetopoGroup2_RetopoGroup2") ||
				renderer.gameObject.name.Contains("SphereL"))
            {
				// print(renderer.gameObject.name);
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					newMaterial.color = Color.black;
					// Color color = newMaterial.color;
					// color.a = 0f;
					// newMaterial.color = color;
                    newMaterials[i] = newMaterial;
                }
                renderer.materials = newMaterials;

			}
			if (renderer.gameObject.name.Contains("g_RetopoGroup3_RetopoGroup3") ||
				renderer.gameObject.name.Contains("g_RetopoGroup4_RetopoGroup4") ||
				renderer.gameObject.name.Contains("SphereR"))
            {
				// print(renderer.gameObject.name);
                Material[] newMaterials = new Material[renderer.materials.Length];
                for (int i = 0; i < renderer.materials.Length; i++)
                {
                    Material newMaterial = Instantiate(clothingMaterialTemplates[Random.Range(0, clothingMaterialTemplates.Length)]);

                    // Color randomColor = GenerateNonYellowBlue();
					// Color randomColor = new Vector4(0f,0.5f,0f);
					newMaterial.color = Color.black;
					// newMaterial.color = Color.clear;
					// newMaterial.color = new Color(1f, 0f, 0f, -0.001f);
					// Color color = newMaterial.color;
					// color.a = 0f;
					// newMaterial.color = color;
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
	
	
	
	// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                   make data string                   ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		IEnumerator DataStringMaker(float[,] responses, int trialNum, List<string> myList){
			print("Asi  "+trialNum+"  ,  "+numTrialsTrain+"  ,  "+numTrialsTest);
			tempStr=(((responses[trialNum, 0]).ToString())+", "+((responses[trialNum, 1]).ToString())+", "+((responses[trialNum, 2]).ToString())+", "+((responses[trialNum, 3]).ToString()));
			myList.Add(tempStr);
			
			if (trialNum==(numTrialsTrain+numTrialsTest-1))		// *2 because we have two test sessions (blocks). Since the trialNum starts at 1, no need to subtract 1 from the summation
			{
				WWWForm form=new WWWForm();
				prolificIdString2=prolificID.GetComponent<InputField>().text;
				form.AddField(address[0],prolificIdString2);
				form.AddField(address[1],"LargeSmallPopulation");		// a code to simplify distinguishing the data from each experiment
				// form.AddField(address[2],InstructionPick);		// a code to simplify distinguishing the data from each experiment
				for(int i = 0; i < (numTrialsTrain+numTrialsTest-1); i++)
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
		//Input.ResetInputAxes();
		yield return null;
		// yield return new WaitForSeconds(0.5f);
		//yield return www;
		}
		
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::   save basic information of the participant  on google form   :::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	public void Send(){
		prolificIdString1=prolificID.GetComponent<InputField>().text;
		int count = prolificIdString1.Length;
		if (count<20)
		{
			Error.SetActive(true);
		}
		else
		{
			// Error.SetActive(false);
			// prolificIdString1="Asi";
			// StartCoroutine(PID(prolificIdString1));
			prolificID.SetActive(false);
			// 
			myButton.SetActive(false);	// This removes the button from the UI entirely:
			CanvasObject.GetComponent<Canvas>().enabled = false;
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
			Input.ResetInputAxes();
			C1=Start();
			StartCoroutine(C1);
			// Step 1: Generate Positions
			StartCoroutine(GeneratePositions());

			// Step 2: Instantiate Avatars
			StartCoroutine(InstantiateAvatars());
		}
		//ExpManager.SetActive(true);
	}
}