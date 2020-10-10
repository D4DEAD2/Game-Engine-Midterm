﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabTag : MonoBehaviour
{
    public GameObject pManager;
    private ManagerPlugin plugMan;
    public Text cPnt1;
    public Text cPnt2;
    public Text cPnt3;
    public Text cPnt4;
    public Text cPnt5;
    public Text total;

    // Start is called before the first frame update
    void Start()
    {
        if(pManager == null)
        {
            pManager = GameObject.FindWithTag("PManager");
            plugMan = pManager.GetComponent<ManagerPlugin>();

            cPnt1.text = "Checkpoint 1: " + plugMan.LoadTimer(0);
            cPnt2.text = "Checkpoint 2: " + plugMan.LoadTimer(1);
            cPnt3.text = "Checkpoint 3: " + plugMan.LoadTimer(2);
            cPnt4.text = "Checkpoint 4: " + plugMan.LoadTimer(3);
            cPnt5.text = "Checkpoint 5: " + plugMan.LoadTimer(4);
            total.text = "Total: " + plugMan.LoadTotalTime();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}