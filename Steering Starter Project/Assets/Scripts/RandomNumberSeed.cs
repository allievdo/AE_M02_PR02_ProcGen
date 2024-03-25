using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberSeed : MonoBehaviour
{
    public string seedString = "default";
    public bool useSeedString;
    public int seed;
    public bool randomizeSeed = false;

    public Text displaySeed;

    private void Awake()
    {
        seedString = "default";
        seed = 123456;
    }
    //private void Awake()
    //{
    //    seedString = UserInputSeed.input;
    //    if (useSeedString)
    //    {
    //        seed = seedString.GetHashCode(); //get hash code takes a string and turns it into an int
    //    }

    //    if (randomizeSeed)
    //    {
    //        seed = UnityEngine.Random.Range(0, 99999);
    //    }

    //    UnityEngine.Random.InitState(seed); //takes an int and initializes the random number generator
    //}

    private void Update()
    {
        if (UserInputSeed.input == null)
        {
        seedString = "default";
        }

        seedString = UserInputSeed.input;
        if (useSeedString)
        {
            seed = seedString.GetHashCode(); //get hash code takes a string and turns it into an int
        }

        if (randomizeSeed)
        {
            seed = UnityEngine.Random.Range(0, 99999);
        }

        UnityEngine.Random.InitState(seed); //takes an int and initializes the random number generator

        displaySeed.text = "Current seed: " + seed.ToString();
    }
}
