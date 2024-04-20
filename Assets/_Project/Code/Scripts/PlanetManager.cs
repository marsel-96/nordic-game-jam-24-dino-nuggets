using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Code.Scripts
{
    public class PlanetManager: MonoBehaviour
    {
        [SerializeField] private List<Planet> planets;
        [SerializeField] private float spawnPlanet = 30.0f;
        
        private float _spawnPlanetTimer;
        
        private void Update()
        {
            _spawnPlanetTimer += Time.deltaTime;
            if (_spawnPlanetTimer >= spawnPlanet)
            {
                SpawnPlanet();
                _spawnPlanetTimer = 0.0f;
            }
        }

        private void SpawnPlanet()
        {
            foreach (var planet in planets)
            {
                if (!planet.isActiveAndEnabled)
                {
                    planet.gameObject.SetActive(true);
                    return;
                }
            }
        }
    }
}