using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static float[] _samples = new float[512];

    [SerializeField]
    AudioSource music;

    void Update()
    {



        music.GetSpectrumData(_samples, 0, FFTWindow.Blackman);


    }


}