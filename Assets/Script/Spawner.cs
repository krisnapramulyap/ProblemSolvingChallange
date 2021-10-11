using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Kubus;
    public float SisiKiri, SisiKanan, SisiAtas, SisiBawah;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        int PenghitungBarang = Random.Range(3, 15);
        for (int i = 0; i < PenghitungBarang; i++)
        {
            float randomX = Random.Range(SisiKiri, SisiKanan);
            float randomY = Random.Range(SisiAtas, SisiBawah);
            Instantiate(Kubus, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}