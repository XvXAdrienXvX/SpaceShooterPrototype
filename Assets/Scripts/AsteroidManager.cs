using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField]
    Asteroid asteroidGameObject;
    [SerializeField]
    private int asteroidBeltSize = 50;
    [SerializeField]
    private int numberOfAsteroids = 10;

    void Start()
    {
        PlaceAsteroids();
    }

    private void PlaceAsteroids()
    {
        for (int xPosition = 0; xPosition < numberOfAsteroids; xPosition++)
        {
            for (int yPosition = 0; yPosition < numberOfAsteroids; yPosition++)
            {
                for (int zPosition = 0; zPosition < numberOfAsteroids; zPosition++)
                {
                    InstantiateAsteroid(xPosition, yPosition, zPosition);
                }
            }           
        }
    }

    private void InstantiateAsteroid(int xPosition, int yPosition, int zPosition)
    {
        Instantiate( asteroidGameObject, new Vector3(
                     transform.position.x + (xPosition * asteroidBeltSize) + AsteroidOffset(), 
                     transform.position.y + (yPosition * asteroidBeltSize) + AsteroidOffset(),
                     transform.position.z + (zPosition * asteroidBeltSize) + AsteroidOffset()), 
                     Quaternion.identity, transform
                    );
    }

    private float AsteroidOffset()
    {
       return Random.Range(-asteroidBeltSize / 2f, asteroidBeltSize / 2f);
    }
}
