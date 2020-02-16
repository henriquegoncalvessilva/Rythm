using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerRythm : MonoBehaviour
{
    public GameObject _samplesPrefab;

    public GameObject[] _sampleCube = new GameObject[512];

    public float _maxScale;



    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject _instanceCubes = (GameObject)Instantiate(_samplesPrefab);
            _instanceCubes.transform.position = this.transform.position;
            _instanceCubes.transform.parent = this.transform;
            _instanceCubes.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceCubes.transform.position = Vector3.forward * 500f;
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
