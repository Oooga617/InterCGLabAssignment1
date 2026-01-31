using UnityEngine;
using Unity.Cinemachine;
using NUnit.Framework;
using System.Collections.Generic;

public class CamController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public CinemachineBrain cineMachine;
    public List<GameObject> cams;
    private int index = 0;
    void Start()
    {
        cineMachine = GetComponent<CinemachineBrain>();
        deactivateAllButOne();
    }

    public void deactivateAllButOne()
    {
        for (int i = 1; i <cams.Count; i++)
        {
            cams[i].SetActive(false);
        }
    }

    public void nextShot()
    {
        cams[index].SetActive(false);
        index += 1;
        cams[index].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
