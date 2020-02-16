using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static float[] _samples = new float[512];

    [SerializeField]
    AudioSource music;

    [SerializeField]
    bool playGame;

    [SerializeField]
    NoteController nController;

    [SerializeField]
    KeyCode key;

    

    void Start()
    {
       
    }

    void Update()
    {

       

        music.GetSpectrumData(_samples, 0, FFTWindow.Blackman);

        /*if (!playGame)
        {
            if (Input.GetKeyDown(key))
            {
                playGame = true;
                nController.SetStart(playGame);
            }
        }*/

        /*  else if (playGame)

              if (Input.GetKeyDown(key))
              {
                  playGame = false;
                  nController.SetStart(playGame);
              }*/
    }


}