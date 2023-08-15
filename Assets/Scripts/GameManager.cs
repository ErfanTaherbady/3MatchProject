using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ErfanDeveloper
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private CarCode[] cars;

        public void CreateNewCar(Transform spawnPoint)
        {
            int randomCarIndex = Random.Range(0, cars.Length);
            GameObject newCar = Instantiate(cars[randomCarIndex].gameObject,
                spawnPoint.position, quaternion.identity);
        }
    }
}