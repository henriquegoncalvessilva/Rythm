using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{

    [SerializeField]
    float BeatTime;

    [SerializeField]
    bool start;

    void Start()
    {
        BeatTime = BeatTime / 60f;
    }

    

    public void SetStart(bool value)
    {
        start = value;

    }


    void Update()
    {
        if (start)
        {

            Debug.LogError("Start");
            transform.position -= new Vector3(0f, BeatTime * Time.deltaTime, 0f);

        }

        else
        {


            Debug.LogError("Stop");
            transform.position -= new Vector3(0f, 0 * Time.deltaTime, 0f);

        }


    }




}
