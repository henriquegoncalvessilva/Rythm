using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerRythm : MonoBehaviour
{

    //Object Spawnned(Can be 3D OBJECT or 2D OBJECT);
    public GameObject _samplesPrefab;


    public GameObject[] _sampleCube = new GameObject[512];

    //Scale of objects spawnned;
    public float _maxScale;

    //Distance of object spawnned.
    public float distance = 100f;

    //angle = Angle of wave.

    public float angle;


    // Start is called before the first frame update
    void Start()
    {
        //512 = amples of song. You custom this value how you want.

        angle = angle / 512;

        for (int i = 0; i < 512; i++)
        {
            GameObject _instanceCubes = (GameObject)Instantiate(_samplesPrefab);
            _instanceCubes.transform.position = this.transform.position;
            _instanceCubes.transform.parent = this.transform;
            _instanceCubes.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -angle * i, 0);
            _instanceCubes.transform.position = Vector3.forward * distance;
            _sampleCube[i] = _instanceCubes;

        }
    }

    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (_sampleCube != null)
            {
                _sampleCube[i].transform.localScale = new Vector3(10, (GameManager._samples[i] * _maxScale) + 2, 10);
            }
        }
    }
}
